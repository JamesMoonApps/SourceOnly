using UnityEngine;
using System.Collections;

public partial class MainRpsMatch : MonoBehaviour {
    void ItemRun1() {if (Ag.mgIsKick && mStateArr.GetCurStateName() == "AnimaPlay" ) { ItemBox1(); }}
    /*
    void ItemRun2() {mItemflag2 = true; ItemBox2(); ItemBox1(); ItemBox3();}
    void ItemRun3() {mItemflag3 = true; ItemBox3(); ItemBox1(); ItemBox2(); }
    */
    
    void GoldenBallEvent() {
        if (!Ag.mSingleMode) {
            if(mGoldenAfter && Ag.mgDidWin) {
                Ag.mIapPrice += 100; mItemBonus += 100;
                mGodenBallCoin.transform.FindChild("getcoinlavellavel").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("goldengoal01");
                //mGodenBallCoin.transform.FindChild("getcoinlavelimege").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("goldengoal01");
            } else if (mSilverAfter && Ag.mgDidWin) {
                Ag.mIapPrice += 30; mItemBonus += 30;
                mGodenBallCoin.transform.FindChild("getcoinlavellavel").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("SILVELGOAL02");
                //mGodenBallCoin.transform.FindChild("getcoinlavelimege").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("SILVELGOAL02");
            } else if (mBronzeAfter && Ag.mgDidWin) {
                Ag.mIapPrice += 10; mItemBonus += 10;
                mGodenBallCoin.transform.FindChild("getcoinlavellavel").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("bronzegoal01");
                //mGodenBallCoin.transform.FindChild("getcoinlavelimege").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("bronzegoal01");
            }
        } else {
            if(mGoldenAfter && Ag.mgDidWin) {
                Ag.mIapPrice += 50; mItemBonus += 50;
                mGodenBallCoin.transform.FindChild("getcoinlavellavel").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("goldengoal02");
               // mGodenBallCoin.transform.FindChild("getcoinlavelimege").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("goldengoal02");
            } else if (mSilverAfter && Ag.mgDidWin) {
                Ag.mIapPrice += 15; mItemBonus += 15;
                mGodenBallCoin.transform.FindChild("getcoinlavellavel").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("SILVELGOAL03");
                //mGodenBallCoin.transform.FindChild("getcoinlavelimege").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("SILVELGOAL03");
            } else if (mBronzeAfter && Ag.mgDidWin) {
                Ag.mIapPrice += 5; mItemBonus += 5;
                mGodenBallCoin.transform.FindChild("getcoinlavellavel").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("bronzegoal02");
                //mGodenBallCoin.transform.FindChild("getcoinlavelimege").GetComponent<ParticleSystem>().renderer.material.mainTexture = ItemMainTexturechange("bronzegoal02");
            }
            
        }
        mGodenBallCoin.GetComponent<ParticleSystem>().Play();
        mGoldenAfter = mSilverAfter = mBronzeAfter =  mGoldenBallEff = false;
    }
    
    
    
    
    IEnumerator YieldGoldenballeff(float time) {
        yield return new WaitForSeconds(time);
        mDirUpclone7 = (GameObject)Instantiate(mGoldenballeffUp, mKickBall.transform.position ,Quaternion.identity); mDirUpclone7.transform.parent = mKickBall.transform.FindChild("Particle");
        GoldenBallEffect();
    }
    
    void GoldenBallEffect() {
        if (mGoldenBall) { BallChangeTexture("golden copy"); } 
        else if (mSilverBall) { BallChangeTexture("silver"); } 
        else if (mBronzeBall) { BallChangeTexture("bronze"); }
        
        mGoldenBall = mSilverBall = mBronzeBall = false;
    }
    
    
    void MiniEffectPlay(int pint) {
        if (pint == 1) {
            //mEventBallEffect.GetComponent<ParticleSystem>().renderer.material.mainTexture = mRndBoxpng;
            mMiniItem.SetActiveRecursively(true);
            mMiniItem.animation.Play("EventItemScale");
            mMiniItem.transform.renderer.material.mainTexture = mRndBoxpng;
            //mEventBallEffect.GetComponent<ParticleSystem>().Play();
            MiniRandomItemAniPlay(mRoundAni);
        } else if (pint == 2) {
            mEventCoin.transform.FindChild("getcoinlavellavel").GetComponent<ParticleSystem>().renderer.material.mainTexture = mRndBoxpng;
            mEventCoin.GetComponent<ParticleSystem>().Play();
        }
    }
    
    
    void statusSkill () {
       
        if (mskillflag) {
            if ( Ag.mgIsKick) {
                    if(Ag.mgSkill == 0) {
                    /*
                        mKickBall.GetComponent<TrailRenderer>().enabled = true;
                        mDirUpclone1 = (GameObject)Instantiate(mSkillUpeff,mPlayerKicker.transform.FindChild(mkickerRfoot).position,Quaternion.identity); mDirUpclone1.transform.parent = mPlayerKicker.transform.FindChild(mkickerRfoot);
                        //DestroyObject(mDirUpclone1,4f);
                        */
                    }
                    if(Ag.mgSkill == 1) {
                        mDirUpclone1 = (GameObject)Instantiate(mSkillUpeff,mPlayerKicker.transform.FindChild(mkickerRfoot).position,Quaternion.identity); mDirUpclone1.transform.parent = mPlayerKicker.transform.FindChild(mkickerRfoot); mDirUpclone1.animation.Play();
                        //DestroyObject(mDirUpclone1,3f);
                        SoundManager.Instance.Play_Effect_Sound("Sound effect Kickerfoot_good");
                       
                    }
                    if(Ag.mgSkill == 2){
                        mKickBall.GetComponent<TrailRenderer>().enabled = true;
                        mDirUpclone1 = (GameObject)Instantiate(mSkillUpeff,mPlayerKicker.transform.FindChild(mkickerRfoot).position,Quaternion.identity); mDirUpclone1.transform.parent = mPlayerKicker.transform.FindChild(mkickerRfoot);
                        //DestroyObject(mDirUpclone1,7f);
                        SoundManager.Instance.Play_Effect_Sound("Sound effect Kickerfoot");
                        mDirUpclone1.transform.localScale = new Vector3(1.01f,1.01f,1.01f);
                    }
                } else {
                    if(Ag.mgSkill == 0) {
                    /*
                        mKpTrailL.GetComponent<TrailRenderer>().enabled = true;
                        mKpTrailR.GetComponent<TrailRenderer>().enabled = true;
                        mDirUpclone2 = (GameObject)Instantiate(mDirUpeff, mKpTrailL.transform.position ,Quaternion.identity); mDirUpclone2.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameL);
                        mDirUpclone3 = (GameObject)Instantiate(mDirUpeff, mKpTrailR.transform.position ,Quaternion.identity); mDirUpclone3.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameR);
                        //DestroyObject(mDirUpclone2,4f);
                        //DestroyObject(mDirUpclone3,4f);
                        */
                    }
                    if(Ag.mgSkill == 1) {
                        mDirUpclone2 = (GameObject)Instantiate(mDirUpeff, mKpTrailL.transform.position ,Quaternion.identity); mDirUpclone2.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameL); mDirUpclone2.animation.Play();
                        mDirUpclone3 = (GameObject)Instantiate(mDirUpeff, mKpTrailR.transform.position ,Quaternion.identity); mDirUpclone3.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameR); mDirUpclone3.animation.Play();
                        //DestroyObject(mDirUpclone2,3f);
                        //DestroyObject(mDirUpclone3,3f);
                        SoundManager.Instance.Play_Effect_Sound("Sound effect GoalkeeperH_good");
                    }
                    if(Ag.mgSkill == 2){
                        SoundManager.Instance.Play_Effect_Sound("Sound effect GoalkeeperH");
                        mKpTrailL.GetComponent<TrailRenderer>().enabled = true;
                        mKpTrailR.GetComponent<TrailRenderer>().enabled = true;
                        mDirUpclone2 = (GameObject)Instantiate(mDirUpeff, mKpTrailL.transform.position ,Quaternion.identity); mDirUpclone2.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameL);
                        mDirUpclone3 = (GameObject)Instantiate(mDirUpeff, mKpTrailR.transform.position ,Quaternion.identity); mDirUpclone3.transform.parent =  mPlayerKeeper.transform.FindChild(mFoldNameR);
                        //DestroyObject(mDirUpclone2,7f);
                        //DestroyObject(mDirUpclone3,7f);
                        mDirUpclone2.transform.localScale = new Vector3(1.01f,1.01f,1.01f);
                        mDirUpclone3.transform.localScale = new Vector3(1.01f,1.01f,1.01f);
                        
                    }
              }
        }
        mskillflag = false;
    }
    
    
    
    void RandomNum() {
        if (Ag.mgIsKick) {
            while(true) {
                mItemRandomNum = Random.Range(1f,100.1f);
                mItemRandomNum1 = Random.Range(1f,100f);
                mItemRandomNum2 = Random.Range(1f,100f);
                mItemRandomNum3 = Random.Range(1f,100f);
                mItemRandomNum4 = Random.Range(1f,100f);
                mBallPoint = Random.Range(1,5); mBallPoint2 = Random.Range(1,5); mBallPoint3 = Random.Range(1,5); 
                
                Debug.Log ("Point1" + mBallPoint + "Point2" + mBallPoint2 + "Point3" + mBallPoint3);
                //if (mItemRandomNum != mItemRandomNum1 && mItemRandomNum1 != mItemRandomNum2 && mItemRandomNum2 != mItemRandomNum3 && mItemRandomNum3 != mItemRandomNum4 && mItemRandomNum4 != mItemRandomNum)
                if (mBallPoint != mBallPoint2 && mBallPoint2 != mBallPoint3 && mBallPoint3 != mBallPoint) {
                    //if (!Ag.mBallEventAlready) mBallPoint = 0;
                
                    break;
                }
            }
        }
    }
    //-------------------------------------------------------------------------------
    void mgoldenBalleff() {
        
      if ( Ag.mgIsKick) {
            if(Ag.mgSkill == 1) {
                DestroyObject(mDirUpclone1);
            }
            if(Ag.mgSkill == 2){
                mDirUpclone1.animation.Play("SkilleffPer");
                DestroyObject(mDirUpclone1,4f);
            }
            if(Ag.mgEnemSkill == 1) {
                DestroyObject(mDirUpclone4);
                DestroyObject(mDirUpclone5);
            }
            if(Ag.mgEnemSkill == 2) {
                mDirUpclone4.animation.Play("SkilleffPer");
                mDirUpclone5.animation.Play("SkilleffPer");
                DestroyObject(mDirUpclone4,4f);
                DestroyObject(mDirUpclone5,4f);
            }
            } else {
            
            if(Ag.mgSkill == 1) {
                DestroyObject(mDirUpclone2);
                DestroyObject(mDirUpclone3);
            }
            if(Ag.mgSkill == 2){
                mDirUpclone2.animation.Play("SkilleffPer");
                mDirUpclone3.animation.Play("SkilleffPer");
                DestroyObject(mDirUpclone2,4f);
                DestroyObject(mDirUpclone3,4f);
            }
            if(Ag.mgEnemSkill == 1) {
                DestroyObject(mDirUpclone6);
            }
            if(Ag.mgEnemSkill == 2) {
                mDirUpclone6.animation.Play("SkilleffPer");
                DestroyObject(mDirUpclone6,4f);
            }
         }
    }
    
    //-------------------------------------------------------------------------------
    void ResultShow() {
            
            if (ItemBonus) {
                if (mItemBonus <= 0)  {ItemBonus = false; WinBonus = true;  mItemBonusObj.GetComponent<TextMesh>().text = mAllUsePoint.ToString(); mItemBonusObj.animation.Play();}
                else {if (mAllUsePoint != mItemBonus) {mAllUsePoint++;  mItemBonusObj.GetComponent<TextMesh>().text = mAllUsePoint.ToString(); } if (mAllUsePoint == mItemBonus) {mAllUsePoint = 0; ItemBonus = false; WinBonus = true; ; mItemBonusObj.animation.Play();} }
                
            } else if (WinBonus) {
                if (mWinBonus <= 0)  {WinBonus = false; BonusCoin = true;  mWinBonusObj.GetComponent<TextMesh>().text = mAllUsePoint.ToString(); mWinBonusObj.animation.Play(); }
                else {if (mAllUsePoint != mWinBonus) {mAllUsePoint++;  mWinBonusObj.GetComponent<TextMesh>().text = mAllUsePoint.ToString();} if (mAllUsePoint == mWinBonus) {mAllUsePoint = 0; WinBonus = false; BonusCoin = true;  mWinBonusObj.animation.Play();} }
                
            } else if (BonusCoin) {
                if (mBonusCoin <= 0) {BonusCoin = false; mMissPenalty = true; mBonusCoinObj.GetComponent<TextMesh>().text = mAllUsePoint.ToString(); mBonusCoinObj.animation.Play();}
                else {if (mAllUsePoint != mBonusCoin) {mAllUsePoint++;  mBonusCoinObj.GetComponent<TextMesh>().text = mAllUsePoint.ToString(); } if (mAllUsePoint == mBonusCoin) {mAllUsePoint = 0; BonusCoin = false; mMissPenalty = true; mBonusCoinObj.animation.Play(); }}
                
            } else if (mMissPenalty) {
                if (mMissNum >= 0)  {if (mAllUsePoint != mMissNum) { mMissPenaltyObj.GetComponent<TextMesh>().text = mMissNum.ToString();} if (mAllUsePoint == mMissNum) {mAllUsePoint = 0; mMissPenalty = false; WinPoint = true;  mMissPenaltyObj.animation.Play();} }
                else  {if (mAllUsePoint != mMissNum) {mAllUsePoint--; mMissPenaltyObj.GetComponent<TextMesh>().text = mMissNum.ToString();} if (mAllUsePoint == mMissNum) {mAllUsePoint = 0; mMissPenalty = false; WinPoint = true;  mMissPenaltyObj.animation.Play(); }}
                
            } else if (WinPoint) {
                if (mWinpoint <= 0)  {if (mAllUsePoint != mWinpoint) {mAllUsePoint--; mWinPointObj.GetComponent<TextMesh>().text = mAllUsePoint.ToString();} if (mAllUsePoint == mWinpoint) {mAllUsePoint = 0; WinPoint = false; AllPoint1 = true; mWinPointObj.animation.Play();} }
                else  {if (mAllUsePoint != mWinpoint) {mAllUsePoint++; mWinPointObj.GetComponent<TextMesh>().text = mAllUsePoint.ToString();} if (mAllUsePoint == mWinpoint) {mAllUsePoint = 0; WinPoint = false; AllPoint1 = true; mWinPointObj.animation.Play(); }}
                
            } else if (AllPoint1) {
                if (mWinpoint <= 0) {if (mAllPoint != Ag.mgPrevScore) {Ag.mgPrevScore--;  } if (mAllPoint == Ag.mgPrevScore) {AllPoint1 = false; mAllpointObj.animation.Play();}}
                else  {if (mAllPoint != Ag.mgPrevScore){ Ag.mgPrevScore++;  } if (mAllPoint == Ag.mgPrevScore) { AllPoint1 = false; mAllpointObj.animation.Play();} }
                mAllpointObj.GetComponent<TextMesh>().text = Ag.mgPrevScore.ToString();
            } 
    }
    
    //------------------------------------------------------------------------------------------
    void AppointItemBall () {
       // if (Ag.mgIsKick && (mBallPoint == Ag.mgDirection || mBallPoint2 == Ag.mgDirection || mBallPoint3 == Ag.mgDirection) ) {
            Debug.Log (" BallNum " + mBallPoint.ToString() + " DirNum "+ Ag.mgDirection);
            //mRndBoxpng = (Texture2D)Resources.Load ("TestItem/randombox12");
            
            
            if (Ag.mgIsKick && mPlayerNum2 < 7) {
                //Ag.mBallEventAlready = false;
            Debug.Log (">>>>>>>>>>>>>>>>>>>>>>CurPlayerUNo1>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mPlayerNum2);
                
                if ((mBallPoint == Ag.mgDirection || mBallPoint2 == Ag.mgDirection ) && Ag.mgDirection == 1 && Ag.mgSkill != 0) { /*mParticle1.GetComponent<ParticleSystem>().Play(); mBallItem1.renderer.enabled = false; ItemRun1(); */}
                else if ((mBallPoint == Ag.mgDirection || mBallPoint2 == Ag.mgDirection ) && Ag.mgDirection == 2 && Ag.mgSkill != 0) {/* mParticle2.GetComponent<ParticleSystem>().Play();  mBallItem2.renderer.enabled = false; ItemRun1(); */}
                else if ((mBallPoint == Ag.mgDirection || mBallPoint2 == Ag.mgDirection ) && Ag.mgDirection == 3 && Ag.mgSkill != 0) {/* mParticle3.GetComponent<ParticleSystem>().Play();  mBallItem3.renderer.enabled = false; ItemRun1(); */}
                else if ((mBallPoint == Ag.mgDirection || mBallPoint2 == Ag.mgDirection ) && Ag.mgDirection == 4 && Ag.mgSkill != 0) {/* mParticle4.GetComponent<ParticleSystem>().Play();  mBallItem4.renderer.enabled = false; ItemRun1(); */}
                
            }
            if (Ag.mgIsKick && (mPlayerNum2 > 6 && mPlayerNum2 < 9 )){
                //Ag.mBallEventAlready = false;
                //mEventBallAlready = false;
            Debug.Log (">>>>>>>>>>>>>>>>>>>>>>CurPlayerUNo2>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mPlayerNum2);
                if ((mBallPoint == Ag.mgDirection || mBallPoint2 == Ag.mgDirection || mBallPoint3 == Ag.mgDirection) && Ag.mgDirection == 1 && Ag.mgSkill != 0) {/* mParticle1.GetComponent<ParticleSystem>().Play(); mBallItem1.renderer.enabled = false;  ItemRun1(); */}
                else if ((mBallPoint == Ag.mgDirection || mBallPoint2 == Ag.mgDirection || mBallPoint3 == Ag.mgDirection) && Ag.mgDirection == 2 && Ag.mgSkill != 0) {/* mParticle2.GetComponent<ParticleSystem>().Play(); mBallItem2.renderer.enabled = false; ItemRun1(); */}
                else if ((mBallPoint == Ag.mgDirection || mBallPoint2 == Ag.mgDirection || mBallPoint3 == Ag.mgDirection) && Ag.mgDirection == 3 && Ag.mgSkill != 0) {/* mParticle3.GetComponent<ParticleSystem>().Play(); mBallItem3.renderer.enabled = false;  ItemRun1(); */}
                else if ((mBallPoint == Ag.mgDirection || mBallPoint2 == Ag.mgDirection || mBallPoint3 == Ag.mgDirection) && Ag.mgDirection == 4 && Ag.mgSkill != 0) {/* mParticle4.GetComponent<ParticleSystem>().Play(); mBallItem4.renderer.enabled = false;  ItemRun1();*/ }
            }
            
            
      //  }
    }
    
    //----------------------------------------------------------------------------------------------
    void LastResult() {
     if(Ag.mgDidWin) {
         GameObject.Find("ResultCamera/ResultWin/Background").GetComponent<UISprite>().spriteName ="YOUWIN";
     } else {
         GameObject.Find("ResultCamera/ResultWin/Background").GetComponent<UISprite>().spriteName ="YOULOSE";
     }
    }
    
    IEnumerator GetEventBall(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        Debug.Log ("GetEventBall Start>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        AppointItemBall();
        
    }
    
    
    //-------------------------------------------------------------------------------
    
    
    void ItemBox1() {
        if (Ag.mgIsKick){
            Ag.mBallEventAlready = true;
            MkballActive(false);
            mEventItemShowTime = true;
            //mEventBallAlready = true;
            GameObject mDirUPclone;
                if (mItemRandomNum < 20.1) { if(!Ag.mSingleMode) {Ag.mIapPrice += 3; mItemBonus += 3; ItemMainTexturechange("3coin 1");} else {Ag.mIapPrice += 2; mItemBonus += 2; ItemMainTexturechange("2coin");} MiniEffectPlay(2);  Ag.mBallEventAlready = false; SoundManager.Instance.Play_Effect_Sound("fixcoin01");} 
                else if (20.0f < mItemRandomNum  &&  mItemRandomNum < 42.6f) { mEventPotion = true; ItemMainTexturechange("accup2"); MiniEffectPlay(1); mItemflag1 = true; Ag.mBallEventAlready = true; SoundManager.Instance.Play_Effect_Sound("skillboom");}
                else if (42.5f < mItemRandomNum  &&  mItemRandomNum < 44.6f) { mEventminusPotion = true; ItemMainTexturechange("accdown2"); MiniEffectPlay(1); mItemflag1 = true; Ag.mBallEventAlready = true; SoundManager.Instance.Play_Effect_Sound("skillboom");}
                else if (44.5f < mItemRandomNum  &&  mItemRandomNum < 67.1f) { mDidEventPotion = true; ItemMainTexturechange("direcup3"); MiniEffectPlay(1); mItemflag1 = true; Ag.mBallEventAlready = true; SoundManager.Instance.Play_Effect_Sound("skillboom");} 
                else if (67.0f < mItemRandomNum  &&  mItemRandomNum < 69.1f) { mDirMinuspotion = true; ItemMainTexturechange("directdown3"); MiniEffectPlay(1); mItemflag1 = true; Ag.mBallEventAlready = true; SoundManager.Instance.Play_Effect_Sound("skillboom");} 
                else if (69.0f < mItemRandomNum  &&  mItemRandomNum < 86.6f) { mSlowEff = true;  ItemMainTexturechange("slowpin"); MiniEffectPlay(1); mItemflag1 = true; Ag.mBallEventAlready = true; SoundManager.Instance.Play_Effect_Sound("skillboom");}
                else if (86.5f < mItemRandomNum  &&  mItemRandomNum < 87.1f) { ItemMainTexturechange("15"); mGoldenBall = true; MiniEffectPlay(1); mItemflag1 = true; Ag.mBallEventAlready = true; SoundManager.Instance.Play_Effect_Sound("skillboom");}
                else if (87.0f < mItemRandomNum  &&  mItemRandomNum < 89.6f) { ItemMainTexturechange("16"); mSilverBall = true; MiniEffectPlay(1); mItemflag1 = true; Ag.mBallEventAlready = true; SoundManager.Instance.Play_Effect_Sound("skillboom");}
                else if (89.5f < mItemRandomNum  &&  mItemRandomNum < 97.1f) { ItemMainTexturechange("17"); mBronzeBall = true; MiniEffectPlay(1); mItemflag1 = true; Ag.mBallEventAlready = true; SoundManager.Instance.Play_Effect_Sound("skillboom");}
                else { Ag.mIapPrice += 1; mItemBonus += 1; ItemMainTexturechange("1coin 1"); MiniEffectPlay(2); Ag.mBallEventAlready = false; SoundManager.Instance.Play_Effect_Sound("fixcoin01");}
            }
    }
    
    
    
    void GameObjectRndBox(bool pFlag) {
        //mBallItem1.SetActive(pFlag); 
        //mBallItem2.SetActive(pFlag); 
        //mBallItem3.SetActive(pFlag); 
        //mBallItem4.SetActive(pFlag); 
    }
    
    void mEventBallActive(string pballnum ,string pballnum2,string pballnum3 , bool ballFlag) { // Random Ball appoint
        Debug.Log ("Point1" + pballnum + "Point2" + pballnum2 + "Point3" + pballnum3);
        
        //mGameObj2.SetActive(true);
        //int mPlayerNum2;
        if (Ag.mgIsKick) mPlayerNum2 = Ag.mySelf.mCurPlayer.mPlayerUNO;
        
        if (Ag.mgIsKick && mPlayerNum2 < 7 ) {
             
            
            Debug.Log (">>>>>>>>>>>>>>>>>>>>>>CurPlayerUNo>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mPlayerNum2);
            if (pballnum == "1" || pballnum2 == "1" ) { /*mBallItem1.SetActive(ballFlag); mBallItem1.renderer.enabled = ballFlag; */}
            if (pballnum == "2" || pballnum2 == "2" ) { /*mBallItem2.SetActive(ballFlag); mBallItem2.renderer.enabled = ballFlag; */}
            if (pballnum == "3" || pballnum2 == "3" ) { /*mBallItem3.SetActive(ballFlag); mBallItem3.renderer.enabled = ballFlag; */}
            if (pballnum == "4" || pballnum2 == "4" ) { /*mBallItem4.SetActive(ballFlag); mBallItem4.renderer.enabled = ballFlag; */}
           
        } 
        if (Ag.mgIsKick && (mPlayerNum2 > 6 && mPlayerNum2 < 9 )){
            
            
            Debug.Log (">>>>>>>>>>>>>>>>>>>>>>CurPlayerUNo2>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"+mPlayerNum2);
            if (pballnum == "1" || pballnum2 == "1" || pballnum3 == "1") { /*mBallItem1.SetActive(ballFlag); mBallItem1.renderer.enabled = ballFlag; */}
            if (pballnum == "2" || pballnum2 == "2" || pballnum3 == "2") { /*mBallItem2.SetActive(ballFlag); mBallItem2.renderer.enabled = ballFlag; */}
            if (pballnum == "3" || pballnum2 == "3" || pballnum3 == "3") { /*mBallItem3.SetActive(ballFlag); mBallItem3.renderer.enabled = ballFlag; */}
            if (pballnum == "4" || pballnum2 == "4" || pballnum3 == "4") { /*mBallItem4.SetActive(ballFlag); mBallItem4.renderer.enabled = ballFlag; */}
            
        }
    }
    void MiniItemRndBox () {
        
        mMiniItem.SetActiveRecursively(true);
        MiniRandomItemAniPlay(mRoundAni);
        mRndBoxpng = (Texture2D)Resources.Load ("TestItem/randombox12");
        mMiniItem.transform.renderer.material.mainTexture = mRndBoxpng;
        
    }
    

}
