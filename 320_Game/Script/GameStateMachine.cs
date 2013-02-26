using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class MainRpsMatch : MonoBehaviour {

	void SetStateArray() {
        
        mStateArr.AddAMember("Begin", 3);
        mStateArr.AddEntryAction( () => { 
            
            //----------------------------texture;
            PutOnTexture();
            //------------------------------
            StatusBarPic(false);
            arrMyScore = new List<bool>(); arrEnScore = new List<bool>();
            mAllPoint = Ag.mgPrevScore = Ag.mySelf.mRankObj.mScore;
            //Ag.LogString("Game :: BeGin ");
            SoundManager.Instance.Play_Effect_Sound("05_Crowd_etc");
            CerCam.enabled = false;
            mIntroCam.enabled = true;
            FieldChanged (false);
            Ag.mRound = 0;
            IntroAni();
            
        } );
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("CountDn", 0.5f);
        mStateArr.AddEntryAction( () => { 
            Ag.mgDirection = Ag.mgSkill = 0;
            Ag.mgGamePackReceived = mDidBuyPotion = false;
            Ag.LogString("Game :: CountDn ");
            //SoundManager.Instance.Play_Effect_Sound("crowd_ready");
            Ac.GameReady2Go();
             //mEventPotion = mEventminusPotion = false;
        });
        mStateArr.AddExitCondition( () => { return Ag.mgGamePackReceived;  } ); 
        mStateArr.AddExitAction( ()=> {
            AmPlayer curKicker = (Ag.mgIsKick)? Ag.mySelf.mCurPlayer: Ag.myEnem.mCurPlayer;
            //curKicker.SetDirectionArea();  [2012:11:9:ljk] DirectionArea deleted
        });
        mStateArr.AddTimeOutProcess( 20.0f, ()=>{  
            Ag.LogNewLine(20); Ag.LogString("Application.LoadLevel");
            mStateArr.SetStateWithNameOf("HeartBeat"); // [2012:11:12:MOON] Heart Beat       //mAwayMyself = true;
        } );
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("PreGame", 3f);
        mStateArr.AddEntryAction( () => {
            LodingBarOff(true);
            mskillflag = true;
            mEffballflag = true;
            
            //mGameObj2.SetActive(false);
            GameObjectRndBox(false);
            mEventDirspeed = 0.8f;
            mEventSkillSpeed = 0.8f;
            //------------------------------------------
            RandomNum(); 
            if (Ag.mBallEventAlready ) { if (Ag.mgIsKick) { if(mMiniItem.active = true) mMiniItem.transform.renderer.material.SetColor("_TintColor", new Color (0.5f,0.5f,0.5f)); } else {  if(mMiniItem.active = true) mMiniItem.transform.renderer.material.SetColor("_TintColor", new Color (0.2f,0.2f,0.2f)); }}
           // else {mMiniItem.SetActiveRecursively(false);}
            mEventBallActive(mBallPoint.ToString (), mBallPoint2.ToString(), mBallPoint3.ToString(),true);//RandomBox
            ItemMainTexturechange("14");
            //------------------------------------------
            FieldChanged(true);
            SoundManager.Instance.Play_Effect_Sound("02_Crowd_Set");
            mStage.InitCursorMove(0.8f,800f);
            mCerCamAxis.SetActiveRecursively(false);
            mDidDragStarted = false;
            RedbullAni ();
            StatusBarPic(false);
            mbtnRedbull.SetActiveRecursively(true);
            mKeeperSetDir = false;
            Ac.PotionCount();
            mIntroCam.enabled = false;
            mStage.mIsTouched = true;
            CameraSet ();
            DestroyObject(mKickBall);
            mKickBall = (GameObject)Instantiate(Resources.Load("prefeb_Polygon/Ball"));
            mCurPlayer = Ag.mySelf.mCurPlayer; //GetKicker( 1 );
            mCurEnem = Ag.myEnem.mCurPlayer; //.GetGoulKeeper();
            //----------------------------------------------------
            mCharacterinfor.SetActiveRecursively(true);
            mPlayerPicinfo.transform.renderer.material.mainTexture = mCurPlayer.mPlayerPic; 
            mCurPlayer.SetBioRythmStateBar();
            mPlayerBioinfo.transform.renderer.material.mainTexture = mCurPlayer.mBioRythmStateBar;
            //----------------------------------------------------
            if(mItemflag1 && Ag.mBallEventAlready && (mGoldenBall || mBronzeBall || mSilverBall)) { if(Ag.mgIsKick){  StartCoroutine(mRandomItemoff(3f)); StartCoroutine(YieldGoldenballeff(3.2f)); mItemflag1 = Ag.mBallEventAlready = false; mGoldenAfter = mGoldenBall; mSilverAfter = mSilverBall ; mBronzeAfter = mBronzeBall; mGoldenBallEff = true; } }
            if(mItemflag1 && Ag.mBallEventAlready && mSlowEff ) { if(Ag.mgIsKick){  StartCoroutine(mRandomItemoff(3f)); mEventDirspeed = 1f; mEventSkillSpeed = 1f; mItemflag1 = mSlowEff = Ag.mBallEventAlready = false;} }
            
            Debug.Log(" My Self Player  " + mCurPlayer.mPlayerUNO + "     Enemy Player  " + mCurEnem.mPlayerUNO );
            
            if ( Ag.mgIsKick ) {   //...  Set Player Object
                
                KpLodingBarAni(3f,"START","labelani",false);
                KpLodingBarAni(2.2f,"1","labelani",true);
                KpLodingBarAni(1.4f,"2","labelani",true);
                KpLodingBarAni(0.1f,"READY","Ready",false);
                
                KickerScenePlay ( false);
                
                zoomCameraFlag = true;
                //mCurPlayer.SetDirectionArea();
                for (int i = 0 ; i < 4; i++) { arrKickerDirBar[i].SetActive(true);}
                //SetKickerDir( true);
                //Debug.Log (">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mCurEnem.mPoly);
                //mPlayerKicker = (GameObject)Instantiate(mCurPlayer.mPoly);
                DestroyObject(mPlayerKicker);
                DestroyObject(mPlayerKeeper);
             //Debug.Log (">>>>>>>>>>>>>>>MYPlayerUNo>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mCurPlayer.mPlayerUNO);
                //mEnemyObject = Ag.mySelf.GetPlayerUNOof (mCurPlayer.mPlayerUNO);
                
                //mCurPlayer.SetNameAndPolygon(mCurPlayer.mPlayerUNO);
                mCurPlayer = Ag.mySelf.GetPlayerUNOof(mCurPlayer.mPlayerUNO);
                
                mPlayerKicker = (GameObject)Instantiate(mCurPlayer.mPoly);
                mPlayerKeeper = (GameObject)Instantiate (mCurEnem.mPoly);
                Debug.Log (" MyObject    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>        "+mCurPlayer.mPoly);
                PutOnTexture();
                mBall = mPlayerKicker.transform.FindChild("deleveryBall").gameObject.gameObject;
                mBall.transform.renderer.enabled = false;
                //itmObj = Ag.mySelf.GetAnyItemOfPlayer( mCurPlayer );
                int mMyitem = mCurPlayer.GetSkillItem();
                
                if (mCurPlayer.mItemCount > 0) {
                     //Debug.Log ("MyItemObj>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+ itmObj.mItemUNO);

                    ItemEquitSlot(mMyitem);
                    mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = mItemTex;
                }else{ 
                    mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = (Texture2D)Resources.Load("UIsource/ClothTexture/Shoes/Shoes_Nolmal");
                }
                //-------------------------------------------------------LJk 2012 08 22
                int itemUNO = mCurEnem.GetSkillItem(); 
                
                if (mCurEnem.mItemCount > 0) {
                    ItemEquitSlot(itemUNO);
                    mPlayerKeeper.transform.FindChild("keeper_groverpart").renderer.material.mainTexture = mItemTex;
                } else { 
                    mPlayerKeeper.transform.FindChild("keeper_groverpart").renderer.material.mainTexture = (Texture2D)Resources.Load("UIsource/ClothTexture/Glove/Glover_Normal");
                }
                //---------------------------------------------------------
               for (int j = 0 ; j < 4 ; j++ ) {
                    Debug.Log ("PlayerDirectionPos                  "+mCurPlayer.mDirectObj.mPosition[j].ToString() + "                   PlayerDirectionWidth                       " + mCurPlayer.mDirectObj.mWidth[j].ToString()           );
                }
                PreAni ();
                DrawGuideLine();  //2013/2/14
                CreateGuidebar();
                GuidebarAniPlay();
                //mCurPlayer.ShowAdvantage();
            } else {
                KpLodingBarAni(6f,"END","labelani",false);
                KpLodingBarAni(5.2f,"1","labelani",true);
                KpLodingBarAni(4.4f,"2","labelani",true);
                KpLodingBarAni(3.1f,"SELECT","Ready",false);
                
                
                mPlayerInfoX = 0.9f;
                StartCoroutine(PlayerinfobarFlag(0.5f));
                StartCoroutine(KeeperLodingBarAni(3f));
                
                DragNum = 0;
                KickerScenePlay ( false);
                //mCurEnem.SetDirectionArea();
                //mPlayerinfoflag = true;
                
                Ag.LogString("Number    >>> " + Ag.mySelf.arrAllPlayer.Count );
                
                for (int ij=0; ij<8; ij++) {
                    AmPlayer curObj = (AmPlayer)Ag.mySelf.arrAllPlayer[ij];  //.GetPlayerUNOof(ij);
                    curObj = (AmPlayer)Ag.mySelf.GetPlayerUNOof(ij+1);
                }
                //mKpDirbar.transform.renderer.enabled = true;
                //DragPosition (true); //2.18
                //KeeperViewPreAni();
                GuideKeeperViewAni();
                mTimerObj.WaitTimeFor(6.1f);
                mTimerFlag = true;
                
                
                DestroyObject(mPlayerKicker);
                DestroyObject(mPlayerKeeper);
                //Debug.Log (">>>>>>>>>>>>>>>EnemyPlayerUNo>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mCurEnem.mPlayerUNO);
                //mEnemyObject = Ag.myEnem.GetPlayerUNOof (mCurEnem.mPlayerUNO);
                //mCurEnem.SetNameAndPolygon(mCurEnem.mPlayerUNO);
                //mCurEnem = Ag.myEnem.GetPlayerUNOof (mCurEnem.mPlayerUNO); ljk 11/16
                
                
                mPlayerKicker = (GameObject)Instantiate(mCurEnem.mPoly);
                mPlayerKeeper = (GameObject)Instantiate(mCurPlayer.mPoly);
                
                PutOnTexture();
                mBall =     mPlayerKicker.transform.FindChild("deleveryBall").gameObject.gameObject;
                mBall.transform.renderer.enabled = false;
                int itemUNO = mCurEnem.GetSkillItem(); 
                
                //itmObj = Ag.myEnem.GetAnyItemOfPlayer( mCurEnem );
                
                    Debug.Log ("mEnemyItemObj>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+ mCurEnem.mItemCount);

                
                if (mCurEnem.mItemCount > 0) {
                    
                    ItemEquitSlot(itemUNO);
                    mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = mItemTex;
                }else{ 
                    mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = (Texture2D)Resources.Load("UIsource/ClothTexture/Shoes/Shoes_Nolmal");
                }
                //--------------------------------------------------------------------------------------Ljk 2012 08 22
                
                int MyItem = mCurPlayer.GetSkillItem(); 
                if (mCurPlayer.mItemCount > 0) {
                    ItemEquitSlot(MyItem);
                    mPlayerKeeper.transform.FindChild("keeper_groverpart").renderer.material.mainTexture = mItemTex;
                } else { 
                    mPlayerKeeper.transform.FindChild("keeper_groverpart").renderer.material.mainTexture = (Texture2D)Resources.Load("UIsource/ClothTexture/Glove/Glover_Normal");
                }
                //---------------------------------------------------------------------------------------
                
                PreAni ();
                
        
            }
            
            //---------------------------------------------------------SingleMode Item ljk 11/23
            /*
            if (Ag.mSingleMode ){
                int mMyitem = Ag.mySelf.arrSinglePlayer[mSinglePlayerNum].GetSkillItem();
                if (Ag.mySelf.arrSinglePlayer[mSinglePlayerNum].mItemCount > 0) {
                        ItemEquitSlot(mMyitem);
                        mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = mItemTex;
                }else{ 
                        mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = (Texture2D)Resources.Load("UIsource/ClothTexture/Shoes/Shoes_Nolmal");
                }
                mSinglePlayerNum++;
                if (Ag.mySelf.arrSinglePlayer.Count-1 < mSinglePlayerNum) mSinglePlayerNum = 0;
            }
            */
            //-----------------------------------------------------------
            
            Debug.Log (mSinglePlayerNum + "------------------------------------------------------------------mSinglePlayer");
            
            mBippos =   mPlayerKeeper.transform.FindChild("Bip001").gameObject.gameObject;
            mBippos2 =  mPlayerKeeper.transform.FindChild("Bip001").gameObject.gameObject;
            mKpTrailL = mPlayerKeeper.transform.FindChild(mFoldNameL).gameObject.gameObject;
            mKpTrailR = mPlayerKeeper.transform.FindChild(mFoldNameR).gameObject.gameObject;
            CharacterInforAni(true);
        } );
        mStateArr.AddExitAction( () => { 
            mPotionNum = (int)Ag.mySelf.mPorsion;
         RedbullNum();
            Ag.net.mDebugLog = true; } );
        
         //  ________________________________________________ Add A Member.. Ljk Mid Direction potion..
        mStateArr.AddAMember("BeforeDirPotion", 1f);
        mStateArr.AddEntryAction( () => {
            
            mStage.mIsTouched = mStatusSillBar = false;
            if(mEventItemShowTime) 
                StartCoroutine(WaittimeItemShow(2f));
            else {  mGameObj.SetActiveRecursively(false);  mEventItemShowTime = false; }
            
            //mStage.mCursorPosition = 1.0f;
            if ( !mDidEventPotion && !mDirMinuspotion) mStateArr.SetStateWithNameOf("MidPausBiggerGamdDir");
            else { 
                //mskillBareff.GetComponent<ParticleSystem>().Play();
                //arrStatusBar[1].animation.Play("Redbull");
            }
            
        } );
        //  ________________________________________________ Add A Member.. Ljk Mid Direction potion..
        mStateArr.AddAMember("MidPausBiggerGamdDir", 1f);
        mStateArr.AddEntryAction( () => {
            //mStage.mCursorPosition = 1.0f;
            GameObject mDirUPclone;
            if (Ag.mgIsKick) {
                if( mDidEventPotion) { mCurPlayer.ExpandDirection(); mDirBareff.GetComponent<ParticleSystem>().Play(); SoundManager.Instance.Play_Effect_Sound("ApplyRedBull"); }
                if( mDirMinuspotion) { mCurPlayer.ReduceDirection(); mDirBareff.GetComponent<ParticleSystem>().Play(); SoundManager.Instance.Play_Effect_Sound("ApplyRedBull"); }
                if(mItemflag1 && Ag.mBallEventAlready && (mDidEventPotion||mDirMinuspotion)) { if(Ag.mgIsKick){ MiniRandomItemAniPlay(mRevRoundAni); StartCoroutine(mRandomItemoff(0.8f)); Ag.mBallEventAlready = mItemflag1 = mDidEventPotion = mDirMinuspotion = false; } }
                mStartTime = Time.timeSinceLevelLoad;
                
            }
            //mCurPlayer.SetSkillPositions( mDidBuyPotion, Ag.mySelf.IsPerfectOn(), mEventPotion ,mEventminusPotion);  // Potion apply...
        } );
        
        //  ________________________________________________ Add A Member.. Ljk Mid Direction potion..
        
        
        mStateArr.AddAMember("GameDir", 2f);
        mStateArr.AddEntryAction( () => { 
            mStage.InitCursorMove( mEventDirspeed, 300f );
            mCrowd.GetComponent<Crowd>().mFlag = false;
         mParTicle.GetComponent<ParticleSystem>().Pause();
            mSkillSound = false;
            //mCrowd.GetComponent<Crowd>().enabled = false;
            
             //EventBall Remove
            //mDidEventPotion = mDirMinuspotion = false;
            
            if (Ag.mgIsKick) {
                SoundManager.Instance.Play_Effect_Sound("BarMoving_01");
         } else {
                //mGameObj2.SetActive(false);
                GameObjectRndBox(false);
            }
            
        });
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("MidPaus", 0.3f);
        mStateArr.AddEntryAction( () => {
            
            mbtnRedbull.SetActiveRecursively(false);
            if(Ag.mgIsKick) {
                Ag.mRound++;
             if (Ag.mgDirection == 0) {
                 SetKickerDir (false);
             }
            } else {
                //if (Ag.mgDirection == 0)            SoundManager.Instance.Play_Effect_Sound("Bad");
                if ( 0 < Ag.mgDirection ) 
                    SoundManager.Instance.Play_Effect_Sound("SelectDirection");
            }
            DragPosition(false);
         mTimerFlag = false;
         mTimerbar.active = false;
            //mKpDirbar.transform.renderer.enabled = false;
            //SetKickerDir (false);    
        } );
        mStateArr.AddExitAction( () => {
            mStage.InitCursorMove( 5f, 300f ); 
        } );  // Save Touch Points [GAM_RLT]
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("MidPausPotion", 1f);
        mStateArr.AddEntryAction( () => {
            mStage.mIsTouched = mStatusSillBar = false;
            if (Ag.mgIsKick) {
                DestoryGuideBar ();
            }
            //DestoryDicGuideBar();
            //mStage.mCursorPosition = 1.0f;
            if ( !mDidBuyPotion && !mEventPotion && !mEventminusPotion ) mStateArr.SetStateWithNameOf("MidPausBiggerPotion");
            else {
                if (mDidBuyPotion) {
                    Debug.Log ("Drink!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    SoundManager.Instance.Play_Effect_Sound("ApplyRedBull");
                    //arrStatusBar[0].animation.Play("");
                    GameObject.Find("UI Root/Camera/Anchor/StatusBar/Redbull/Background").gameObject.animation.Play("pocari");
                } 
                
            }
            mCurPlayer.SetSkillPositions( false, Ag.mySelf.IsPerfectOn(), false ,false);
        } );
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("MidPausBiggerPotion", 1f);
        mStateArr.AddEntryAction( () => {
            mStartTime = Time.timeSinceLevelLoad;
              // Potion apply...
            GameObject mDirUPclone;
            
            if(mDidBuyPotion || (Ag.mgIsKick && (mEventPotion || mEventminusPotion))) {
                if (mEventPotion) {
                    SoundManager.Instance.Play_Effect_Sound("ApplyRedBull");
                } else if (mEventminusPotion) {
                    SoundManager.Instance.Play_Effect_Sound("ApplyRedBull");
                }
                mskillBareff.GetComponent<ParticleSystem>().Play();
                    mCurPlayer.SetSkillPositions( mDidBuyPotion, Ag.mySelf.IsPerfectOn(), false ,false);
                if (Ag.mgIsKick && (mEventPotion || mEventminusPotion)) {
                    mCurPlayer.SetSkillPositions( mDidBuyPotion, Ag.mySelf.IsPerfectOn(), mEventPotion ,mEventminusPotion);
                }
            }
            if(Ag.mgIsKick && mItemflag1 && Ag.mBallEventAlready && (mEventPotion || mEventminusPotion)) { if(Ag.mgIsKick){ MiniRandomItemAniPlay(mRevRoundAni); StartCoroutine(mRandomItemoff(0.8f)); mEventPotion = mEventminusPotion = mItemflag1 = Ag.mBallEventAlready = false; } }
            //mStage.mCursorPosition = 1.0f;
            
        } );
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("GameSkl", 2f);
        mStateArr.AddEntryAction( () => {
            mKeeperLabel.transform.renderer.enabled = false;
            zoomCameraFlag = false;
            mSkillSound = false;
         if (Ag.mgIsKick) {
             KickerScenePlay ( false);
                mstatusBar = false;
         }
            SoundManager.Instance.Play_Effect_Sound("BarMoving_01");
            mStage.InitCursorMove( mEventSkillSpeed, 300f );
            //mStatusSillBar = true;
            mDidBuyPotion = false;
        } ); 
 //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("AftPaus", 0.7f);
        mStateArr.AddEntryAction( () => {
           mskillflag = mStatusSillBar = true;
            // if (Ag.mgSkill == 0 && !mSkillSound)                 SoundManager.Instance.Play_Effect_Sound("Bad");             mSkillSound = false;
            
            //mCrowd.GetComponent<Crowd>().enabled = true;
            mCrowd.GetComponent<Crowd>().mFlag = true;
            mParTicle.GetComponent<ParticleSystem>().Play();
            
            Ag.mgGamePackReceived = false;
         mNetworkWaitAni();
         StatusBarPic(false);
         //mStage.mIsTouched = true;
            //Ag.mgSkill = mCurPlayer.GetPosition( mStage.mCursorPosition ); // Save Touch Points [GAM_RLT]
            Ac.GameResult();         });
        mStateArr.AddExitCondition( () => { return Ag.mgGamePackReceived;  } );
        mStateArr.AddTimeOutProcess( 25.0f, ()=>{  
            Ag.LogNewLine(20); Ag.LogString("Application.LoadLevel");
            mStateArr.SetStateWithNameOf("HeartBeat"); // [2012:11:12:MOON] Heart Beat   //  mAwayMyself = true;
        } );

        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("NetWait", 2f);
        mStateArr.AddEntryAction( () => { 
            
            SoundManager.Instance.audio.volume = 1f;
            SoundManager.Instance.Play_Effect_Sound("whistle_1");
            SoundManager.Instance.audio.volume = 1f;
            EnemyCharacterEffect();
             });
        mStateArr.AddExitCondition( () => { return Ag.net.IsNetworkIdle();  } );
        // [2012:11:12:MOON] Heart Beat   mStateArr.AddTimeOutProcess( 20.0f, ()=>{ mAwayMyself = true; } );
        
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("AnimaPlay", 3.7f);
        mStateArr.AddEntryAction( () => { 
            LodingBarOff(false);
            for (int i = 0 ; i < 4 ; i++ ) {
                arrAimObj[i].transform.renderer.enabled = false;
            }
           CharacterInforAni(false);
            //mEventPotion = mEventminusPotion = false;
            //mStage.InitCursorMove( 0.8f, 800f );
            DragPositionF(false);
            SetKickerDir (false);
            FieldChanged (false);
            KickerScenePlay (true);
         SoundManager.Instance.Play_Effect_Sound("01_Crowd_ready_loop");
            
            //Ac.ReadUserInfo();
            if(Ag.mgIsKick)
            StartCoroutine(GetEventBall(2.3f)); //eventItem
            //------------------------------------
            //mStatusSillBar = mskillflag = true;
            SkillSoundAfter();
            AnimaPlay();  });
        mStateArr.AddDuringAction( () => { 
            //mKeeperPosi = mPlayerKeeper.transform.position;
            mKeeperPosi.x = mBippos.transform.position.x;
            mKeeperPosi.z = mBippos2.transform.position.z;
        } );
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("Ceremony", 2.4f, "Packet");
        mStateArr.AddEntryAction( () => {
            x = y = z = 1;
            mStatusSillBar = mskillflag = false;
            mEffballflag = false;
            mgoldenBalleff();
            //mGameObj2.SetActive(false);
            GameObjectRndBox(false);
            Debug.Log ("Ceremony Start");
            //Ag.mBallEventAlready = mEventBallAlready;
            
            
            if (Ag.mgIsKick &&  mGoldenBallEff /* &&  (mGoldenBall || mBronzeBall || mSilverBall) */) { if (Ag.mgDidWin){ GoldenBallEvent(); SoundManager.Instance.Play_Effect_Sound("fixgoldenball"); } else { mGoldenAfter = mSilverAfter = mBronzeAfter = mGoldenBallEff = false;}}
            /*
                if (Ag.mgIsKick && !Ag.mBallEventAlready){
                Debug.Log ("Ceremony Start");
                    Ag.mBallEventAlready = true;
                }
                if (Ag.mgIsKick && !mEventBallAlready) {
                    Ag.mBallEventAlready = mEventBallAlready;
                    mEventBallAlready = true;
                }
             */
            //AppointItemBall ();
            //GetItem ();
            
         for (int i = 0 ; i< 4 ; i++ ) {
             //arrKickerDirBar[i].active = false;
             arrKickerDirBar[i].active = false;
         }
         Ac.ReadUserInfo();
         mKpTrailL.GetComponent<TrailRenderer>().enabled = false;    
         mKpTrailR.GetComponent<TrailRenderer>().enabled = false;    
         mKickBall.GetComponent<TrailRenderer>().enabled = false;    
   
            
            
            // Red & Blue  Signal Display... Setting...
            mPreMyWin = (int)Ag.mgSelfWinNo; mPreEnWin = (int)Ag.mgEnemWinNo;
            if (Ag.mgDirection == 0) mMissNum --;
            if (Ag.mgSkill == 2) mPerfectNum++;
            if (Ag.mgSkill == 0) mMissNum--;
            if (Ag.mgIsKick) {
                if (Ag.mgDidWin) arrMyScore.Add(true);
                else arrMyScore.Add(false);
            } else {
                if (Ag.mgDidWin) arrEnScore.Add(false);
                else arrEnScore.Add(true);
            }
            if (arrEnScore.Count > 5 || arrMyScore.Count > 5) {  // Above 5 case... Remove all...
                for ( int jk=0; jk<5; jk++) { arrMyScore.RemoveAt(0); arrEnScore.RemoveAt(0); }
            }
            if ( Ag.mgDidGameFinish ) {
                mStateArr.SetStateWithNameOf("EndingCeremony");
                return;
            }
            
            SoundManager.Instance.Play_Effect_Sound("03_Crowd_goal");
            mPlayerKeeper.transform.position = new Vector3(mKeeperPosi.x,0,mKeeperPosi.z);
            CerAni();   
        });
        mStateArr.AddExitAction ( () => { 
            Ag.SwitchStep();
            mStateArr.SetStateWithNameOf("CountDn");
        }  );
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("EndingCeremony", 7f);
        mStateArr.AddEntryAction( () => { 
            mMiniItem.active = false;
            CharacterInforAni(false);
         mPlayerKeeper.transform.position = new Vector3(mKeeperPosi.x,0,mKeeperPosi.z);
         Ac.ReadUserInfo();  // For the result....
            EndingCer();
            SoundManager.Instance.Play_Effect_Sound("04_Crowd_Game finish");
            //mSound.audio.volume = 1;
            
        } );
        //mStateArr.AddExitCondition( ()=> { return true; } );
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("ShowEndingResult", 0);
        mStateArr.AddEntryAction( () => {
            mMiniItem.SetActiveRecursively(false);
            
            if (Ag.mgDidWin) {
                //GameObject.Find("SoundWin").gameObject.audio.Play();
                SoundManager.Instance.Play_Effect_Sound("Short metal clip - Win");
                //mBonusCoin = 10;
                mWinBonus = 7;
                //mAllPoint += 10;
                //mWinpoint = 10;
                if(Ag.mSingleMode) {
                    mWinpoint = 0;
                    //mAllPoint -= 0;
                } else {
                    mWinpoint = 10;
                    mAllPoint += 10;
                }
                
                
            } else {
                //AudioSource mLose;
                //GameObject.Find("SoundWin").gameObject.audio.Play();
                SoundManager.Instance.Play_Effect_Sound("Short metal clip - Lose");
                if(Ag.mSingleMode) {
                    mWinpoint = 0;
                    //mAllPoint -= 0;
                } else {
                    mWinpoint = -10;
                    mAllPoint -= 10;
                }
                
                
                mWinBonus = 2;
                //mBonusCoin = 5;
            }
            
            if (!Ag.mSingleMode) mAllPoint += mMissNum;
            else mMissNum = 0;
            //mAllPoint += mPerfectNum;
            mBonusCoin += mWinBonus;
            mBonusCoin += mItemBonus;
            
            Ag.mIapPrice +=  mBonusCoin;
            //Ag.mIapPrice += mWinBonus;
            Ac.IAPinit(); //Get Money;
            StartCoroutine(CResultShow(1f));
            //mResultShow = true;
            
            mCharacterinfor.SetActiveRecursively(false);
         mKResult.SetActiveRecursively(true);
            mKResult.transform.FindChild("Flag").gameObject.transform.renderer.material.mainTexture = (Texture2D)Resources.Load("Kukki/"+Ag.mySelf.mRankObj.mCountry);
            mKResult.transform.FindChild("MYnick").GetComponent<TextMesh>().text = Ag.mySelf.mNick.ToString().ToUpper();
         mCameraDefn.enabled = false;
         mCameraKick.enabled = false;
         mCerCamAxis.SetActiveRecursively(false);
         CerCam.enabled = false;
         mKResult.transform.Rotate(0,-0.1f,0);
         LastResult();
            DestroyObject(mPlayerKicker);
            DestroyObject(mPlayerKeeper);
         mTimerFlag = false;
         mTimerbar.active = false;
         DragPositionF(false);
         DragPosition(false);
         
            GameObject.Find ("UI Root/Camera/Anchor").SetActiveRecursively(false);
            
            
            if (Ag.mSingleMode) {
                mRetryBtn.active = mQuitBtn.active = true;
            } else {
                mRetryBtn.active = mQuitBtn.active = false;
            }
            
         //GameObject.Find ("UI Root/Timer").SetActiveRecursively(false);
        
        } );
        mStateArr.AddExitCondition( ()=> { return false; } );
        //  ________________________________________________ Add A Member.. Add A Member..
        mStateArr.AddAMember("GameFinish", 0);
        mStateArr.AddEntryAction( () => { 
            Ac.ReadUserInfo();
            if(!Ag.mSingleMode)
                Application.LoadLevel("300PrepareGame"); 
            
        } );
        
        //  ________________________________________________ SetSerialExitMember
        mStateArr.SetSerialExitMember();
        mStateArr.SetStateWithNameOf("Begin");
        
        
        mStateArr.AddAMember("ReadUserInfo", 0f);
        mStateArr.AddEntryAction( ()=> { Ac.ReadUserInfo(); });
        
        
        //  ////////////////////////////////////////////////     //[2012:11:12:MOON] Heart Beat
        mStateArr.AddAMember("HeartBeat", 4f);
        mStateArr.AddEntryAction( ()=> {
            Ag.net.HeartBeatCheck(); // check initiated...
        } );
        
        mStateArr.AddAMember("CheckHeartBeat", 0);
        mStateArr.AddEntryAction( ()=> {
            if (Ag.net.mHeartBeat) Ag.mgEnemGiveup = true;
            else {
                Ag.SetWorldState("NetOff"); 
                mAwayMyself = true;
                Ag.mFBOrder = "ThreadReboot";
            }
        });
        mStateArr.AddExitCondition( ()=> { return false; });
        
        mStateArr.SetNextStateOf("HeartBeat", "CheckHeartBeat");
        
        //  ////////////////////////////////////////////////     //[2012:11:12:MOON] Heart Beat
    
    }
    
}
