using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class MainRpsMatch : MonoBehaviour {
    GameObject m_KpLodingbar, m__KpLodingbarLabel;
    
    //--------------------------------------------------------------------Kicker LodingBar
    
    void mLodingInerOuterAni(bool pbool) {
        if (pbool) {
            m_KpLodingbar.transform.FindChild("InGround").animation.Play();
            m_KpLodingbar.transform.FindChild("OutGround").animation.Play();
        } else {
            m_KpLodingbar.transform.FindChild("InGround").animation.Stop ();
            m_KpLodingbar.transform.FindChild("OutGround").animation.Stop ();
        }
    }
    
    IEnumerator PlayerinfobarFlag(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        mKeeperLabel.transform.renderer.material.mainTexture = (Texture2D)Resources.Load("200_Start/UI/font");
        mKeeperLabel.transform.renderer.enabled = true;
        mKeeperLabel.animation.Play("KeeperFonttex");
        mPlayerinfoflag = true;
    }
    
    
    
    
    IEnumerator LodingBarAni(float waitTime, string pObjString, string paniname, bool pbool) {
        yield return new WaitForSeconds(waitTime);
        m__KpLodingbarLabel.GetComponent<UILabel>().text = pObjString;
        m__KpLodingbarLabel.animation.Play(paniname);
        mLodingInerOuterAni(pbool);
    }
    
    IEnumerator KeeperLodingBarAni(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        //mKeeperLabel.GetComponent<UILabel>().text = "SWIPE";
        mKeeperLabel.transform.renderer.material.mainTexture =  (Texture2D)Resources.Load("200_Start/UI/fonttex");
        mPlayerinfoflag = false;
        mKeeperLabel.animation.Play("KeeperFonttex");
        Defaultcloth ();
        
    }
    
    
    void LodingBarOff (bool pbool) {
        m_KpLodingbar.SetActive(pbool);
    }
    
    void KpLodingBarAni(float waitTime, string pObjString, string pAniName, bool pbool) {
        StartCoroutine(LodingBarAni(waitTime,pObjString,pAniName,pbool));
        
    }
    
    //---------------------------------------------------------------------
    
    void CreateGuidebar () {
        GameObject Guidebar;
        ListGameObject  = new List<GameObject>();
        float y1 = mSY * 0.873438f;
        for(int i = 1 ; i  < 5 ; i++ ) {
            Vector3 mDirbarPosSta = mCamera.ScreenToWorldPoint(new Vector3(dicGuideObjectPos[i],y1 - Screen.height * 0.73f ));
            Vector3 mDirbarPosEnd = mCamera.ScreenToWorldPoint(new Vector3(dicGuideObjectWidth[i],y1 - Screen.height * 0.73f ));
            
                    //arrGamedirBar[curVal[0]-1].transform.position = mDirbarPosSta;
            //Guidebar = MakePlane.CreatePlane5(new Vector3 (0.29f,62.67f,162f) , new Vector3 (mDirbarPosSta.x,mDirbarPosSta.y,162f), new Vector3 (mDirbarPosEnd.x,mDirbarPosEnd.y,162f));
            Guidebar = MakePlane.CreatePlane5(new Vector3 (0.27f,62.65f,162f) ,new Vector3 (0.33f,62.65f,162f) , new Vector3 (mDirbarPosSta.x,mDirbarPosSta.y,162f), new Vector3 (mDirbarPosEnd.x,mDirbarPosEnd.y,162f));
            Guidebar.transform.renderer.material = GameTexture(i);
            Guidebar.renderer.enabled = false;
            ListGameObject.Add(Guidebar);
                //mGuideBar.Add(Guidebar);
        }
    }
    void MiniRandomItemAniPlay(Texture2D pTex) {
        //mMiniItem.SetActiveRecursively(true);
        if (mMiniItem.active == true) {
            mMiniRandomEff.GetComponent<ParticleSystem>().renderer.material.mainTexture = pTex; 
            mMiniRandomEff.GetComponent<ParticleSystem>().Play();
        }
    }
    void CharacterInforAni (bool pFlag) {
        if (!pFlag) {
            mCharacterinfor.animation["InformationAni"].speed = -1;
            mCharacterinfor.animation["InformationAni"].time = mCharacterinfor.animation["InformationAni"].length;
            mCharacterinfor.animation.Play ("InformationAni");
        } else {
            mCharacterinfor.animation["InformationAni"].speed = 1;
            mCharacterinfor.animation.Play ("InformationAni");
        }
    }
    
    
    
    //----------------------------------------------------------------------------Kicker view event;
    IEnumerator GuideAni(float waitTime, int pObjNum) {
        yield return new WaitForSeconds(waitTime);
        arrListTxt[pObjNum+1] = arrTexBar[pObjNum];
        ListGameObject[pObjNum].animation.AddClip(Clip,"BarAni");
        ListGameObject[pObjNum].renderer.enabled = true;
        ListGameObject[pObjNum].animation.Play("BarAni");
        SoundManager.Instance.Play_Effect_Sound("Swoosh");
     }
    
     IEnumerator RoundBarAni(float waitTime, int pObjNum) {
        yield return new WaitForSeconds(waitTime);
        arrListTxt[pObjNum+1] = arrTexBar[pObjNum+4];
        arrKickerDirBar[pObjNum].animation.renderer.enabled = true;
        arrKickerDirBar[pObjNum].animation.AddClip(Clip2,"KickerBarRoundAni");
        arrKickerDirBar[pObjNum].animation.Play("KickerBarRoundAni");
        
     }
    
    IEnumerator RoundAllBarAni(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        for (int i = 0 ; i < 4 ; i++ ) {
            arrKickerDirBar[i].animation.Play ("UiANI_DirectionBar");
        }
     }
    
    
    void GuidebarAniPlay() {
        Clip = (AnimationClip)Resources.Load("500Game/Animation/bule");
        Clip2 = (AnimationClip)Resources.Load("500Game/Animation/KickerBarAni");
        
        StartCoroutine(GuideAni(0.4f,0));//left up
        StartCoroutine(RoundBarAni(0.41f,0));
        StartCoroutine(GuideAni(0.5f,1));//right up
        StartCoroutine(RoundBarAni(0.51f,1));
        StartCoroutine(GuideAni(0.6f,2));//left down
        StartCoroutine(RoundBarAni(0.61f,2));
        StartCoroutine(GuideAni(0.7f,3));//right down
        StartCoroutine(RoundBarAni(0.71f,3));
        
        StartCoroutine(RoundAllBarAni(0.9f));
    }
    
    
    Material GameTexture (int pcolnum) {
        //Material mat = 
        return (Material)Resources.Load("500Game/UI/Materials/"+pcolnum);
    }
    
    void DestoryGuideBar () {
        for (int i = 0 ; i < ListGameObject.Count ; i++ ){
            DestroyObject(ListGameObject[i]);
        }
    }
    
    
    //----------------------------------------------------------------------------KeeperView Evnet;
    
    IEnumerator KeeperViewPreAni (float waitTime, int pObjNum) {
        yield return new WaitForSeconds(waitTime);
        arrListTxt[pObjNum+1] = arrTexBar[pObjNum];
        arrKeeperBarB[pObjNum].transform.renderer.enabled = true;
        arrKeeperBarB[pObjNum].animation.AddClip(Clip,"KeeperPreview");
        arrKeeperBarB[pObjNum].animation.Play("KeeperPreview");
    }
    
    IEnumerator KeeperAllAni (float waitTime) {
        yield return new WaitForSeconds(waitTime);
        for (int i = 0 ; i < 4 ; i++ ) {
            arrKeeperBarB[i].renderer.enabled = true;
            arrKeeperBarB[i].animation.Play("KeeperDirBar");
            
        }
    }
    
    IEnumerator KeeperinfoAni (float waitTime, int pObjNum) {
        yield return new WaitForSeconds(waitTime);
        arrListTxt[pObjNum+1] = arrTexBar[pObjNum+4];
    }
    
    
    void GuideKeeperViewAni () {
        Clip = (AnimationClip)Resources.Load("500Game/Animation/KeeperPreBar");
        //StartCoroutine(KeeperViewPreAni(0.2f,1));//left up
        //StartCoroutine(KeeperinfoAni(0.4f,1));
        //StartCoroutine(KeeperViewPreAni(0.7f,0));//right up
        //StartCoroutine(KeeperinfoAni(0.9f,0));
        //StartCoroutine(KeeperViewPreAni(1.2f,3));//left down
        //StartCoroutine(KeeperinfoAni(1.4f,3));
        //StartCoroutine(KeeperViewPreAni(1.7f,2));//right down
        //StartCoroutine(KeeperinfoAni(1.9f,2));
        StartCoroutine(KeeperAllAni(3f));
    }
    //------------------------------------------------------------------------------
    void KickerDirbaroff () {
        for (int i = 0 ; i < 4 ; i++ ) {
            arrKickerDirBar[i].renderer.enabled = false;
        }
    }
    
    IEnumerator ShowZoomCameraoff(float time, int Pnum) {
        
        yield return new WaitForSeconds(time);
        
        arrKickerDirBar[Pnum].transform.renderer.enabled = true;  arrKickerDirBar[Pnum].animation.Play("kickdirec2");  arrKickerDirBar[Pnum].transform.renderer.transform.renderer.material.mainTexture = mKickerDirbar2;
        
        mCameraKick.animation.Stop ();
        mCameraKick.transform.localPosition = new Vector3(1.231774f, -1.820157f, -29.05658f);
        mCameraKick.transform.eulerAngles = new Vector3(354.8362f, 178.2565f, 359.9102f);
        mCameraKick.fieldOfView = 40;
    }
    
    
    
    void KickerTimer () {
        
     
        if (!mTimerFlag) {mPresentTime = Time.time; return;}
        mStartTime =  Time.time - mPresentTime;
     
        if (mStartTime > 0) {mTimerbar.active = true; mTimerbar.transform.renderer.material.mainTexture = mTimer00;}
        if (mStartTime > 0.29) { mTimerbar.transform.renderer.material.mainTexture = mTimer01;}
        if (mStartTime > 0.58) { mTimerbar.transform.renderer.material.mainTexture = mTimer00;}
        if (mStartTime > 0.87) { mTimerbar.transform.renderer.material.mainTexture = mTimer01;}
        if (mStartTime > 1.16) { mTimerbar.transform.renderer.material.mainTexture = mTimer02;}
        if (mStartTime > 1.45) { mTimerbar.transform.renderer.material.mainTexture = mTimer03;}
        if (mStartTime > 1.74) { mTimerbar.transform.renderer.material.mainTexture = mTimer04;}
        if (mStartTime > 2.03) { mTimerbar.transform.renderer.material.mainTexture = mTimer05;}
        if (mStartTime > 2.32) { mTimerbar.transform.renderer.material.mainTexture = mTimer06;}
        if (mStartTime > 2.61) { mTimerbar.transform.renderer.material.mainTexture = mTimer07;}
        if (mStartTime > 2.9) { mTimerbar.transform.renderer.material.mainTexture = mTimer08;}
        if (mStartTime > 3.19) { mTimerbar.transform.renderer.material.mainTexture = mTimer09;}
        if (mStartTime > 3.48) { mTimerbar.transform.renderer.material.mainTexture = mTimer10;}
        if (mStartTime > 3.77) { mTimerbar.transform.renderer.material.mainTexture = mTimer11;}
        if (mStartTime > 4.06) { mTimerbar.transform.renderer.material.mainTexture = mTimer12;}
        if (mStartTime > 4.35) { mTimerbar.transform.renderer.material.mainTexture = mTimer13;}
        if (mStartTime > 4.74) { mTimerbar.transform.renderer.material.mainTexture = mTimer14;}
        if (mStartTime > 5.03) { mTimerbar.transform.renderer.material.mainTexture = mTimer15;}
        if (mStartTime > 5.32) { mTimerbar.transform.renderer.material.mainTexture = mTimer16;}
        if (mStartTime > 5.61) { mTimerbar.transform.renderer.material.mainTexture = mTimer17;}
            
    }
    
    
    
    IEnumerator WaittimeItemShow(float time) {
        yield return new WaitForSeconds(time);
        if (!Ag.mBallEventAlready){ mGameObj.SetActiveRecursively(false); mEventItemShowTime = false;}
        else { mGameObj.SetActiveRecursively(false); mEventItemShowTime = false;}
            
    }
    
    IEnumerator CResultShow(float time) {
        yield return new WaitForSeconds(time);
        mResultShow = true;    
    }
    
    
    IEnumerator mRandomItemoff(float time) {
        yield return new WaitForSeconds(time);
        MiniRandomItemAniPlay(mRevRoundAni);
        mMiniItem.SetActiveRecursively(false);
    }
    
    
    
    void SetKickerDir ( bool dir) {
     
     for (int i = 0 ; i< 4 ; i++ ) {
         arrKickerDirBar[i].active = true;
         arrKickerDirBar[i].transform.renderer.enabled = dir;
         //arrKickerDirBar[i].animation.Play ("UiANI_DirectionBar");
         arrKickerDirBar[i].transform.renderer.transform.renderer.material.mainTexture = mKickerDirbar1;
         
         //arrKickerDirBar[i].transform.renderer.transform.renderer.material.color = new Color (255f,255f,255f,125f);
     }
    }
    
    //  ////////////////////////////////////////////////     Game :: Intro Ani.....
    
    
    void SetPlayerDir2 () {
        //
     mstatusBar = false;
     
        if (Ag.mgIsKick) {
            //SetKickerDir(false);
            //if (Ag.mgDirection == 0) ;//SetKickerDir(false);
            
            if (Ag.mgDirection == 1 ) {if (zoomCameraFlag) {arrAimObj[0].transform.renderer.enabled = true;  arrAimObj[0].animation.Play("alphaAni"); mCameraKick.animation.Play("KickerZoom");zoomCameraFlag = false;
                                                            arrAimObj[1].transform.renderer.enabled = false;
                                                            arrAimObj[2].transform.renderer.enabled = false;
                                                            arrAimObj[3].transform.renderer.enabled = false;
                                                            KickerDirbaroff ();
                                                            StartCoroutine(ShowZoomCameraoff(0.8f,0));
                    
                                                            }
                                      
                                     }
            if (Ag.mgDirection == 2) {if (zoomCameraFlag) {arrAimObj[1].transform.renderer.enabled = true;  arrAimObj[1].animation.Play("alphaAni"); mCameraKick.animation.Play("KickerZoom2"); zoomCameraFlag = false;
                                                            arrAimObj[0].transform.renderer.enabled = false;
                                                            arrAimObj[2].transform.renderer.enabled = false;
                                                            arrAimObj[3].transform.renderer.enabled = false;
                                                            KickerDirbaroff ();
                                                            StartCoroutine(ShowZoomCameraoff ( 0.8f,1));
                         
                                                            }
                                     }
            if (Ag.mgDirection == 3) {if (zoomCameraFlag) {arrAimObj[2].transform.renderer.enabled = true;  arrAimObj[2].animation.Play("alphaAni"); mCameraKick.animation.Play("KickerZoom3"); zoomCameraFlag =false;
                                                              arrAimObj[0].transform.renderer.enabled = false;
                                                              arrAimObj[1].transform.renderer.enabled = false;
                                                              arrAimObj[3].transform.renderer.enabled = false;
                                                              KickerDirbaroff ();
                                                              StartCoroutine(ShowZoomCameraoff ( 0.8f,2));
                                                           }
    
                                            
                                     }
            if (Ag.mgDirection == 4) {if (zoomCameraFlag) {arrAimObj[3].transform.renderer.enabled = true;   arrAimObj[3].animation.Play("alphaAni"); mCameraKick.animation.Play("KickerZoom4"); zoomCameraFlag = false;
                                                              arrAimObj[0].transform.renderer.enabled = false;
                                                              arrAimObj[1].transform.renderer.enabled = false;
                                                              arrAimObj[2].transform.renderer.enabled = false;
                                                              KickerDirbaroff ();
                                                              StartCoroutine(ShowZoomCameraoff ( 0.8f,3));
                                                            }
                
                                     }
            /*
            if (!mCameraKick.animation.isPlaying) {
                    mCameraKick.transform.localPosition = new Vector3(1.231774f, -1.820157f, -29.05658f);
                    mCameraKick.transform.eulerAngles = new Vector3(354.8362f, 178.2565f, 359.9102f);
                    mCameraKick.fieldOfView = 40;
                }
                */
        } else {
            if (Ag.mgDirection == 0) DragPosition(false);//SetKickerDir(false);
            
            if (Ag.mgDirection == 1) {
                arrKeeperBarF[0].transform.renderer.enabled = true;
                arrKeeperBarF[1].transform.renderer.enabled = false;
                arrKeeperBarF[2].transform.renderer.enabled = false;
                arrKeeperBarF[3].transform.renderer.enabled = false;
                
                arrKeeperBarB[0].transform.renderer.enabled = false;
                arrKeeperBarB[1].transform.renderer.enabled = true;
                arrKeeperBarB[2].transform.renderer.enabled = true;
                arrKeeperBarB[3].transform.renderer.enabled = true;
                
            }
            if (Ag.mgDirection == 2) {
                arrKeeperBarF[0].transform.renderer.enabled = false;
                arrKeeperBarF[1].transform.renderer.enabled = true; 
                arrKeeperBarF[2].transform.renderer.enabled = false; 
                arrKeeperBarF[3].transform.renderer.enabled = false;
                
                arrKeeperBarB[0].transform.renderer.enabled = true;
                arrKeeperBarB[1].transform.renderer.enabled = false;
                arrKeeperBarB[2].transform.renderer.enabled = true;
                arrKeeperBarB[3].transform.renderer.enabled = true;
            }
            if (Ag.mgDirection == 3) {
                arrKeeperBarF[0].transform.renderer.enabled = false;
                arrKeeperBarF[1].transform.renderer.enabled = false; 
                arrKeeperBarF[2].transform.renderer.enabled = true; 
                arrKeeperBarF[3].transform.renderer.enabled = false;
                
                arrKeeperBarB[0].transform.renderer.enabled = true;
                arrKeeperBarB[1].transform.renderer.enabled = true;
                arrKeeperBarB[2].transform.renderer.enabled = false;
                arrKeeperBarB[3].transform.renderer.enabled = true;
            }
            if (Ag.mgDirection == 4) {
                arrKeeperBarF[0].transform.renderer.enabled = false;
                arrKeeperBarF[1].transform.renderer.enabled = false; 
                arrKeeperBarF[2].transform.renderer.enabled = false; 
                arrKeeperBarF[3].transform.renderer.enabled = true;
                
                arrKeeperBarB[0].transform.renderer.enabled = true;
                arrKeeperBarB[1].transform.renderer.enabled = true;
                arrKeeperBarB[2].transform.renderer.enabled = true;
                arrKeeperBarB[3].transform.renderer.enabled = false;
            }
            
        }
        
    }
    
    
    void SetPlayerDir () {
       if (Ag.mgIsKick) {
            Debug.Log ("mGDir>>>>>>>>>>>>>>>>>>>>>>>>>"+Ag.mgDirection);
            if (Ag.mgDirection == 0) {
                for (int i = 0; i < 4; i++){
                    arrKickerDirBar[i].renderer.enabled = false;
                } 
            } else {
                for (int i = 1; i < 5; i++){
                    if(Ag.mgEnemDirec == i){
                        arrKickerDirBar[i-1].renderer.enabled = true;
                        continue;
                    }
                        arrKickerDirBar[i-1].renderer.enabled = false;
                } 
            }
        } else {
        }
        
    }
    
    
    void EnemyCharacterEffect () {
        byte myDir, enDir, mySkl, enSkl;
        myDir = Ag.mgDirection; mySkl = Ag.mgSkill;
        enDir = Ag.mgEnemDirec; enSkl = Ag.mgEnemSkill;
        
        if (Ag.mgIsKick) {
            if(enSkl == 1) {
                mDirUpclone4 = (GameObject)Instantiate(mDirUpeff, mKpTrailL.transform.position ,Quaternion.identity); mDirUpclone4.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameL); mDirUpclone4.animation.Play();
                mDirUpclone5 = (GameObject)Instantiate(mDirUpeff, mKpTrailR.transform.position ,Quaternion.identity); mDirUpclone5.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameR); mDirUpclone5.animation.Play();
              }
            if(enSkl == 2) {
                mKpTrailL.GetComponent<TrailRenderer>().enabled = true;
                mKpTrailR.GetComponent<TrailRenderer>().enabled = true;
                mDirUpclone4 = (GameObject)Instantiate(mDirUpeff, mKpTrailL.transform.position ,Quaternion.identity); mDirUpclone4.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameL);
                mDirUpclone5 = (GameObject)Instantiate(mDirUpeff, mKpTrailR.transform.position ,Quaternion.identity); mDirUpclone5.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameR);
                mDirUpclone4.transform.localScale = new Vector3(1.01f,1.01f,1.01f);
                mDirUpclone5.transform.localScale = new Vector3(1.01f,1.01f,1.01f);
             }
         } else {
             if(enSkl == 1) {
                 mDirUpclone6 = (GameObject)Instantiate(mSkillUpeff,mPlayerKicker.transform.FindChild(mkickerRfoot).position,Quaternion.identity); mDirUpclone6.transform.parent = mPlayerKicker.transform.FindChild(mkickerRfoot); mDirUpclone6.animation.Play();
              }
             if(enSkl == 2) {
                 mKickBall.GetComponent<TrailRenderer>().enabled = true;
                 mKickBall.GetComponent<TrailRenderer>().enabled = true;
                 mDirUpclone6 = (GameObject)Instantiate(mSkillUpeff,mPlayerKicker.transform.FindChild(mkickerRfoot).position,Quaternion.identity); mDirUpclone6.transform.parent = mPlayerKicker.transform.FindChild(mkickerRfoot);
                 mDirUpclone6.transform.localScale = new Vector3(1.01f,1.01f,1.01f);
             }
         }
    }

}
