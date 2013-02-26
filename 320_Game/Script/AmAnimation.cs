using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

public class AmAnimation  {
    public GameObject mBall, mKeeper, mPlayerKicker;
	
    
	
    public void StartAnimation(int myDir, int enDir, int mySkl, int enSkl ){
            
		
        string Aninum = myDir.ToString() + enDir.ToString() + mySkl.ToString() + enSkl.ToString() ;
           
        mPlayerKicker = GameObject.Find ("MainControllView").GetComponent<MainRpsMatch>().mPlayerKicker;
        
       // mPlayerKicker = GameObject.Find ("kicker").gameObject.gameObject;
        mKeeper = GameObject.Find ("MainControllView").GetComponent<MainRpsMatch>().mPlayerKeeper;
        mBall = GameObject.Find ("MainControllView").GetComponent<MainRpsMatch>().mKickBall;
//        Debug.Log (mBall);
        //mBall.animation.Play("B_CEN_DD");
        ///  Debug.Log (Aninum);
        /// 
       //mPlayerKicker
        switch(Aninum){
        case "0000":
            mBall.animation.Play("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0001":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        
        case "0003":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0002":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
            
        case "0004":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
            
        case "0010":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
            
        case "0011":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0013":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0012":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            
            break; 
        case "0014":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0020":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break; 
        case "0021":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            
            break; 
        case "0023":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            
            break; 
        case "0022":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0024":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0100":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0101":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0103":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0102":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0104":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0110":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0111":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("BUTHR");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0113":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("BUOHR");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0112":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0114":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0120":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0121":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("BUTHRM_S_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0123":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("BUOHRM");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0122":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0124":
            mBall.animation.Play ("B_BUR_DD");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0200":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0201":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0203":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0202":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0204":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0210":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKL_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0211":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0213":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0212":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("BUTHL");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0214":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("BUOHL");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0220":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKL_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0221":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0223":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0222":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("BUTHLM_S_K1");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0224":
            mBall.animation.Play ("B_BUL_DD");
            mKeeper.animation.Play ("BUOHLM");
            mPlayerKicker.animation.Play ("Kick01");
            
            break;
        case "0300":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0301":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0303":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0302":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0304":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
        case "0310":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
        case "0311":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("BDOHR");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0313":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("BDTHR");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0312":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0314":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0320":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0321":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("BDOHRM");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0323":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("BDTHRM_S_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0322":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0324":
            mBall.animation.Play ("B_BDR_DD");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0400":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0401":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0403":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0402":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0404":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
        case "0410":
            mBall.animation.Play ("B_BDL_DD" );
            mKeeper.animation.Play ("GKL_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
        case "0411":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0413":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0412":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("BDOHL");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0414":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("BDTHL");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0420":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKL_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0421":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0423":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0422":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("BDOHLM");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "0424":
            mBall.animation.Play ("B_BDL_DD");
            mKeeper.animation.Play ("BDTHLM_S_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1000":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1001":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1003":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1002":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1004":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1010":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1011":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1013":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1012":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1014":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1020":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKR_noActCer_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1021":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1023":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
        case "1022":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1024":
            mBall.animation.Play ("B_CEN_DD");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1100":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
        case "1101":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1103":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1102":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1104":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1110":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1111":
            mBall.animation.Play ("B_BUTHR_S");
            mKeeper.animation.Play ("BUTHR");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1113":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("BUOHR");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1112":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1114":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1120":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1121":
            mBall.animation.Play ("B_BUTHRM_S_K1");
            mKeeper.animation.Play ("BUTHRM_S_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1123":
            mBall.animation.Play ("B_BUOHRM_S");
            mKeeper.animation.Play ("BUOHRM");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1122":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1124":
            mBall.animation.Play ("B_BUOHR_G");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1200":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1201":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1203":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1202":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1204":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1210":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1211":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1213":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1212":
            mBall.animation.Play ("B_BUTHL_S");
            mKeeper.animation.Play ("BUTHL");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1214":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("BUOHL");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1220":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1221":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
           
        case "1223":
            mBall.animation.Play ("B_BUOHL_G");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1222":
            mBall.animation.Play ("B_BUTHLM_S_K1");
            mKeeper.animation.Play ("BUTHLM_S_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1224":
            mBall.animation.Play ("B_BUOHLM_S");
            mKeeper.animation.Play ("BUOHLM");
            mPlayerKicker.animation.Play ("Kick01");
            break;
        
            
        case "1300":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1301":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1303":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1302":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1304":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1310":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1311":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("BDOHR");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1313":
            mBall.animation.Play ("B_BDTHR_S");
            mKeeper.animation.Play ("BDTHR");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1312":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1314":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1320":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKR_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1321":
            mBall.animation.Play ("B_BDOHRM_S");
            mKeeper.animation.Play ("BDOHRM");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1323":
            mBall.animation.Play ("B_BDTHRM_S_K1");
            mKeeper.animation.Play ("BDTHRM_S_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1322":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1324":
            mBall.animation.Play ("B_BDOHR_G");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1400":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1401":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
            
            
        case "1403":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1402":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1404":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
            
        case "1410":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1411":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
            
        case "1413":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1412":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("BDOHL");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1414":
            mBall.animation.Play ("B_BDTHL_S");
            mKeeper.animation.Play ("BDTHL");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1420":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKL_noActDis_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1421":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1423":
            mBall.animation.Play ("B_BDOHL_G");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1422":
            mBall.animation.Play ("B_BDOHLM_S");
            mKeeper.animation.Play ("BDOHLM");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "1424":
            mBall.animation.Play ("B_BDTHLM_S_K1");
            mKeeper.animation.Play ("BDTHLM_S_K1");
            mPlayerKicker.animation.Play ("Kick01");
            break;
            
        case "2000":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKR_noActCer_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2001":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKR_noActCer_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2003":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKR_noActCer_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2002":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKR_noActCer_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2004":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKR_noActCer_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2010":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKR_noActCer_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2011":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2013":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2012":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2014":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2020":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKR_noActCer_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2021":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2023":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2024":
            mBall.animation.Play ("B_CENM_DD_K2");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2100":
            mBall.animation.Play ("B_BUTHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2101":
            mBall.animation.Play ("B_BUTHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2103":
            mBall.animation.Play ("B_BUTHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2102":
            mBall.animation.Play ("B_BUTHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2104":
            mBall.animation.Play ("B_BUTHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2110":
            mBall.animation.Play ("B_BUTHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2111":
            mBall.animation.Play ("B_BUTHR_G_K2");
            mKeeper.animation.Play ("BUTHR");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2113":
            mBall.animation.Play ("B_BUOHR_G_K2");
            mKeeper.animation.Play ("BUOHR");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2112":
            mBall.animation.Play ("B_BUOHR_G_K2");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2114":
            mBall.animation.Play ("B_BUOHR_G_K2");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2120":
            mBall.animation.Play ("B_BUOHRM_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2121":
            mBall.animation.Play ("B_BUTHRM_S_K2");
            mKeeper.animation.Play ("BUTHRM_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
        
        case "2123":
            mBall.animation.Play ("B_BUOHRM_G_K2");
            mKeeper.animation.Play ("BUOHRM");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2122":
            mBall.animation.Play ("B_BUOHRM_G_K2");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2124":
            mBall.animation.Play ("B_BUOHRM_G_K2");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2200":
            mBall.animation.Play ("B_BUTHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2201":
            mBall.animation.Play ("B_BUTHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2203":
            mBall.animation.Play ("B_BUTHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2202":
            mBall.animation.Play ("B_BUTHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2204":
            mBall.animation.Play ("B_BUTHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2210":
            mBall.animation.Play ("B_BUOHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2211":
            mBall.animation.Play ("B_BUOHL_G_K2");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2213":
            mBall.animation.Play ("B_BUOHL_G_K2");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2212":
            mBall.animation.Play ("B_BUTHL_G_K2");
            mKeeper.animation.Play ("BUTHL");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2214":
            mBall.animation.Play ("B_BUOHL_G_K2");
            mKeeper.animation.Play ("BUOHL");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2220":
            mBall.animation.Play ("B_BUOHLM_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2221":
            mBall.animation.Play ("B_BUOHLM_G_K2");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2223":
            mBall.animation.Play ("B_BUOHLM_G_K2");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2222":
            mBall.animation.Play ("B_BUTHLM_S_K2");
            mKeeper.animation.Play ("BUTHLM_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2224":
            mBall.animation.Play ("B_BUOHLM_G_K2");
            mKeeper.animation.Play ("BUOHLM");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2300":
            mBall.animation.Play ("B_BDOHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2301":
            mBall.animation.Play ("B_BDOHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2303":
            mBall.animation.Play ("B_BDOHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2302":
            mBall.animation.Play ("B_BDOHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2304":
            mBall.animation.Play ("B_BDOHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2310":
            mBall.animation.Play ("B_BDOHR_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2311":
            mBall.animation.Play ("B_BDOHR_G_K2");
            mKeeper.animation.Play ("BDOHR");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2313":
            mBall.animation.Play ("B_BDTHR_G_K2");
            mKeeper.animation.Play ("BDTHR");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2312":
            mBall.animation.Play ("B_BDTHR_G_K2");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2314":
            mBall.animation.Play ("B_BDTHR_G_K2");
            mKeeper.animation.Play ("GKLM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2320":
            mBall.animation.Play ("B_BDOHRM_G_K2");
            mKeeper.animation.Play ("GKR_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2321":
            mBall.animation.Play ("B_BDOHRM_G_K2");
            mKeeper.animation.Play ("BDOHRM");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2323":
            mBall.animation.Play ("B_BDTHRM_S_K2");
            mKeeper.animation.Play ("BDTHRM_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2322":
            mBall.animation.Play ("B_BDOHRM_G_K2");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2324":
            mBall.animation.Play ("B_BDOHRM_G_K2");
            mKeeper.animation.Play ("GKLM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;    
        case "2400":
            mBall.animation.Play ("B_BDOHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2401":
            mBall.animation.Play ("B_BDOHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2403":
            mBall.animation.Play ("B_BDOHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2402":
            mBall.animation.Play ("B_BDOHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2404":
            mBall.animation.Play ("B_BDOHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2410":
            mBall.animation.Play ("B_BDTHL_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2411":
            mBall.animation.Play ("B_BDTHL_G_K2");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2413":
            mBall.animation.Play ("B_BDTHL_G_K2");
            mKeeper.animation.Play ("GKRM01");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2412":
            mBall.animation.Play ("B_BDOHL_G_K2");
            mKeeper.animation.Play ("BDOHL");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2414":
            mBall.animation.Play ("B_BDTHL_G_K2");
            mKeeper.animation.Play ("BDTHL");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2420":
            mBall.animation.Play ("B_BDOHLM_G_K2");
            mKeeper.animation.Play ("GKL_noActDis_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2421":
            mBall.animation.Play ("B_BDOHLM_G_K2");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2423":
            mBall.animation.Play ("B_BDOHLM_G_K2");
            mKeeper.animation.Play ("GKRM02");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2422":
            mBall.animation.Play ("B_BDOHLM_G_K2");
            mKeeper.animation.Play ("BDOHLM");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "2424":
            mBall.animation.Play ("B_BDTHLM_S_K2");
            mKeeper.animation.Play ("BDTHLM_K2");
            mPlayerKicker.animation.Play ("Kick02");
            break;
            
        case "3000":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3001":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3003":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3002":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3004":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3010":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3011":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3013":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3012":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3014":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3020":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3021":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3023":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3024":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3100":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3101":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3103":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3102":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3104":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3110":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3111":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3113":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3112":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3114":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3120":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3121":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
        
        case "3123":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3122":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3124":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3200":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3201":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3203":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3202":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3204":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3210":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3211":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3213":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3212":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3214":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3220":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3221":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3223":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3222":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3224":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3300":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3301":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3303":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3302":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3304":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3310":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3311":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3313":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3312":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3314":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3320":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3321":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3323":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3322":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3324":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;    
        case "3400":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3401":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3403":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3402":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3404":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3410":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3411":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3413":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3412":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3414":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3420":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3421":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3423":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3422":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;
            
        case "3424":
            mBall.animation.Play ();
            mKeeper.animation.Play ();
            mPlayerKicker.animation.Play ();
            break;    
        }
        
    }
}
