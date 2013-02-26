// [2012:10:09:MOON]
// [2012:10:15:MOON] Timeout => go to Match Scene
// [2012:11:9:ljk] DirectionArea deleted
// [2012:11:12:MOON] Heart Beat
// [2012:12:6:MOON] Swipe Distance

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class MainRpsMatch : MonoBehaviour {
    
    public Camera mCameraDefn, mCameraKick , mIntroCam, CerCam;
    public GameObject mPlayerKicker, mPlayerKeeper , mBall ,mKickBall ,mBippos ,mBippos2 , kickerDirLD ,kickerDirLU ,kickerDirRD ,kickerDirUP ,mbtnRedbull ,mKpDirbar ,mkeeperPos ,mCerCamAxis ,mKickerPos ,DefnCam ,mTimerbar ,mSound ,mNetWorkError, mDirUpeff, mSklUpeff, mMiniRandomEff;
	//public static GameObject mPlayerKicker;
    public GUISkin GuiSkin;
    public int mAnimaRand = 0 , mCerKickAni = 0 ,mDisKeepAni = 0 , mDisKickAni = 0 , mCerKeepAni=0, mKPlastCer, mEventGoldnum, mEventSilvernum, mEventBronzenum;  
    //  Arrays...
    private Texture2D arrTexture , mKickerInfoBar ,mGrnTxt ,mRedTxt ,mvsBar ,mVsPlayerBar ,mVsEnemyBar;
    public GUIStyle mGuiBig, mGuiSml, mGuiCur;
    public TextMesh mRedbullCount ,mMyNick ,mEnemyNick;
    List<bool> arrMyScore, arrEnScore;
    List<GameObject> arrStatusBar = new List<GameObject>();
    List<GameObject> arrKeeperBarF = new List<GameObject>();
    List<GameObject> arrKeeperBarB = new List<GameObject>();
    bool mTimerFlag = false , mSkillSound = false ,mTimerFlag2 = true, mEventPotion = false ,mEventminusPotion = false, mEventItemShowTime = false, mDidEventPotion = false, mDirMinuspotion = false, mSlowEff = false;
	GameObject mGoalFence1 ,mGoalFence2 ,mAdv1 ,mAdv2 ,mAdv3, mCrowd ,mKpTrailR ,mKpTrailL, mTrailBall ,mKResult ,mMyCountry ,mEnemyCountry,mEventBallEffect, mMiniItem, mCharacterinfor, mPlayerPicinfo, mPlayerBioinfo, mGameBareffect,mSkillUpeff, mMissNum2Obj, mPerfecNumObj, mGoldenballeffUp, mMissPenaltyObj,
    mField1, mField2, mParTicle, mGameObj, mGameObj2, mItem, mItem1, mItem2, mItem3, mItem4, mBallItem, mBallItem1, mBallItem2, mBallItem3, mBallItem4, mParticle, mParticle1, mParticle2, mParticle3, mParticle4, mDirBareff, mskillBareff;
    GameObject mAllpointObj, mWinPointObj, mBonusCoinObj, mItemBonusObj, mWinBonusObj;
    List<GameObject> arrKickerDirBar = new List<GameObject>();
    //GameObject ;
    AgTime mTimerObj;
    ArrayList arrListTxt;
    // State Related..
    public StateArray mStateArr ,mStateCere;
    
    // Character Position
    Vector3  mKeeperPosi, mKeeperPrevPosi;

    // Am Objects
    public AmPlayer mCurPlayer, mCurEnem, mEnemyObject, mplayerObject;
    Vector3 PlayerVector;
    private AmStage mStage;
    Animation mCurAnimation;
    public int mCurPage = 0 , mPotionNum ,mPlayerNum2;
    public AmAnimation AmAni;
    public int mWinpoint, mBonusCoin, mBallPoint2, mBallPoint3, mItemBonus = 0, mWinBonus = 0;
   // Game Result....
    private int mRsltDir, mRsltSkl; //  1: LU, 2: RU, 3: LL, 4:RL
    // Skill :: 0: Miss, 1: Kick, 2: Super, 3: Ultra
    public Camera PlayerCam;
    private GUIStyle mStyle;
    public GUIText mText;
    public TextMesh mRedbull;
    public GUIText[] mDebugNum;
    AmPlayer mKplayer = new AmPlayer();
    AmItem itmObj;
    GameObject mRetryBtn, mQuitBtn, mGodenBallCoin, mEventCoin;
    int mPerfectNum, mMissNum, mPreMyWin, mPreEnWin ,mTimer ,mBallPoint;
    List<GameObject> arrGamedirBar = new List<GameObject>();
    //List<Texture2D> arrBarTex = new List<Texture2D>();
    List<GameObject> arrAimObj = new List<GameObject>();
    AmTexture mShirt, mPants, mSocks ,mGkShirt ,mGkPants ,mGkSocks;
    Texture2D mKickerPants ,mKickerShirts, mKickerSocks, mKeeperPants, mKeeperShirts, mKeeperSocks ,mItemTex, mKickerDirbar1, mKickerDirbar2, mReconnect;
    //public AmIAP mAmI = new AmIAP();
    // Effect Related...
    Texture2D mEffect, mEffect2, mEffectPotion, mPrftTxr, mGoodTxr, mMissTxr, mAwayPop, mOK, mRndBoxpng, mRoundAni, mRevRoundAni;
	Texture2D mTimer00, mTimer01, mTimer02, mTimer03, mTimer04, mTimer05, mCoin100, mCoin50, mCoin20, mTimer06, mTimer07, mTimer08, mTimer09, mTimer10, mTimer11, mTimer12, mTimer13, mTimer14, mTimer15, mTimer16, mTimer17 ,mTimer18;
    float mStartTime, mEventDirspeed, mEventSkillSpeed;    
    Vector2 mEffPosi, mEffPosiGood, mEffSize;
    string mFoldNameL = "Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Spine1/Bip001 Spine2/Bip001 Neck/Bip001 L Clavicle/Bip001 L UpperArm/Bip001 L Forearm/Bip001 L Hand";
	string mFoldNameR = "Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Spine1/Bip001 Spine2/Bip001 Neck/Bip001 R Clavicle/Bip001 R UpperArm/Bip001 R Forearm/Bip001 R Hand001";
    string mkickerRfoot = "Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 R Thigh/Bip001 R Calf/Bip001 R Foot";
    
    float mSX, mSY ,mRotSpeed;
	float sclPotion = 1.0f;
	//float DrawXStart = 0.38f, DrawXWidth = 0.479167f, DrawYStart = 0.867188f, DrawYWidth = 0.09375f;
    //float DrawXStart = 0.383f, DrawXWidth = 0.459167f, DrawYStart = 0.77188f, DrawYWidth = 0.09375f;
    float DrawXStart = 0.384f, DrawXWidth = 0.46167f, DrawYStart = 0.71188f, DrawYWidth = 0.09375f;
    bool mDidDragStarted, mDidBuyPotion = false , mKeeperSetDir = false ,mstatusBar = false , mStatusSillBar = false, mItemflag1 = false, mItemflag2= false, mItemflag3 = false, mStatusSkillSound = false, mAwayMyself = false, mEventBallAlready = true,
        mEventBronze = false, mEventSilver = false, mEventGold = false, mGoldenBall, mSilverBall, mBronzeBall, mGoldenBallEff = false;

    // Score Board...
    float mSignalStep, mMySigX, mEnSigX, mSiz, mItemRandomNum, mItemRandomNum1, mItemRandomNum2, mItemRandomNum3, mItemRandomNum4; 
    Rect mVSrect, mMyScr, mEnScr, mAwayPopRect, mOkRect, mEnemyBioRec;
	
    // Enemy Information Box.. Photo, Direction Bar etc
	Rect mWaguRec, mPicRec, mDirRec, mAwayRect;
    
    // Touch Input Coordinates...
    Vector2 mVecInit, mVecFin; 
	
    
    //  ////////////////////////////////////////////////     Game :: Game Init.....
    void Awake() {
        // Application.targetFrameRate = 60;
        
        Ag.LogNewScene("Game310_2", "Start");
        
        mSX = Ag.mgScrX;         mSY = Ag.mgScrY;
    }
    
    Texture2D mAwayEnem, mAwaySelf;
    GameObject mDragExitBtn, mKickerDirbar, mKeeperLabel;
    public float mPlayerInfoX = 1f;
    //  ////////////////////////////////////////////////     ////////////////////////     >>>>> initialization  Start  <<<<<
    void Start () {
        
        mRetryBtn = GameObject.Find("ResultCamera/Retry").gameObject;
        mQuitBtn = GameObject.Find("ResultCamera/Quit").gameObject;
        mRetryBtn.active = false;
        mQuitBtn.active = false;
        mGoldenballeffUp = (GameObject)Resources.Load("Effect/Mystic");
        Ag.SetWorldState("Game");
        //------------------------------------------- GetCoin
        Ag.mIapPrice = 0;
        Ag.mIAP.mFileIO.mReceipt = "this Receipt";
        mGoldenBall = mSilverBall = mBronzeBall = Ag.mBallEventAlready = false;
        
        //-------------------------------------------
        mTimerObj = new AgTime();
		//mDragExitBtn = GameObject.Find("UI Root/SingleQuitBtn").gameObject;
        //mDragExitBtn.SetActiveRecursively(Ag.mSingleMode);
		Ag.mgEnemGiveup = false;
        mCurPlayer = Ag.mySelf.mCurPlayer;
        mCurEnem = Ag.myEnem.mCurPlayer;
        
        mAwayEnem = AgUtil.GetMessage("500Game", "AwayEnemy");
        mAwaySelf = AgUtil.GetMessage("500Game", "AwayMyself");
        mAwayRect = new Rect( Ag.mgScrX*0.2f, Ag.mgScrY*0.2f, Ag.mgScrX*0.6f, Ag.mgScrY*0.5f  );
        mKplayer = Ag.mySelf.GetGlkper(Ag.mySelf.mGoalUNO);
        
        GameInit();
        mGodenBallCoin = GameObject.Find("UI Root/GetCoin2").gameObject;
        mTimerbar.active = false;
        GameObject.Find("Fadeinout").SendMessage("FadeTest",true,SendMessageOptions.DontRequireReceiver);
		mKickerInfoBar = (Texture2D)Resources.Load ("UIsource/KICKER_INFOBAR 2");
		
        mAwayPop = AgUtil.GetMessage("100Total", "LeftRoom");
        mReconnect = AgUtil.GetMessage("100Total", "Reconnect");
        mOK = (Texture2D)Resources.Load("100Total/OkPopup");
        
        // Score Board...
        float sX = Ag.mgScrX, sY = Ag.mgScrY;
        float  cenX = Ag.mgScrX *0.5f, cenY = Ag.mgScrY*0.03f, vsWid =  Ag.mgScrX * 0.5125f , vsHei = Ag.mgScrY * 0.06f, 
        myScrX = vsWid * 0.46f, enScrX = vsWid * 0.42f, siz =  vsWid *0.05f;
        mVSrect = new Rect ( cenX -  0.5f * vsWid, cenY - 0.5f * vsHei, vsWid, vsHei);  // Score Board
        mMyScr = new Rect ( cenX - myScrX, cenY - vsHei * 0.4f, siz*2f, siz*2f);        // My Score text
        mEnScr = new Rect ( cenX + enScrX, cenY - vsHei * 0.4f, siz*2f, siz*2f);        // En Score text

        mAwayPopRect = new Rect( sX*0.18021f, sY*0.30781f, sX*0.63958f, sY*0.38438f);
        mOkRect = new Rect( sX*0.45547f, sY*0.53f, sX*0.10208f, sY*0.08906f);
        
        mSignalStep = vsWid * 0.055f;        mSiz = vsWid * 0.037f; // Signal Size..
        mMySigX = cenX - vsWid * 0.117f - mSiz*0.5f; // Signal Initial Position  (myside)
        mEnSigX = cenX + vsWid * 0.117f - mSiz*0.5f; // Signal Initial Position  (enemy )
        
        mTimer00 = (Texture2D)Resources.Load("Timer/S2");
		mTimer01 = (Texture2D)Resources.Load("Timer/S1");
		mTimer02 = (Texture2D)Resources.Load ("Timer/S4");
		mTimer03 = (Texture2D)Resources.Load ("Timer/S5");
		mTimer04 = (Texture2D)Resources.Load ("Timer/S6");
		mTimer05 = (Texture2D)Resources.Load ("Timer/S7");
        mTimer06 = (Texture2D)Resources.Load ("Timer/S8");
        mTimer07 = (Texture2D)Resources.Load ("Timer/S9");
        mTimer08 = (Texture2D)Resources.Load ("Timer/10");
        mTimer09 = (Texture2D)Resources.Load ("Timer/11c");
        mTimer10 = (Texture2D)Resources.Load ("Timer/12c");
        mTimer11 = (Texture2D)Resources.Load ("Timer/13c");
        mTimer12 = (Texture2D)Resources.Load ("Timer/14c");
        mTimer13 = (Texture2D)Resources.Load ("Timer/15c");
        mTimer14 = (Texture2D)Resources.Load ("Timer/16c");
        mTimer15 = (Texture2D)Resources.Load ("Timer/17c");
        mTimer16 = (Texture2D)Resources.Load ("Timer/18c");
        mTimer17 = (Texture2D)Resources.Load ("Timer/19c");
        mRndBoxpng = (Texture2D)Resources.Load ("TestItem/randombox12");
        // Effect Related...
        mEffect = (Texture2D)Resources.Load ("UISource/LogIn/EFFECT_perfect");
		mEffect2 = (Texture2D)Resources.Load ("UISource/EFFECT_buildup");
        mEffectPotion = (Texture2D)Resources.Load ("500Game/UI/RedBull_Effect");
        mStartTime = Time.timeSinceLevelLoad ;
        mMissTxr = (Texture2D)Resources.Load ("Effect/Text_Miss");
        mGoodTxr = (Texture2D)Resources.Load ("Effect/Text_Good");
        mPrftTxr = (Texture2D)Resources.Load ("Effect/Text_Perfect");
		mSound = GameObject.Find ("Sound").gameObject.gameObject;
        mParTicle = GameObject.Find ("Particle System").gameObject.gameObject;
        mEffPosi = new Vector2(0, 0); mEffSize = new Vector2(0, 0); mEffPosiGood = new Vector2(0, 0);
        mSound.audio.Pause();
        GameObject.Find ("UI Root/MyNick").GetComponent<TextMesh>().text = Ag.mySelf.mNick.ToUpper();
		GameObject.Find ("UI Root/EnemyNIck").GetComponent<TextMesh>().text = Ag.myEnem.mNick.ToUpper();
        mEventCoin = GameObject.Find("UI Root/GetCoin").gameObject;
        mMiniItem = GameObject.Find("UI Root/RandomBoxItem").gameObject;
        mMiniRandomEff = mMiniItem.transform.FindChild("skill01").gameObject;
        mMiniItem.SetActiveRecursively(false);
        mCoin100 = (Texture2D)Resources.Load ("TestItem/200coin");
        mCoin50 = (Texture2D)Resources.Load ("TestItem/50coin");
        mCoin20 = (Texture2D)Resources.Load ("TestItem/20coin");
        
        mGameObj = GameObject.Find("RandomBox").gameObject;
        mGameObj2 = GameObject.Find("RandomBox2").gameObject;
        mItem = mGameObj.transform.FindChild("ItemBox1").gameObject;
        mBallItem = mGameObj.transform.FindChild("mkball1").gameObject;
        mParticle = mGameObj.transform.FindChild("mkball1/Particle1").gameObject;
        mDirUpeff = (GameObject)Resources.Load("Effect/DirUp");
        mSkillUpeff = (GameObject)Resources.Load("Effect/SuperB");
        //mMiniItem.SetActiveRecursively(false);
        mGameObj.SetActive(false);
        //mGameObj2.SetActive(false);
        GameObjectRndBox(false);
        //mEventBallEffect = GameObject.Find("UI Root/accfast").gameObject;
		
#if UNITY_IPHONE		
        mGuiCur = Ag.mgIsRetina? mGuiBig: mGuiSml; 
#endif		
        
#if UNITY_ANDROID
        mGuiCur = mGuiBig;
#endif
        
        /*
		// Wagu.... 
		float waguX = mSX * mPlayerInfoX, waguY = mSY * 0.1f, waguWid = mSX * 0.28f, waguHei = mSY * 0.15f; 
		mWaguRec = new Rect( waguX, waguY, waguWid, waguHei );
		// Player Picture..  depend on Wagu Size, and Position...
		float picX = waguWid * 0.05f, picY = waguHei * 0.3f, picWid = waguWid * 0.2f, picHei = waguHei * 0.6f;
		mPicRec = new Rect( waguX+picX, waguY+picY, picWid, picHei );
		// Direction Bar
		float dirX = waguWid * 0.27f, dirY = waguHei * 0.6f, dirWid = waguWid * 0.7f, dirHei = waguHei * 0.3f;
		mDirRec = new Rect( waguX+dirX, waguY+dirY, dirWid, dirHei );
		
        mEnemyBioRec = new Rect (waguX+dirX, waguY+picY, picWid, picHei * 0.45f );
        
        */
        
        
        /*
        mPlayerKicker.animation.Play ("cerlose01");
        mPlayerKeeper.animation.Play ("CerKeeperA_L");
        CerCam.animation.Play ("C_Keeper_Cer1_L");
        //CerCam.animation.Play ("C_Kicker_DisC_R");
        return; */
        
        mPerfectNum = mMissNum = mPreMyWin = mPreEnWin = 0;
        
        Ag.mgStepSend = 1;
        
        Ag.LogNewScene("Game310_2", "Start");
        
        
        //mStateCere = new StateArray();
        mStateArr = new StateArray();
        mStage = new AmStage();
        mStage.arrTheState = mStateArr;
       
        
        SetStateArray();  // Set State Machine ......
        
        SetArrTexture();  // Set Texture Array...
        
        mCerCamAxis.SetActiveRecursively(false);
        
        
        FieldChanged (false);
        
        
    }
    void FieldChanged (bool flag) {
        mField1.transform.renderer.enabled = flag;
        mField2.transform.renderer.enabled = !flag;
    }
    bool mDragBtn = true;
    
    void DragDown () {
        
        mDragExitBtn.animation["DragBtn"].speed = 1;
        mDragExitBtn.animation.Play();
        //mDragBtn = !mDragBtn;
        StartCoroutine(StartdrgQuitBtn(2f)); 
    }
    
    
    
    
    
   
    
    //--------------------------------------------------------------------------------------ItemBox
    void MkballActive (bool pActive){
        mBallItem.active = pActive;
        mItem.active = pActive;
        //mBallItem1.active = pActive;
        //mBallItem2.active = pActive;
        //mBallItem3.active = pActive;
        //mBallItem4.active = pActive;
    }
    
    void SingleQuitMenu() {
        Ag.mSingleMode = false;
        Application.LoadLevel("StartMenu");
    }
    void SingleModeQuit() {
        Ag.mSingleMode = false;
        Application.LoadLevel("StartMenu");
        
    }
    
    void SinggleModeRetry() {
        Ag.mgIsKick = Random.Range(0,2) == 1 ? true : false ;
        Ag.mSingleMode = true;
        Ag.mVirServer.Initialize();
        Application.LoadLevel("310Game_2");
        
    }
    
    
    
    
    
    
    
    
    
    
    
    
    Texture2D ItemMainTexturechange (string Pstring) {
         mRndBoxpng = (Texture2D)Resources.Load("TestItem/"+Pstring);
        return mRndBoxpng;
    }
    
    void BallChangeTexture (string Pstring) {
         mKickBall.transform.renderer.material.mainTexture = (Texture2D)Resources.Load("TestItem/"+Pstring);
    }
    List<Texture2D> arrTexBar = new List<Texture2D>();    
    //-------------------------------------------------------------------------------ItemBox
    private Camera mCamera;
    
    

   
    
    int mCounter;
    bool mEffballflag = true;
    //  ////////////////////////////////////////////////     ////////////////////////     >>>>>  Update / OnGUI  <<<<<
    public Transform target;
  
    void Update () {
       //OnDrawGizmosSelected();
        if (mStateArr.GetCurStateName() == "ShowEndingResult" && mResultShow){
            ResultShow();
        }
        
        
        mCounter++;
		string curStt = mStateArr.GetCurStateName();
		
        if (mStateArr.GetCurStateName() == "EndingCeremony") {
            if (mKPlastCer == 1) KeeperWinAni1 ();
            if (mKPlastCer == 2) KeeperWinAni2 ();
            if (mKPlastCer == 3) KeeperWinAni3 ();
            if (mKPlastCer == 4) KeeperWinAni4 ();
            if (mKPlastCer == 5) KeeperLoseAni1 ();
            if (mKPlastCer == 6) KeeperLoseAni2 ();
            if (mKPlastCer == 7) KeeperLoseAni3 ();
            if (mKPlastCer == 8) KeeperLoseAni4 ();
        }
        KickerTimer();
        RedbullNum();
		if( curStt == "ShowEndingResult" && Input.GetMouseButtonDown(0))  {
          	mStateArr.SetStateWithNameOf("GameFinish");
        }
        
        if (mStateCere != null)   mStateCere.DoAction();
        if ( Ag.IsSmartDevice() ) {
            if ( !Ag.mgIsKick && mStage.WillInputDrag() ) {
             foreach (Touch touch in Input.touches) {
                    if (!mDidDragStarted) {
                        mVecInit = touch.position;
                        mDidDragStarted = true;
                 } else { mVecFin = touch.position; }
                 if (touch.phase == TouchPhase.Ended) DirectionDrag();
                }
            }
            //------------------------------------------
            if ( mStage.WillInputDrag() ) {       // Goul keeper Direction...
                if ( Input.GetKeyDown(KeyCode.Q) ) { Ag.mgDirection = 1; mStage.TouchProcess(); SetPlayerDir2();  KeeperDirectionDrag(Ag.mgDirection);}
                if ( Input.GetKeyDown(KeyCode.W) ) { Ag.mgDirection = 2; mStage.TouchProcess(); SetPlayerDir2();  KeeperDirectionDrag(Ag.mgDirection);}
                if ( Input.GetKeyDown(KeyCode.E) ) { Ag.mgDirection = 3; mStage.TouchProcess(); SetPlayerDir2();  KeeperDirectionDrag(Ag.mgDirection);}
                if ( Input.GetKeyDown(KeyCode.R) ) { Ag.mgDirection = 4; mStage.TouchProcess(); SetPlayerDir2();  KeeperDirectionDrag(Ag.mgDirection);}
            }
            if(Input.GetMouseButtonDown(0))  {   // Skill Input
                if (mStage.TouchProcess()) {
                    if ( curStt == "GameDir" )
                        Ag.mgDirection = mCurPlayer.GetPosition( mStage.mCursorPosition );
                    if ( curStt == "GameSkl" )
                        Ag.mgSkill = mCurPlayer.GetPosition( mStage.mCursorPosition );
                }
            }
            //------------------------------------------
        }
        

        // PC Input......//
        if ( Ag.mPlatform == Ag.Platform.OSX || !Ag.IsSmartDevice())  {//[2012:11:9:ljk]
            if ( mStage.WillInputDrag() ) {       // Goul keeper Direction...
                if ( Input.GetKeyDown(KeyCode.Q) ) { Ag.mgDirection = 1; mStage.TouchProcess(); SetPlayerDir2(); }
                if ( Input.GetKeyDown(KeyCode.W) ) { Ag.mgDirection = 2; mStage.TouchProcess(); SetPlayerDir2(); }
                if ( Input.GetKeyDown(KeyCode.E) ) { Ag.mgDirection = 3; mStage.TouchProcess(); SetPlayerDir2(); }
                if ( Input.GetKeyDown(KeyCode.R) ) { Ag.mgDirection = 4; mStage.TouchProcess(); SetPlayerDir2(); }
            }
            if(Input.GetMouseButtonDown(0))  {   // Skill Input
                if (mStage.TouchProcess()) {
                    if ( curStt == "GameDir" )
                        Ag.mgDirection = mCurPlayer.GetPosition( mStage.mCursorPosition );
                    if ( curStt == "GameSkl" )
                        Ag.mgSkill = mCurPlayer.GetPosition( mStage.mCursorPosition );
                }
            }
        }
    }
    
    
	//  ////////////////////////////////////////////////     Drag Input
    
    int DragNum = 0;
    
    
    
    
    
    //  ////////////////////////////////////////////////     On GUI
    void OnGUI () {
        
        GUI.color = new Color(1f,1f,1f,1f);
        mStateArr.DoAction();
        string stt = mStateArr.GetCurStateName();
		//if (stt == "XXX") mStateArr.DoAction();
       
        // Show Red & Blue  Signal ... 
        float scrX = Ag.mgScrX, scrY = Ag.mgScrY;
        Texture2D curTxt;
        
        // Signal Board...
        if (Ag.mgIsKick)    GUI.DrawTexture( mVSrect, mVsPlayerBar, ScaleMode.StretchToFill, true);
        else                GUI.DrawTexture( mVSrect, mVsEnemyBar,  ScaleMode.StretchToFill, true);
        // Score Number Text ...
        GUI.Label ( mMyScr, mPreMyWin.ToString(), mGuiCur); 
        GUI.Label ( mEnScr, mPreEnWin.ToString(), mGuiCur);
        
        
        
        
        
        //-----------------------------------------------------------------------------------------------------Debug
        //GUI.Label ( new Rect(100,100,800,100),"    good    "+mKplayer.mGood +"   Perfect  "+     mKplayer.mPerfect      + "  Coin  "  + Ag.mIapPrice  +"   sklSpeed    " + mEventSkillSpeed + "  Dirspeed  " +mEventDirspeed + "agBallAlready" +Ag.mBallEventAlready + "  mEventBallalready  " + mEventBallAlready + "  agmiskick  " + Ag.mgIsKick);
        
        //-----------------------------------------------------------------------------------------------------
        
        // Away Case
        if ( Ag.mgEnemGiveup && stt != "ShowEndingResult" && stt != "GameFinish"  ) {
            if (stt != "ReadUserInfo") mStateArr.SetStateWithNameOf("ReadUserInfo");
            GUI.DrawTexture( mAwayPopRect, mAwayPop, ScaleMode.StretchToFill, true);
            GUI.DrawTexture( mOkRect, mOK, ScaleMode.StretchToFill, true);
            if( GUI.Button( mAwayPopRect,"","")  ) {
            //if ( GUI.Button( mAwayRect, mAwayEnem ) ) {
                mStateArr.SetStateWithNameOf("ShowEndingResult");
            }
        }
        
        if (mAwayMyself ) { // [2012:10:15:MOON] Timeout => go to Match Scene
            GUI.DrawTexture( mAwayPopRect, mReconnect, ScaleMode.StretchToFill, true);
            GUI.DrawTexture( mOkRect, mOK, ScaleMode.StretchToFill, true);
            //if ( GUI.Button( mAwayRect, mAwaySelf )  ) {
            if( GUI.Button( mAwayPopRect,"","")  ) {
				Ac.ReadUserInfo();
                //Application.LoadLevel("menu");
                
                Application.LoadLevel("300PrepareGame"); // [2012:10:15:MOON] 
            }
        }
        
        // Signal Light... Red & Green
        float yCo = mMyScr.y + mSiz*0.12f;
        int ij, num = arrMyScore.Count;  // My Signal
        for(ij=0; ij<num; ij++) {
            curTxt = arrMyScore[ij]? mGrnTxt: mRedTxt;
            GUI.DrawTexture( new Rect (mMySigX - ij * mSignalStep, yCo, mSiz, mSiz), curTxt, ScaleMode.StretchToFill, true);
        }
        num = arrEnScore.Count;         // Enem Signal
        for (ij=0; ij<num; ij++) {
            curTxt = arrEnScore[ij]? mGrnTxt: mRedTxt;
            GUI.DrawTexture( new Rect (mEnSigX + ij * mSignalStep, yCo, mSiz, mSiz), curTxt, ScaleMode.StretchToFill, true);
        }
        
        if (mstatusBar)  SetPlayerDir2();   //SetStatusBar();    
        if (mStatusSillBar) statusSkill();
        if (mStatusSkillSound) SkillSound();
        
        // Touch Process......
        if ( Ag.IsSmartDevice() && !mStage.mIsTouched && Input.touchCount > 0 ) {
			mStartTime = Time.timeSinceLevelLoad;
            if (mStage.TouchProcess()) {
                if ( stt == "GameSkl") {
                    Ag.mgSkill = mCurPlayer.GetPosition( mStage.mCursorPosition ); // Save Touch Points [GAM_RLT]
                    mStatusSkillSound = true;  
                }
                if ( Ag.mgIsKick && stt == "GameDir") 
                    Ag.mgDirection = mCurPlayer.GetPosition( mStage.mCursorPosition);
                
                Ag.LogIntenseWord("Touched Direction is >> " + Ag.mgDirection);
                return;
            }
        }
        
        // Draw Direction, Skill Bar  &   Cursor....
        if ( mStage.WillDrawDirection() )   DrawGameDirection();
        if ( mStage.WillDrawSkill() )       DrawGameSkill();
		
        //GUI.Label (new Rect (scrX*0.5f, scrY*0.95f, scrX*0.5f, scrY*0.05f), "Init_ " + mVecInit.x + " , " + mVecInit.y + 
          //  "     Fin_  " +  mVecFin.x + " , " + mVecFin.y  , mGuiCur);
    }
	
	
	
	
    void DragPosition (bool flag) {
        for (int i = 0; i< 4 ; i++) {
            arrKeeperBarB[i].transform.renderer.enabled = flag;
        }
    }
    
    void DragPositionF (bool Flag1) {
        for (int i = 0; i< 4 ; i++) {
            arrKeeperBarF[i].transform.renderer.enabled = Flag1;
        }
    }
    bool zoomCameraFlag = false;
    //  ////////////////////////////////////////////////     Game :: Direction Touch.....
    
    public List<GameObject> mGuideBar ;
    float mPos = 1000,mWidth = 0;
    public Dictionary<int,float> dicGuideObjectPos, dicGuideObjectWidth;
    
    
    
    
    //---------------------------------------------------------------------GuideBar;
    List<GameObject> ListGameObject;
    AnimationClip Clip, Clip2;
    
    
    
    
    
    
    void PotionUse() {
        if (Ag.mySelf.mPorsion == 0) return;
        if (mDidBuyPotion) return;
        //Debug.Log ("StatusBar>>>>>>>>>>>>>>>>>>>>>>>>>");
        
        arrStatusBar[0].active = true;
        mDidBuyPotion = true;
        
        Ac.DoPorsionUse();
    }
    
    //  ////////////////////////////////////////////////     Game :: Skill Touch.....
    
    
    
    //  ////////////////////////////////////////////////     RedbullNum.. 
    void RedbullNum(){
        mRedbullCount.text = Ag.mySelf.mPorsion.ToString();
    }
        
    //  ////////////////////////////////////////////////     Draw Unit Bar.. 
    
    
    void KickerScenePlay (bool pflag) {
        if (!pflag) {
            mAdv3.transform.FindChild("ads1").animation.Stop();
            mAdv3.transform.FindChild("ads2").animation.Stop();
            mAdv3.transform.FindChild("ads3").animation.Stop();
            mGoalFence1.transform.renderer.enabled = false;
            mGoalFence2.GetComponent<SkinnedMeshRenderer>().enabled = false;
        } else {
            mAdv3.transform.FindChild("ads1").animation.Play();
            mAdv3.transform.FindChild("ads2").animation.Play();
            mAdv3.transform.FindChild("ads3").animation.Play();
            mGoalFence1.transform.renderer.enabled = true;
            mGoalFence2.GetComponent<SkinnedMeshRenderer>().enabled = true;
        }
    }
 
    float mPresentTime;
    
    
    
    
    //  ////////////////////////////////////////////////     Game :: Game Init.....
    
    
    
    
    
    //GameObject mDirUPclone1, mDirUPclone2;
    bool mskillflag = true;
    float x = 1, y = 1, z = 1;
    
    void SkillSoundAfter () {
        if ( Ag.mgIsKick) {
            if ( Ag.mgSkill == 2){
                SoundManager.Instance.Play_Effect_Sound("Sound effect Kickerfoot");
            }
        } else {
            if(Ag.mgSkill == 2){
                SoundManager.Instance.Play_Effect_Sound("Sound effect GoalkeeperH");
            }
        }
    }
    
    
    //-----------------------------------------------------------------------------------SoundPlay
    void SkillSound() {
		string fileName = "";
		switch (Ag.mgSkill) {
		case 0: fileName = "Bad";  mSkillSound = true; break;
		case 1: fileName = "Good"; break;
        case 2: fileName = "Perfect"; break;    
        }
        SoundManager.Instance.Play_Effect_Sound(fileName);
        
        mStatusSkillSound = false;
    }
    
    
    
    //  ////////////////////////////////////////////////     ////////////////////////     >>>>>  Animation   <<<<<
    void CameraSet () {
        if (Ag.mgIsKick) {
            mCameraKick.enabled = true;
            mCameraDefn.enabled = false;
        } else {
            mCameraKick.enabled = false;
            mCameraDefn.enabled = true;
        }
    }
    
    //  ////////////////////////////////////////////////     Pre Animation Play..
    
    
    //--------------------------------------------------------------------------------------Texture
    void SelectColor () {
        string folder = "UIsource/ClothTexture/Kicker";
        string Kpfolder = "UIsource/ClothTexture/Keeper";
           
            mKickerPants = (Texture2D)Resources.Load ( folder +  "/Pants/Texture_Pants_" + mPants.mR + "_"+ mPants.mG +"_"+ mPants.mB);
            mKickerShirts = (Texture2D)Resources.Load ( folder + "/Shirt/Texture_Shirt "+ mShirt.mR +"_" + mShirt.mG +"_"+ mShirt.mB);
            mKickerSocks = (Texture2D)Resources.Load ( folder + "/Socks/Texture_Socks_"+ mSocks.mR +"_" + mSocks.mG +"_" + mSocks.mB);
            mKeeperPants = (Texture2D)Resources.Load (folder +  "/Pants/Texture_Pants_"+mGkPants.mR+"_"+mGkPants.mG+"_"+mGkPants.mB);
            mKeeperShirts = (Texture2D)Resources.Load (Kpfolder +"/Shirts/Texture_LongShirt "+mGkShirt.mR+"_"+mGkShirt.mG+"_"+mGkShirt.mB);
            mKeeperSocks = (Texture2D)Resources.Load (folder + "/Socks/Texture_Socks_"+mGkSocks.mR+"_"+mGkSocks.mG+"_"+mGkSocks.mB);
    }
    
    
    
    void CharaacterColorChange() {
         
             mPlayerKeeper.transform.FindChild("keeper_pantpart").renderer.material.mainTexture = mKeeperPants ;
             mPlayerKeeper.transform.FindChild("keeper_shirtpart").renderer.material.mainTexture = mKeeperShirts;
             mPlayerKeeper.transform.FindChild("keepersockpart").renderer.material.mainTexture = mKeeperSocks;
             mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[1].mainTexture =mKickerPants ;
             mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[0].mainTexture = mKickerShirts;
             mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[2].mainTexture = mKickerSocks;
            
       
    }
    
    
    
     void TextureReady() {
        if(Ag.mgIsKick) {
             mShirt = Ag.mySelf.mShirt;
             mPants = Ag.mySelf.mPants;
             mSocks = Ag.mySelf.mSocks;
             mGkShirt = Ag.myEnem.mGlShirt;
             mGkPants = Ag.myEnem.mGlPants;
             mGkSocks = Ag.myEnem.mGlSocks;
        } else {
            mShirt = Ag.myEnem.mShirt;
            mPants = Ag.myEnem.mPants;
            mSocks = Ag.myEnem.mSocks;
            mGkShirt = Ag.mySelf.mGlShirt;
            mGkPants = Ag.mySelf.mGlPants;
            mGkSocks = Ag.mySelf.mGlSocks;
        }
    }
    
    
    
    //--------------------------------------------------------------------------------------
    

    
    GameObject mDirUpclone1, mDirUpclone2, mDirUpclone3, mDirUpclone4, mDirUpclone5, mDirUpclone6, mDirUpclone7;
    
    
    
    
    
    
    void PutOnTexture() {
        TextureReady();
        SelectColor ();
        CharaacterColorChange();
    }
    
    void ItemEquitSlot (int pEquipItem) {
        if (pEquipItem == 1) {
            mItemTex = (Texture2D)Resources.Load ("UIsource/ClothTexture/Glove/athena01");
        }
        if (pEquipItem == 2) {
            mItemTex = (Texture2D)Resources.Load ("UIsource/ClothTexture/Glove/ares01");
        }
        if (pEquipItem == 3) {
            mItemTex = (Texture2D)Resources.Load ("UIsource/ClothTexture/Glove/Nike01");
        }
        if (pEquipItem == 4) {
            mItemTex = (Texture2D)Resources.Load ("UIsource/ClothTexture/Shoes/Shoes_Minerva");
       }
        if (pEquipItem == 5) { 
            mItemTex = (Texture2D)Resources.Load ("UIsource/ClothTexture/Shoes/Shoes_Mars");
        }
        if (pEquipItem == 6) {
            mItemTex = (Texture2D)Resources.Load ("UIsource/ClothTexture/Shoes/Shoes_Victoria");
        }
        
    }
    
    
    
    IEnumerator StartdrgQuitBtn(float time) {
        yield return new WaitForSeconds(time);
        mDragExitBtn.animation["DragBtn"].speed = -1;
        mDragExitBtn.animation["DragBtn"].time = mDragExitBtn.animation["DragBtn"].length;
        mDragExitBtn.animation.Play("DragBtn");
        
       
    }
    
    bool mGoldenAfter, mSilverAfter, mBronzeAfter;
    int mSinglePlayerNum = 0;
    int TimeNum1, OddNum2 = 30, ResultNum;
    int mAllUsePoint = 0, mAllPoint, mMisspoint;
    bool AllPoint1 = false, WinPoint = false, BonusCoin = false, ItemBonus = true, WinBonus = false, mResultShow = false, mMissPenalty = false;
    
    
    
   void KeeperAction() {
        mStateCere = new StateArray();
        mRotSpeed = 1.2f;
        
        mStateCere.AddAMember("Init", 4f);
        mStateCere.AddExitCondition( ()=> { return Mathf.Abs (mCerCamAxis.transform.rotation.y) < 0.7f; } );
        
        mStateCere.AddAMember("Clock", 0.5f);
        mStateCere.AddEntryAction( ()=> { mRotSpeed = 1.2f; } );
        mStateCere.AddExitCondition( ()=> { return Mathf.Abs (mCerCamAxis.transform.rotation.y) < 0.7f; } );
       
        mStateCere.AddAMember("Counter", 0.5f);
        mStateCere.AddEntryAction( ()=> { mRotSpeed = -0.85f; } );
        mStateCere.AddExitCondition( ()=> { return Mathf.Abs (mCerCamAxis.transform.rotation.y) < 0.7f; } );;
        
        mStateCere.SetNextStateOf("Init", "Counter");
        mStateCere.SetNextStateOf("Clock", "Counter");
        mStateCere.SetNextStateOf("Counter", "Clock");
        
        mStateCere.SetStateWithNameOf("Init");
    }
    
    
    
    
    
    void StatusBarPic(bool pType) {
        arrStatusBar[0].active = pType;
        //arrStatusBar[1].GetComponent<UISprite>().enabled = pType;
        //arrStatusBar[2].GetComponent<UISprite>().enabled = pType;
    }
} 
     