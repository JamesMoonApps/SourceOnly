using UnityEngine;
using System.Collections;

public partial class MainRpsMatch : MonoBehaviour {

	void GameInit() {
        for (int i = 1 ; i < 5 ; i++ ) {
            arrAimObj.Add(GameObject.Find("RandomBox3/Aim"+i).gameObject);
            arrAimObj[i-1].transform.renderer.enabled = false;
        }
        arrTexBar.Add((Texture2D)Resources.Load("UIsource/DirectBarLU_C"));
        arrTexBar.Add((Texture2D)Resources.Load("UIsource/DirectBarRU_C"));
        arrTexBar.Add((Texture2D)Resources.Load("UIsource/DirectBarLD_C"));
        arrTexBar.Add((Texture2D)Resources.Load("UIsource/DirectBarRD_C"));
        arrTexBar.Add((Texture2D)Resources.Load("UIsource/DirectBarLU"));
        arrTexBar.Add((Texture2D)Resources.Load("UIsource/DirectBarRU"));
        arrTexBar.Add((Texture2D)Resources.Load("UIsource/DirectBarLD"));
        arrTexBar.Add((Texture2D)Resources.Load("UIsource/DirectBarRD"));
        
        mCamera = GameObject.Find("UI Root/Camera").camera;
        mRoundAni = (Texture2D)Resources.Load("Effect/CFXM_T_Anim4_Bubble");
        mRevRoundAni = (Texture2D)Resources.Load("Effect/CFXM_T_Anim4_ReverseBubble");
        mCharacterinfor = GameObject.Find("UI Root/CharacterSkillBar").gameObject;
        mPlayerPicinfo = mCharacterinfor.transform.FindChild("PlayerPic").gameObject;
        mPlayerBioinfo = mCharacterinfor.transform.FindChild("PlayerBio").gameObject;
        mCharacterinfor.SetActiveRecursively(false);
        //Debug.Log (mcurplayer);
       // mText = transform.FindChild("DebugText").gameObject.guiText;
        mIntroCam = GameObject.Find("CamKickIntro").gameObject.camera;
        mCameraDefn = GameObject.Find("MainControl/CameraDefn").gameObject.camera;
        mCameraKick = GameObject.Find("MainControl/CameraMain").gameObject.camera;
     
        mMyCountry = GameObject.Find ("UI Root/MyFlag").gameObject.gameObject;
        mEnemyCountry = GameObject.Find ("UI Root/EneMyFlag").gameObject.gameObject;
        mCrowd = GameObject.Find ("Stadium2/crowdf03").gameObject.gameObject;
        mField1 = GameObject.Find ("Stadium2/sfield").gameObject.gameObject;
        mField2 = GameObject.Find ("Stadium2/Sfield2").gameObject.gameObject;
        mKickerDirbar1 = (Texture2D) Resources.Load ("UIsource/direction copy1");
        mKickerDirbar2 = (Texture2D) Resources.Load ("UIsource/direction copy2");
        mGameBareffect = GameObject.Find("BarEffect").gameObject.gameObject;
        mDirBareff = mGameBareffect.transform.FindChild("skill02").gameObject;
        mskillBareff = mGameBareffect.transform.FindChild("skill01").gameObject;
        
        mKeeperLabel = GameObject.Find("labelAni/fonttex").gameObject;
        mKeeperLabel.renderer.enabled = false;
        if (Ag.mgIsKick) {
                mPlayerKicker = (GameObject)Instantiate (((AmPlayer)Ag.mySelf.arrKicker[0]).mPoly);
                Debug.Log ("  MyPlayer    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+((AmPlayer)Ag.mySelf.arrKicker[0]).mPoly);
                //mCurEnem = Ag.myEnem.GetPlayerUNOof( mCurEnem.mPlayerUNO );
                Debug.Log ("  mCurEnem    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mCurEnem.mPlayerUNO);
                //mPlayerKeeper = (GameObject)Instantiate (mCurEnem.mPoly);
                mBall =  mPlayerKicker.transform.FindChild("deleveryBall").gameObject.gameObject;
                int mMyitem = Ag.mySelf.arrKicker[0].GetSkillItem();
                if (Ag.mySelf.arrKicker[0].mItemCount > 0) {
                    ItemEquitSlot(mMyitem);
                    mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = mItemTex;
                }else{ 
                    mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = (Texture2D)Resources.Load("UIsource/ClothTexture/Shoes/Shoes_Nolmal");
                }
            
           } else {
            //mCurEnem.SetNameAndPolygon(mCurEnem.mPlayerUNO);
                mCurEnem = Ag.myEnem.GetPlayerUNOof( mCurEnem.mPlayerUNO );
                mPlayerKicker = (GameObject)Instantiate (mCurEnem.mPoly);
                 
                Debug.Log ("  mCURENEM    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mCurEnem.mPlayerUNO);
                mBall =     mPlayerKicker.transform.FindChild("deleveryBall").gameObject.gameObject;
                int mMyitem = mCurEnem.GetSkillItem();
                Debug.Log ("  EnemyItem    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mMyitem);
                if (mCurEnem.mItemCount > 0) {
                    ItemEquitSlot(mMyitem);
                    mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = mItemTex;
                }else{ 
                    mPlayerKicker.transform.FindChild("shirt005").renderer.materials[3].mainTexture = (Texture2D)Resources.Load("UIsource/ClothTexture/Shoes/Shoes_Nolmal");
                }
        }
        
        mPlayerKeeper = (GameObject)Instantiate (mKplayer.mPoly);
                
        //mPlayerKicker = GameObject.Find ("kicker").gameObject.gameObject;
        
        
        arrKeeperBarF.Add(GameObject.Find ("DirectionBar_KeeperFront/RightUP").gameObject.gameObject);
        arrKeeperBarF.Add(GameObject.Find ("DirectionBar_KeeperFront/LeftUP").gameObject.gameObject);
        arrKeeperBarF.Add(GameObject.Find ("DirectionBar_KeeperFront/RightDown").gameObject.gameObject);
        arrKeeperBarF.Add(GameObject.Find ("DirectionBar_KeeperFront/LeftDown").gameObject.gameObject);
        arrKeeperBarB.Add(GameObject.Find ("DirectionBar_KeeperBack/RightUP").gameObject.gameObject);
        arrKeeperBarB.Add(GameObject.Find ("DirectionBar_KeeperBack/LeftUP").gameObject.gameObject);
        arrKeeperBarB.Add(GameObject.Find ("DirectionBar_KeeperBack/RightDown").gameObject.gameObject);
        arrKeeperBarB.Add(GameObject.Find ("DirectionBar_KeeperBack/LeftDown").gameObject.gameObject);
        
        //mPlayerKeeper = GameObject.Find ("keeper").gameObject.gameObject;
     
        
        //mKickBall = GameObject.Find("KickBall").gameObject.gameObject;
        mKickBall = (GameObject)Instantiate(Resources.Load("prefeb_Polygon/Ball"));
        mKickBall.renderer.enabled = false;
        
        CerCam =     GameObject.Find("CeremonyCamera").gameObject.camera;
        kickerDirLU = GameObject.Find("DirectionBar/LeftUp").gameObject.gameObject;
        kickerDirUP = GameObject.Find("DirectionBar/RightUp").gameObject.gameObject;
        kickerDirLD = GameObject.Find("DirectionBar/LeftDown").gameObject.gameObject;
        kickerDirRD = GameObject.Find("DirectionBar/RightDown").gameObject.gameObject;
        
        arrKickerDirBar.Add(kickerDirLU);
        arrKickerDirBar.Add(kickerDirUP);
        arrKickerDirBar.Add(kickerDirLD);
        arrKickerDirBar.Add(kickerDirRD);
        
        SetKickerDir (false);
        mbtnRedbull = GameObject.Find ("UI Root/Camera/Anchor/Panel").gameObject.gameObject;
        arrStatusBar.Add (GameObject.Find ("UI Root/Camera/Anchor/StatusBar/Redbull/Background"));
        arrStatusBar.Add (GameObject.Find ("UI Root/Camera/Anchor/StatusBar/Redbull"));
        mbtnRedbull.SetActiveRecursively (false);
        arrStatusBar[0].active = false;
        mCerCamAxis = GameObject.Find("CerAxis").gameObject.gameObject;
        DefnCam = GameObject.Find ("CerAxis/DefCamera").gameObject.gameObject;
        mTimerbar = GameObject.Find ("UI Root/Timer/Background").gameObject.gameObject;
        mGrnTxt = (Texture2D)Resources.Load("UIsource/PointGreen");
        mRedTxt = (Texture2D)Resources.Load("UIsource/PointRed");
        mvsBar = (Texture2D)Resources.Load("UIsource/vs_Bar");
        mVsPlayerBar = (Texture2D)Resources.Load("UIsource/GamePlayUI/vs_bar_Player3");
        mVsEnemyBar  = (Texture2D)Resources.Load("UIsource/GamePlayUI/vs_bar_Enemy3");
     //-------------------------------------------------------------------
        mAdv3 = GameObject.Find ("Stadium2/PreFAds").gameObject.gameObject;
        mGoalFence1 = GameObject.Find ("Stadium2/goal_data/GoalFence").gameObject.gameObject;
        mGoalFence2 = GameObject.Find ("Stadium2/goal_data/GoalFence2").gameObject.gameObject;
       
        //---------------------------------------------------------------------network
     
        mKResult = GameObject.Find ("ResultCamera").gameObject.gameObject;
        mAllpointObj = GameObject.Find("ResultCamera/MyAllpoint").gameObject;
        mWinPointObj = GameObject.Find("ResultCamera/WinPoint").gameObject;
        mBonusCoinObj = GameObject.Find("ResultCamera/PerfectPoint").gameObject;
        mItemBonusObj = GameObject.Find("ResultCamera/MissPenalty").gameObject;
        mWinBonusObj = GameObject.Find("ResultCamera/BonusCoin").gameObject;
        mMissPenaltyObj = GameObject.Find("ResultCamera/MissPenalty2").gameObject;
        //mPerfecNumObj = GameObject.Find("ResultCamera/PerFectPoint2").gameObject;
        mKResult.SetActiveRecursively(false);
        mMyCountry.renderer.material.mainTexture = (Texture2D)Resources.Load("Kukki/"+Ag.mySelf.mRankObj.mCountry);
        mEnemyCountry.renderer.material.mainTexture = (Texture2D)Resources.Load("Kukki/"+Ag.myEnem.mRankObj.mCountry);
        
        for (int i = 0;  i<4 ; i++) { 
            arrKeeperBarF[i].renderer.enabled = false;
            arrKeeperBarB[i].renderer.enabled = false;
        }
        m_KpLodingbar = GameObject.Find("labelAni").gameObject;
        m__KpLodingbarLabel = GameObject.Find("labelAni/Label").gameObject;
        
        LodingBarOff(false);
    }
    
    
    void SetArrTexture() {
        arrListTxt = new ArrayList();
        arrListTxt.Add(Resources.Load("UIsource/Accurucy_Bar_KEEPER_ballPoint") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/DirectBarLU") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/DirectBarRU") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/DirectBarLD") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/DirectBarRD") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/GamePlayUI/Accurucy_Bar_Back") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/GamePlayUI/Accurucy_Bar_Keeper2") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Keeper_GDBAR") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Super_MiracleBar") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/GamePlayUI/Accurucy_Bar_KICKER2") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Kicker_GKBAR") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Super_MiracleBar") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Accurucy_Bar_KICKER") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/DirectionPoint") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Word_Accuracy") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Word_Direction") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Word_Good") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Word_Miss") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Word_Perfect") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/ArrowBlue") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/ArrowRed") as Texture2D);//20
        arrListTxt.Add(Resources.Load("UIsource/ArrowSky") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/ArrowYellow") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Timer01") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Timer02") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Timer03") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Timer04") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/Timer05") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/JumBlue") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/JumRed") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/JumSky") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/JumYellow") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/GamePlayUI/PlayText_goal2") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/GamePlayUI/PlayText_nogoal2") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/GamePlayUI/PlayText_Saveagoal2") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/GamePlayUI/PlayText_Scoreagoal2") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/GamePlayUI/Pin") as Texture2D);
        arrListTxt.Add(Resources.Load("UIsource/GamePlayUI/Pin2") as Texture2D);
       
    }
    
}
