// [2012:10:29:MOON] IAP .. Reject ..
using UnityEngine;
using System.Collections;

public class IApurchase : MonoBehaviour {
    GameObject mCoin ,mExit;
    bool mBtnFlag = true;
    AmUI myGUI;
    
#if UNITY_IPHONE
    
    StateArray mSttArr;
    int mCount;

	// Use this for initialization
	void Start () {
        Ag.mIAP.ProductRequest();
        mCoin = GameObject.Find("Coin/Text_VALUE_COIN").gameObject.gameObject;
        mExit = GameObject.Find("UI Root/Button").gameObject.gameObject;
    
        myGUI = new AmUI(2, 16);
        mCount = 1;
        
        SetStateArray();  // [2012:10:29:MOON] IAP .. Reject ..
    }
	
	// Update is called once per frame
    void Update () {
        
        mSttArr.DoAction();  // [2012:10:29:MOON] IAP .. Reject ..
        
        mCount++;
        
        mCoin.GetComponent<TextMesh>().text = Ag.mySelf.mGold.ToString();
        
        if (mCount > 900) { // Once in 30 sec...
            if ( mSttArr.GetCurStateName() == "Rest")
                Ag.mIAP.CheckUnsentTransaction();
            mCount = 1;
        }
        
        //Ag.LogString("Is Started .. " + Ag.mIAP.mSendPackBool.mIsStarted );
    }
	
    
    void Purchase1000() {
        if ( IsPurchasePossible() ) {
            Purchase("001000", 1000);
        }
    }
    
    void Purchase2200() {
        if ( IsPurchasePossible() ) {
            Purchase("002000", 2200);
        }
    }
    
    void Purchase3600() {
        if ( IsPurchasePossible() ) {
            Purchase("003600", 3600);
        }
    }
    void Purchase6500() {
        if ( IsPurchasePossible() ) {
            Purchase("006500", 6500);
        }
    }
    void Purchase9800() {
        if ( IsPurchasePossible() ) {
            Purchase("009800", 9800);
        }
    }
    void Purchase15000() {
        if ( IsPurchasePossible() ) {
            Purchase("015000", 15000);
        }
    }
    void Purchase32000() {
        if ( IsPurchasePossible() ) {
            Purchase("032000", 32000);
        }
    }
    void Purchase51000() {
        if ( IsPurchasePossible() ) {
            Purchase("051000", 51000);
        }
    }
    
    void Purchase90000() {
        if ( IsPurchasePossible() ) {
            Purchase("090000", 90000);
        }
    }
    
    void Purchase190000() {
        if ( IsPurchasePossible() ) {
            Purchase("190000", 190000);
        }
    }
     
    void OnGUI()
    {
        int col = 0, row = 13;
        
        /*
        
         //Ag.mIAP.mDidProductReceive && mBtnFlag && !Ag.mIAP.mIsUiLocked;
        
        GUI.Label(  myGUI.GetRect(col, row++), Ag.mIAP.mDidProductReceive + ", " + Ag.mIAP.mIsUiLocked + ", " + mBtnFlag);
        
        */
    }
    
    //  ////////////////////////////////////////////////     Purchase
    bool IsPurchasePossible() {
        return Ag.mIAP.mDidProductReceive && mBtnFlag && !Ag.mIAP.mIsUiLocked;
    }
    
    //  ////////////////////////////////////////////////     Purchase
    void Purchase( string pStr, int pPrice ) {
        
        if (mSttArr.GetCurStateName() != "Rest") return;
        
        mSttArr.SetStateWithNameOf("InitPurchase");
        Ag.mIapPrice = pPrice;
        Ag.mIAP.PurchaseProduct(pStr);
    }
    
    //  ////////////////////////////////////////////////     State Array Setting...
    void SetStateArray() {
        mSttArr = new StateArray();
        
        mSttArr.AddAMember("InitPurchase", 3f);
        mSttArr.AddExitCondition( ()=> {
            return !Ag.mIAP.mIsUiLocked; });
        mSttArr.AddTimeOutProcess(20f, ()=> { // Go to Next Stage..
        });
        
        mSttArr.AddAMember("CheckFile", 5f);
        mSttArr.AddEntryAction( ()=>{
            Ag.mIAP.CheckUnsentTransaction();
        });
        mSttArr.AddExitCondition( ()=>{ 
            if (Ag.mIAP.mIsUiLocked) Application.LoadLevel("menu");
            return true;
        } );
        
        mSttArr.AddAMember("Rest", 0f);
        mSttArr.AddExitCondition( ()=> { return false; } );
        
        mSttArr.SetSerialExitMember( pClose:false );
        mSttArr.SetStateWithNameOf("Rest");
    }
    
    void ExitMenu() {
        mBtnFlag = false;
        Resources.UnloadUnusedAssets();
            
        Ag.mIAP.mSendPackBool.FinishAction();
        //Application.LoadLevel("StartMenu");
        Ag.mIsSuspendOnPurpose = false; // [2012:10:29:MOON] IAP .. Reject ..
        
        StartCoroutine(Start1 ());
    }
    
    IEnumerator Start1() {
        AsyncOperation async;
        async = Application.LoadLevelAsync("StartMenu");
        GameObject.Find("LodingBar2").GetComponent<LodingBar2>().mLodingActive = true;
        yield return async;
   }
    
    
#endif    
    
}
