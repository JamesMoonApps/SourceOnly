using UnityEngine;
using System.Collections;

public partial class MainRpsMatch : MonoBehaviour {
    void IntroAni() {
        if ( Ag.mgIsKick) {
            
            mIntroCam.animation.Play("KickIntro2");
            Debug.Log ("KickerAnimation");
            mPlayerKicker.animation.Play ("ballmove");
            mPlayerKeeper.animation.Play ("goalmove");
        } else {
            mIntroCam.animation.Play("keeperIntro");
            mPlayerKicker.animation.Play ("ballmove");
            mPlayerKeeper.animation.Play ("goalmove");
        }
    }
 
    bool AmIRight() {
        return (Ag.mgDirection % 2) == 0;
    }
 
    bool IsSameDirection() {
     int kickRm = Ag.mgDirection % 2, defnRm = Ag.mgEnemDirec % 2;
        return kickRm == defnRm;
    }
    
    bool IsKickerWin() {
        if (Ag.mgIsKick && Ag.mgDidWin) return true;
        if (!Ag.mgIsKick && !Ag.mgDidWin) return true;
        return false;
    }
    
    bool IsKeeperRight() {
        if (!Ag.mgIsKick &&  (Ag.mgDirection % 2 == 0) ) return true;
        if ( Ag.mgIsKick &&  (Ag.mgEnemDirec % 2 == 0) ) return true;
        return false;
    }

    bool IsKickerRight() {
        if ( Ag.mgIsKick &&  (Ag.mgDirection % 2 == 0) ) return true;
        if (!Ag.mgIsKick &&  (Ag.mgEnemDirec % 2 == 0) ) return true;
        return false;
    }

    
    bool IsGoulerDdong() {
        if (!Ag.mgIsKick &&  (Ag.mgDirection == 0 || Ag.mgSkill == 0) ) return true;
        if (Ag.mgIsKick && (Ag.mgEnemDirec == 0 || Ag.mgEnemSkill == 0) ) return true;
        return false;
    }
    
    bool IsKickerDdong() {
        if (Ag.mgIsKick &&  (Ag.mgDirection == 0 || Ag.mgSkill == 0) ) return true;
        if (!Ag.mgIsKick && (Ag.mgEnemDirec == 0 || Ag.mgEnemSkill == 0) ) return true;
        return false;
    }
    
    
    void CerAni() {
        //byte myDir, enDir, mySkl, enSkl;
        //myDir = Ag.mgDirection; mySkl = Ag.mgSkill; enDir = Ag.mgEnemDirec; enSkl = Ag.mgEnemSkill;
        bool myWin;
        myWin = Ag.mgDidWin;
        
        mPlayerKicker.transform.position = new Vector3(2.59593f, 0.04181996f, -36.41669f);
        mCerKickAni = Random.Range(0,5);
        mDisKickAni = Random.Range(0,4);
        mDisKeepAni = Random.Range(0,4);
        mCerKeepAni = Random.Range(0,3);
        
        
        
        //kicker
        string[] mCerKickStr = {"cere01",   "cere02",   "cere03",   "cere04",   "cere05"};   // 5 ea
        string[] mDisKickStr = {"cerlose01","cerlose02","cerlose03","cerlose04"};  // 4 ea
        
        // Kicker  ... Cam
        string[] mCerCamera = {"C_KickCer1",    "C_KickCer2",   "C_KickCer3",   "C_KickCer4",   "C_KickCer5"}; // 5 ea
        string[] mDisCamera = {"C_Kick_Dis01",  "C_Kick_Dis02", "C_Kick_Dis03", "C_Kick_Dis04"};  // 4£ ea
        // Keeper  ... Cam
        string[] mCerKPCamL = {"C_Keeper_Cer1_L","C_Keeper_Cer2_L","C_Keeper_Cer3_L"};  // 3 ea
        string[] mCerKPCamR = {"C_Keeper_Cer1_R","C_Keeper_Cer2_R","C_Keeper_Cer3_R"};  // 3 ea
        string[] mDisKPCamL = {"C_Keeper_DisA_L","C_Keeper_DisB_L","C_Keeper_DisC_L","C_Keeper_DisD_L"};  // 4 ea
        string[] mDisKPCamR = {"C_Keeper_DisA_R","C_Keeper_DisB_R","C_Keeper_DisC_R","C_Keeper_DisD_R"};  // 4 ea
        string[] mKpMissDissCamL = {"C_Keeper_L_Miss_01","C_Keeper_L_Miss_02"};
        string[] mKpMissDissCamR = {"C_Keeper_R_Miss_01","C_Keeper_R_Miss_02"};
        
  
        // Keeper... 
        string[] mCerKeepStrL = {"CerKeeperA_L","CerKeeperB_L","CerKeeperC_L"};  // 3 ea
        string[] mCerKeepStrR = {"CerKeeperA_R","CerKeeperB_R","CerKeeperC_R"};  // 3 ea
        string[] mDisKeePStrL = {"DisKeeperA_L","DisKeeperB_L","DisKeeperC_L","DisKeeperD_L"};  // 4 ea
        string[] mDisKeePStrR = {"DisKeeperA_R","DisKeeperB_R","DisKeeperC_R","DisKeeperD_R"};  // 4 ea
        string[] mDisGKLM = {"DisGKLM01_m","keeper_left02(300)sujung"};  // Sitting..
        string[] mDisGKRM = {"DisGKRM01_m","keeper_right02(300)sujung"};
        
        string kickAni, keepAni, cameraAni;
        //int kickSkill = Ag.mgIsKick ? Ag.mgSkill: Ag.mgEnemSkill; 
        int kickSkill = Ag.mgSkill;
        CerCam.enabled = true;
        
        // //////////////////////////////////////////////////   Kicker Animation Setting...
        if (IsKickerWin())  kickAni =  (mCerKickStr[mCerKickAni]);
        else                kickAni =  (mDisKickStr[mDisKickAni]);
        
        // //////////////////////////////////////////////////   Camera... Animation Setting...  
        if (Ag.mgIsKick) {
            if (myWin)  cameraAni =  (mCerCamera[mCerKickAni]);
            else        cameraAni =  (mDisCamera[mDisKickAni]);
        } else { // Keeper...
            if (myWin) cameraAni = AmIRight()? mCerKPCamL[mCerKeepAni]: mCerKPCamR[mCerKeepAni];
            else { cameraAni = AmIRight()? mDisKPCamL[mDisKeepAni]: mDisKPCamR[mDisKeepAni];
                if (Ag.mgSkill > 0 && !IsSameDirection()) cameraAni = AmIRight()? mKpMissDissCamL[kickSkill-1] : mKpMissDissCamR[kickSkill-1];
            } //ljk 11/27
            
            
        }
        
        // //////////////////////////////////////////////////   Keeper .....
        if (IsKickerWin()) {    // Goul In  .......>>>>>>>>>
            //-2012_08_20
            if (IsSameDirection()) {
                keepAni = IsKeeperRight()?  mDisKeePStrL[mDisKeepAni]: mDisKeePStrR[mDisKeepAni];
            } else {
                //keepAni = IsKeeperRight()?  mDisGKRM[kickSkill-1]: mDisGKLM[kickSkill-1];  // 0 or 1 ...
                if ( Ag.mgSkill > 0)
                    keepAni = IsKeeperRight()?  mDisGKLM[kickSkill-1]: mDisGKRM[kickSkill-1];  // 0 or 1 ...
                else keepAni   = IsKeeperRight()? "Dis_noActR": "Dis_noActL"; //ljk 11/27
            }
            
            if ( IsGoulerDdong() ) {
                keepAni   = IsKeeperRight()? "Dis_noActR": "Dis_noActL";
                
                if (!Ag.mgIsKick && IsSameDirection()){  // >>>>>  Camera  <<<<< //
                    cameraAni = IsKeeperRight()? "C_Keeper_Dis_NoAct_R": "C_Keeper_Dis_NoAct_L";
                } else if (!Ag.mgIsKick && !IsSameDirection()){
                    //cameraAni = IsKeeperRight()? "C_Keeper_R_Miss_0" + kickSkill.ToString(): "C_Keeper_L_Miss_0" + kickSkill.ToString();
                    cameraAni = IsKeeperRight()? "C_Keeper_Dis_NoAct_R": "C_Keeper_Dis_NoAct_L";
             } else {
                    cameraAni = mCerCamera[mCerKickAni];
                }
            }
        } else {                // No Goul Case....  >>>>>>>>>>>
            //-2012_08_20
            if (IsGoulerDdong())    keepAni = IsKeeperRight()? "Cer_noActL": "Cer_noActR";
            else                    keepAni = IsKeeperRight()? mCerKeepStrL [mCerKeepAni]: mCerKeepStrR [mCerKeepAni];
            
            //if (IsKickerDdong())    keepAni = IsKickerRight()? mCerKeepStrL [mCerKeepAni]: mCerKeepStrR [mCerKeepAni];
        }
        

        // //////////////////////////////////////////////////  Play Animations....
        mPlayerKicker.animation.Play (kickAni);
        mPlayerKeeper.animation.Play (keepAni);
        CerCam.animation.Play (cameraAni);
        
        
        Ag.LogIntense(10, true);
        Debug.Log("Kick? " + Ag.mgIsKick + "   Win? " + Ag.mgDidWin +  "    MyDirSkl " + Ag.mgDirection + " / " + Ag.mgSkill + "   Enem_ " + 
            Ag.mgEnemDirec + " / " + Ag.mgEnemSkill + "       Ani : Kick " + kickAni + "  Goul " + keepAni  +
            "  cam " + cameraAni + "\n");
        Ag.LogIntense(5, false);
    }
    
    //--------------------------------------------------------------------------------------------------------------------------------------------------
	void EndingCer() {
        
        CerCam.enabled = true;
        
        bool myWin;
        myWin = Ag.mgDidWin;
        
        string ranNumStr = Random.Range(1,4).ToString() , ranKeeperStr = Random.Range(1,3).ToString();
        mkeeperPos = mPlayerKeeper.transform.FindChild("Bip001").gameObject.gameObject;
        mKickerPos = mPlayerKicker.transform.FindChild("Bip001").gameObject.gameObject;
        
        if (Ag.mgIsKick) { //MyTurn is KickerMode
            if (myWin) {
                switch(ranNumStr){
                case "1":
                    mPlayerKicker.transform.eulerAngles = new Vector3(0,-30,0);
                    break;
                case "2":
                   mPlayerKicker.transform.eulerAngles = new Vector3(0,165,0);
                   break;
                case "3":
                   mPlayerKicker.transform.eulerAngles = new Vector3(0,165,0);
                   break;
                }
                mPlayerKicker.transform.position = new Vector3(2.59593f, 0.04181996f, -36.41669f);
                CerCam.animation.Play ("C_Kicker_LastCer" + ranNumStr );
                mPlayerKicker.animation.Play( "CereLastWin0" + ranNumStr);
                
                
                //keeperRight Lose
                if(IsKeeperRight()){
                    if (ranKeeperStr == "1") mPlayerKeeper.animation.Play("CerLastLoseA_R");
                    else mPlayerKeeper.animation.Play("Cer_Lose_Hard_B_R");
                } else {
                //KeeperLeft Lose    
                    if (ranKeeperStr == "1") mPlayerKeeper.animation.Play("CerLastLoseA_L");
                    else mPlayerKeeper.animation.Play("Cer_Lose_Hard_B_L");
                }
            } else {
                mPlayerKicker.transform.position = new Vector3(2.59593f, 0.04181996f, -36.41669f);
                mPlayerKicker.transform.eulerAngles = new Vector3(0,180,0);
                mPlayerKicker.animation.Play ("DisLastLose");
                CerCam.animation.Play ("C_Kicker_LastLose");
                
                //KeeperRight Win
                if(IsKeeperRight()){
                    if (ranKeeperStr == "1") mPlayerKeeper.animation.Play("Cer_KP_LastWinA_R");
                    else mPlayerKeeper.animation.Play("Cer_KP_LastWinB_R");
                } else {
                //KeeperLeft Win    
                    if (ranKeeperStr == "1") mPlayerKeeper.animation.Play("Cer_KP_LastWinA_L");
                    else mPlayerKeeper.animation.Play("Cer_KP_LastWinB_L");
                }
                
            }
        } else { //MyTurn is KeeperMode
            mCerCamAxis.SetActiveRecursively(true);
            CerCam.enabled = false;
            //DefnCam = GameObject.Find ("CerAxis/DefCamera").gameObject.gameObject;
            if (myWin) { 
                if(IsKeeperRight()){
                    
                    if (ranKeeperStr == "1") { 
                        mKPlastCer = 1;
                        mPlayerKeeper.animation.Play("Cer_KP_LastWinA_R");
                        
                    } else {
                        mKPlastCer = 2;
                        KeeperAction();
                        mPlayerKeeper.animation.Play("Cer_KP_LastWinB_R");
                        
                    }
                } else {
                    if (ranKeeperStr == "1") {
                        mKPlastCer = 3;
                        mPlayerKeeper.animation.Play("Cer_KP_LastWinA_L");
                        
                    } else {
                        mKPlastCer = 4;
                        KeeperAction();
                        mPlayerKeeper.animation.Play("Cer_KP_LastWinB_L");
                        
                    }
                }
                //Kicker Lose
                mPlayerKicker.transform.position = new Vector3(2.59593f, 0.04181996f, -36.41669f);
                mPlayerKicker.transform.eulerAngles = new Vector3(0,180,0);
                mPlayerKicker.animation.Play ("DisLastLose");
                //keeper
                
                
            } else { 
                //KeeperLose
                if (IsKeeperRight()){
                     
                    if (ranKeeperStr == "1") { 
                        mKPlastCer = 5;
                        mPlayerKeeper.animation.Play("CerLastLoseA_L");
                        
                    } else {
                        mKPlastCer = 6;
                        mPlayerKeeper.animation.Play("Cer_Lose_Hard_B_L");
                    }
                } else {
                     
                    if (ranKeeperStr == "1") {
                        mKPlastCer = 7;
                        mPlayerKeeper.animation.Play("CerLastLoseA_R");
                    } else {
                        mKPlastCer = 8;
                        mPlayerKeeper.animation.Play("Cer_Lose_Hard_B_R");
                    }
                }
                
                //KickerWin
                switch(ranNumStr){
                case "0":
                    mPlayerKicker.transform.eulerAngles = new Vector3(0,-30,0);
                    break;
                case "1":
                   mPlayerKicker.transform.eulerAngles = new Vector3(0,165,0);
                   break;
                case "2":
                   mPlayerKicker.transform.eulerAngles = new Vector3(0,165,0);
                   break;
                }
                mPlayerKicker.transform.position = new Vector3(2.59593f, 0.04181996f, -36.41669f);
                mPlayerKicker.animation.Play( "CereLastWin0" + ranNumStr);
               
            }
        }
   }
    
    
    void RedbullAni () {
        //arrStatusBar[0].transform.localScale = (new Vector3(704.9203f, 0.002108231f, 0.002492417f));
        //arrStatusBar[0].transform.localPosition = (new Vector3(-0.2096453f, -1.015724f, 0.002227783f));
        arrStatusBar[0].animation.Play("animation");
    }
    
    void KeeperWinAni1 () {
        mCerCamAxis.transform.Rotate(new Vector3(0,1.3f,0));
        mCerCamAxis.transform.position =  new Vector3(mkeeperPos.transform.position.x  ,1.508962f, mkeeperPos.transform.position.z);
        //DefnCam.transform.LookAt (new Vector3(mKickerPos.transform.position.x,1.508962f -3f ,mKickerPos.transform.position.z + 4f));
        mCerCamAxis.transform.eulerAngles =  new Vector3 (0,DefnCam.transform.rotation.y * 100f,0);
        
    }
    void KeeperWinAni2 () {
        mCerCamAxis.transform.position =  new Vector3(mkeeperPos.transform.position.x  ,1.508962f, mkeeperPos.transform.position.z);
        mCerCamAxis.transform.Rotate(new Vector3(0, mRotSpeed, 0));
        
    }
    void KeeperWinAni3 () {
        mCerCamAxis.transform.Rotate(new Vector3(0,1.3f,0));
        mCerCamAxis.transform.position =  new Vector3(mkeeperPos.transform.position.x  ,1.508962f, mkeeperPos.transform.position.z);
        //DefnCam.transform.LookAt (new Vector3(mKickerPos.transform.position.x,1.508962f -3f ,mKickerPos.transform.position.z + 4f));
        mCerCamAxis.transform.eulerAngles =  new Vector3 (0,DefnCam.transform.rotation.y * 100f,0);
        
    }
    void KeeperWinAni4 () {
        mCerCamAxis.transform.position =  new Vector3(mkeeperPos.transform.position.x  ,1.508962f, mkeeperPos.transform.position.z);
        mCerCamAxis.transform.Rotate(new Vector3(0, mRotSpeed, 0));
        
    }
    
    void KeeperLoseAni1 () {
        mCerCamAxis.transform.position =  new Vector3(mkeeperPos.transform.position.x ,1.508962f, mkeeperPos.transform.position.z - 0.5f);
        DefnCam.transform.LookAt (new Vector3(mKickerPos.transform.position.x,1.508962f - 3f, mKickerPos.transform.position.z + 4f));
        mCerCamAxis.transform.eulerAngles =  new Vector3 (0,DefnCam.transform.rotation.y * 100f,0);
    }
    
    void KeeperLoseAni2 () {
        mCerCamAxis.transform.position =  new Vector3(mkeeperPos.transform.position.x  ,1.508962f, mkeeperPos.transform.position.z + 0.5f);
        DefnCam.transform.LookAt (new Vector3(mKickerPos.transform.position.x,1.508962f -3f ,mKickerPos.transform.position.z + 4f));
        mCerCamAxis.transform.eulerAngles =  new Vector3 (0,DefnCam.transform.rotation.y * 100f,0);
    }
    
    void KeeperLoseAni3 () {
        mCerCamAxis.transform.position =  new Vector3(mkeeperPos.transform.position.x ,1.508962f, mkeeperPos.transform.position.z - 0.5f);
        DefnCam.transform.LookAt (new Vector3(mKickerPos.transform.position.x,1.508962f - 3f,mKickerPos.transform.position.z + 4f));
        mCerCamAxis.transform.eulerAngles =  new Vector3 (0,DefnCam.transform.rotation.y * 100f,0);
    }
    
    void KeeperLoseAni4 () {
        mCerCamAxis.transform.position =  new Vector3(mkeeperPos.transform.position.x  ,1.508962f, mkeeperPos.transform.position.z + 0.5f);
        DefnCam.transform.LookAt (new Vector3(mKickerPos.transform.position.x,1.508962f -3f ,mKickerPos.transform.position.z + 4f));
        mCerCamAxis.transform.eulerAngles =  new Vector3 (0,DefnCam.transform.rotation.y * 100f,0);
    } 
}
