using UnityEngine;
using System.Collections;

public partial class MainRpsMatch : MonoBehaviour {
    void PreAni() {
        CerCam.enabled = false;
        /*
        mKickBall.transform.position = new Vector3(0.4018516f, 0.1229186f, -34.6767f);
        mCameraKick.transform.localPosition = new Vector3(1.747605f, -1.808734f, -29.25965f);
        mCameraKick.transform.eulerAngles = new Vector3(-7.490753f, 182.9599f, 0f);
         */  
        
        if (Ag.mgIsKick) {
            mKickBall.collider.isTrigger = true;
            mKickBall.rigidbody.useGravity = false;
            
            mKickBall.transform.position = new Vector3(0.4018516f, 0.1229186f, -34.6767f);
            mCameraKick.transform.localPosition = new Vector3(1.231774f, -1.820157f, -29.05658f);
            mCameraKick.transform.eulerAngles = new Vector3(354.8362f, 178.2565f, 359.9102f);
            mCameraKick.fieldOfView = 40;
            
            
        } else {
         /*
            mKickBall.rigidbody.useGravity = false;
            mKickBall.collider.isTrigger = true;
            mKickBall.transform.position = new Vector3(0.4018516f, 0.1229186f, -34.6767f);
            mCameraDefn.transform.localPosition = new Vector3(0.8045616f, -1.196656f, -48.14809f);
            mCameraDefn.transform.eulerAngles = new Vector3 (-3.844543f, -11.05716f, 0.8071289f);
            mCameraDefn.fieldOfView = 29f;
            
            */
         mKickBall.rigidbody.useGravity = false;
            mKickBall.collider.isTrigger = true;
            mKickBall.transform.position = new Vector3(0.4018516f, 0.1229186f, -34.6767f);
            /*
            mCameraDefn.transform.localPosition = new Vector3(0.8832697f, -1.154396f, -48.16753f);
            mCameraDefn.transform.eulerAngles = new Vector3 (-3.844543f, -11.05716f, 0.8071289f);
            */
            mCameraDefn.transform.localPosition = new Vector3(0.6137812f, -1.154396f, -47.92203f);
            mCameraDefn.transform.eulerAngles = new Vector3 (-3.844574f, -11.05727f, 0.8071289f);
            
            mCameraDefn.fieldOfView = 33f;
        }
        mPlayerKicker.transform.eulerAngles = new Vector3(0f, 180f, 0f);
        
        mPlayerKeeper.transform.position = new Vector3(0.06f, 0f, -45.67266f); //keeper setting
        mPlayerKeeper.transform.eulerAngles = new Vector3(0, 0, 0);
        mAnimaRand  = Random.Range(0,5);
        
        switch (mAnimaRand){
        case 0:
            mPlayerKicker.transform.position = new Vector3(0.5916449f, 0.04181996f, -34.25025f);
            mBall.transform.position = new Vector3(1.350924f, 1.283536f, -34.30703f);
            mPlayerKicker.animation.Play ("ballset01");
            mPlayerKeeper.animation.Play ("goalready");
            
            break;
        case 1:
            mPlayerKicker.transform.position = new Vector3(0.782496f, 0.04181996f, -33.99356f);
            mBall.transform.position = new Vector3(1.541775f, 1.283536f, -34.05035f);
            mPlayerKicker.animation.Play ("ballset02");
            mPlayerKeeper.animation.Play ("goalready");
            
            break;
        case 2:
            mPlayerKicker.transform.position = new Vector3(0.6011075f, 0.04181996f, -34.11449f);
            mBall.transform.position = new Vector3(1.360387f, 1.283536f, -34.17127f);
            mPlayerKicker.animation.Play ("ballset03");
            mPlayerKeeper.animation.Play ("goalready");
            break;
        case 3:
            mPlayerKicker.transform.position = new Vector3(0.5774047f, 0.04181996f, -34.21926f);
            mBall.transform.position = new Vector3(1.336684f, 1.283536f, -34.27605f);
            mPlayerKicker.animation.Play ("ballset04");
            mPlayerKeeper.animation.Play ("goalready");
            
            break;
        case 4:
            mPlayerKicker.transform.position = new Vector3(0.6541872f, 0.04181996f, -34.13402f);
            mBall.transform.position = new Vector3(1.413466f, 1.283536f, -34.1908f);
            mPlayerKicker.animation.Play ("ballset05");
            mPlayerKeeper.animation.Play ("goalready");
            
            break;
        case 5:
            mPlayerKicker.transform.position = new Vector3(0.5704616f, 0.04181996f, -34.34101f);
            mBall.transform.position = new Vector3(1.329741f, 1.283536f, -34.39779f);
            mPlayerKicker.animation.Play ("ballset06");
            mPlayerKeeper.animation.Play ("goalready");
            
            break;
        }
        
        Debug.Log( "Player Animation is playing ?? Keeper  >> " + mPlayerKeeper.animation.isPlaying + " and   Kicker  >>  " + mPlayerKicker.animation.isPlaying );
    }
    
    //----------------------------------------------------------------------------Network Ani
    
    void mNetworkWaitAni() {
        
        Ag.LogString( "NetworkAnimationPlay :: " +  mAnimaRand.ToString() );
        mPlayerKeeper.animation.Play ("goalready_after");
        switch (mAnimaRand){
        case 0: mPlayerKicker.animation.Play ("ballset01_after");   break;
        case 1: mPlayerKicker.animation.Play ("ballset02_after");   break;
        case 2: mPlayerKicker.animation.Play ("ballset03_after");   break;
        case 3: mPlayerKicker.animation.Play ("ballset04_after");   break;
        case 4: mPlayerKicker.animation.Play ("ballset05_after");   break;
        case 5: mPlayerKicker.animation.Play ("ballset06_after");   break;
        }
    }
    
    //-----------------------------------------------------------------------------mid Kick Ani
    
    void AnimaPlay() {
        int mark = 0;
        Ag.LogString("animationplay");
        
        byte myDir, enDir, mySkl, enSkl;
        myDir = Ag.mgDirection; mySkl = Ag.mgSkill;
        enDir = Ag.mgEnemDirec; enSkl = Ag.mgEnemSkill;
        Debug.Log ("myDir    :" + myDir + "     mySkl     :"+ mySkl + "       enDir         :"+     enDir     +"      enskl      "+ enSkl  );
        AmAni = new AmAnimation();
        
        //-----------------------------------------------------------
     /*
     if (Ag.mgIsKick) {
         if(enSkl == 2) {
             mKpTrailL.GetComponent<TrailRenderer>().enabled = true;
             mKpTrailR.GetComponent<TrailRenderer>().enabled = true;
                mDirUpclone4 = (GameObject)Instantiate(mDirUpeff, mKpTrailL.transform.position ,Quaternion.identity); mDirUpclone4.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameL);
                mDirUpclone5 = (GameObject)Instantiate(mDirUpeff, mKpTrailR.transform.position ,Quaternion.identity); mDirUpclone5.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameR);
                mDirUpclone4.transform.localScale = new Vector3(1.05f,1.05f,1.05f);
                mDirUpclone5.transform.localScale = new Vector3(1.05f,1.05f,1.05f);
         }
     } else {
         if(enSkl == 2) {
             mKickBall.GetComponent<TrailRenderer>().enabled = true;
                mKickBall.GetComponent<TrailRenderer>().enabled = true;
                mDirUpclone6 = (GameObject)Instantiate(mSkillUpeff,mPlayerKicker.transform.FindChild(mkickerRfoot).position,Quaternion.identity); mDirUpclone6.transform.parent = mPlayerKicker.transform.FindChild(mkickerRfoot);
                mDirUpclone6.transform.localScale = new Vector3(1.05f,1.05f,1.05f);
         }
     }
     */
       

        ////////////////////////////////////////////////////////////
        if(Ag.mgIsKick){
            mCameraKick.animation.Play("KickAni");
            mPlayerKicker.transform.position = new Vector3 (2.972845f, 0.04181999f,-31.94141f);
            mPlayerKicker.transform.eulerAngles = new Vector3(0f, 180f, 0f);
            AmAni.StartAnimation(mySkl,myDir,enSkl,enDir);
        } else {
            //mKickBall.animation.Play ("B_BLUOH_S");
            mCameraDefn.animation.Play("KeeperAni");
            mPlayerKicker.transform.position = new Vector3 (2.972845f, 0.04181999f,-31.94141f);
            mPlayerKicker.transform.eulerAngles = new Vector3(0f, 180f, 0f);
            AmAni.StartAnimation(enSkl,enDir,mySkl,myDir);
        }
      
        Ag.LogString("Delegate_GameAnimationPlay >>>>>>  End... >>>> " + mark++);
    }
    
    
    
	
}
