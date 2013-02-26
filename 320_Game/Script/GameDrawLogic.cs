using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class MainRpsMatch : MonoBehaviour {
    bool mPlayerinfoflag = false;

	void DrawGameDirection() {
        //Ag.LogString("mgIsKick "+ Ag.mgIsKick.ToString() );
        if (mStage.mIsTouched && Ag.mgIsKick) {
            //Ag.mgDirection = mCurPlayer.GetPosition( mStage.mCursorPosition);
            //zoomCameraFlag = true;
            mstatusBar = true;
            //SetKickerDir( true);
        }
        if ( !Ag.mgIsKick ) {   // Defence Case... Draw Buttons..
            // Draw Enemy's Info.
            // GUI.DrawTexture(new Rect(mSX * 0.3f, mSY * 0.6f ,mSX * 0.3f, mSY * 0.1f ), (Texture2D)arrListTxt[15], ScaleMode.StretchToFill, true);
         // Enemy Player Property Box
            // Wagu.... 
         
            
         if (mPlayerinfoflag) {
             if ((int)(Time.time* 5 )% 2  == 0 ) {mKickerInfoBar = (Texture2D)Resources.Load("500Game/UI/opponent1"); mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[1].shader =Shader.Find("Self-Illumin/Diffuse") ;
             mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[0].shader = Shader.Find("Self-Illumin/Diffuse");
             mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[2].shader = Shader.Find("Self-Illumin/Diffuse"); }
                
             else  {mKickerInfoBar = (Texture2D)Resources.Load("500Game/UI/opponent2"); mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[1].shader =Shader.Find("Bumped Diffuse") ;
             mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[0].shader = Shader.Find("Bumped Diffuse");
             mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[2].shader = Shader.Find("Bumped Diffuse"); }
                
             float waguX = mSX * mPlayerInfoX, waguY = mSY * 0.05f, waguWid = mSX * 0.32f, waguHei = mSY * 0.3f; 
             mWaguRec = new Rect( waguX, waguY, waguWid, waguHei );
             // Player Picture..  depend on Wagu Size, and Position...
             float picX = waguWid * 0.145f, picY = waguHei * 0.3f, picWid = waguWid * 0.2f, picHei = waguHei * 0.4f;
             mPicRec = new Rect( waguX+picX, waguY+picY, picWid, picHei );
             // Direction Bar
             float dirX = waguWid * 0.36f, dirY = waguHei * 0.59f, dirWid = waguWid * 0.51f, dirHei = waguHei * 0.13f;
             mDirRec = new Rect( waguX+dirX, waguY+dirY, dirWid, dirHei );
             //mEnemyBioRec = new Rect (waguX+dirX, waguY+picY, picWid, picHei * 0.45f );
             
             mEnemyBioRec = new Rect (dirX+waguX * 0.98f + picX + waguWid * 0.28f, waguHei * 0.61f, waguWid * 0.15f , waguHei * 0.15f); 
                
             if (mPlayerInfoX > 0.69f) mPlayerInfoX -= 0.01f;
             //mWaguRec = new Rect( mSX * 0.69f , mSY * 0.05f ,mSX * 0.32f, mSY * 0.3f);  
//            Debug.Log(mPlayerInfoX);
           }
            GUI.DrawTexture(mWaguRec,mKickerInfoBar , ScaleMode.StretchToFill, true); // Player Info Wagu...
            if (mCurEnem != null && mCurEnem.mPlayerPic != null)
            GUI.DrawTexture(mPicRec, mCurEnem.mPlayerPic, ScaleMode.StretchToFill, true); // Player Picture
            DrawSmallEnemyDirection();
            
            
         if (mKeeperSetDir) {
                //DrawDirectThumb();
            }
        } else {
            
            
            
            
            
            
         //float y1 = mSY * 0.873438f, y2 = mSY * 0.076563f;
            float y1 = mSY * 0.902438f, y2 = mSY * 0.073663f, xScale = 1f;
            
     
         //float staX = xScale * mSX * ( DrawXStart + DrawXWidth * (float) sta / 1000.0f );
         //float width = xScale * mSX * ( DrawXWidth * (float)  ) ;
         
         
         //GUI.DrawTexture(new Rect(mSX * DrawXStart - (mSX * 0.0067f), y1 - mSY * 0.01f, mSX * DrawXWidth  + (mSX * 0.0134f), y2 + mSY * 0.02f), (Texture2D)arrListTxt[5], ScaleMode.StretchToFill, true);
         
            //GUI.DrawTexture(new Rect(mSX * DrawXStart, mSY * DrawYStart - (mSY * 0.045f) ,mSX * 0.125f, mSY * 0.032774f ), (Texture2D)arrListTxt[15], ScaleMode.StretchToFill, true);
            int i, num = mCurPlayer.arrArea.Count;  // Ag.LogString("Direction Num >>" + num);
         
            for(i=0; i<num; i++) {
                int[] curVal = (int[]) mCurPlayer.arrArea[i];  // 3, 15, 50 < posi, sta, end >
                // Draw....
                int sta = curVal[1], end = curVal[2];
               
                //DrawOneBar( false, mCurPlayer.GetDirectionColor(  false, curVal[0] ) +1 , sta, end );
                DrawOneBar( false, curVal[0], sta, end );
                float staX = xScale * mSX * ( DrawXStart + DrawXWidth * (float) sta / 1000.0f );
                float width = xScale * mSX * ( DrawXWidth * (float) (end - sta) / 1000.0f ) ;
                //float y1 = mSY * 0.873438f, y2 = mSY * 0.076563f, xScale = 1f;
                float staEnd = staX + width;
                //arrGamedirBar[curVal[0]-1].transform.position = mDirbarPosSta;
                //MakePlane.CreatePlane5(new Vector3 (0.29f,62.7f,162f) , new Vector3 (mDirbarPosSta.x,mDirbarPosSta.y,162f), new Vector3 (mDirbarPosEnd.x,mDirbarPosEnd.y,162f));
            }
            //GUI.DrawTexture(new Rect(0.03f * mSX, mSY * 0.82f, 0.15f * mSX, mSY * 0.15f), 
            
            //DrawCapBar();
            
            DrawCursor();  // Draw Cursor..  Call......
        }
    }// Use this for initialization
    
    //--------------------------------------------------------------------------------
    
    void Defaultcloth () {
        mKickerInfoBar = (Texture2D)Resources.Load("500Game/UI/opponent2"); mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[1].shader =Shader.Find("Bumped Diffuse") ;
        mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[0].shader = Shader.Find("Bumped Diffuse");
        mPlayerKicker.transform.FindChild("shirt005").renderer.sharedMaterials[2].shader = Shader.Find("Bumped Diffuse");
    }
    
    
    void DrawGuideLine () {
        //mGuideBar = new List<GameObject>();
        dicGuideObjectPos = new Dictionary<int, float>();
        dicGuideObjectWidth = new Dictionary<int, float>();
        
        for (int j = 1 ; j < 5 ; j++ ) {
             dicGuideObjectPos.Add(j,mPos);
             dicGuideObjectWidth.Add(j,mWidth);
        }
        float y1 = mSY * 0.902438f, y2 = mSY * 0.073663f, xScale = 1f;
        int i, num = mCurPlayer.arrArea.Count;  // Ag.LogString("Direction Num >>" + num);
        for(i=0; i<num; i++) {
                int[] curVal = (int[]) mCurPlayer.arrArea[i];  // 3, 15, 50 < posi, sta, end >
                // Draw....
                int color = curVal[0];
                int sta = curVal[1], end = curVal[2];
               
            
                //DrawOneBar( false, mCurPlayer.GetDirectionColor(  false, curVal[0] ) +1 , sta, end );
                //DrawOneBar( false, curVal[0], sta, end );
                float staX = xScale * mSX * ( DrawXStart + DrawXWidth * (float) sta / 1000.0f );
                float width = xScale * mSX * ( DrawXWidth * (float) (end - sta) / 1000.0f ) ;
                //float y1 = mSY * 0.873438f, y2 = mSY * 0.076563f, xScale = 1f;
                float staEnd = staX + width;
            
                for(int k = 1 ; k< 5; k++) {
                    if ( k == color && dicGuideObjectPos[color] > staX)
                        dicGuideObjectPos[color] = staX;
                    if ( k == color && dicGuideObjectWidth[color] < staEnd) 
                        dicGuideObjectWidth[color] = staEnd;
                }
                //dicGuideObject.Add(color,Guidebar);
         }
    }
    
    void DrawGameSkill () {
        //Debug.Log ("Game Skill >>>>>>>>>>>>>>>>>   >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>   \n");
        //mStage.mCurPlayer.SetSkillPositions();
        
        //Ag.LogString(">>>> Current State   " + mStateArr.GetCurStateName() );
        
        string curStr = mStateArr.GetCurStateName();
        if (mCurPlayer.arrArea == null || mCurPlayer.arrArea.Count == 0) return;
        if (mStateArr.GetCurStateName() == "MidPaus") sclPotion = 0.4f;
        // Effect .....
        float curPosi = (float) mStage.GetCursorPosition();  // 0 ~ 1000
        float cenX = mSX * ( DrawXStart + DrawXWidth * (float) curPosi / 1000.0f ), cenY = mSY * 0.9f;
            
        float timeDiffer = Time.timeSinceLevelLoad - mStartTime;
        float iniW = mSX*0.1f, iniH = mSY*0.2f; // Initial Size
        float iniX = cenX - iniW*0.5f, iniY = cenY - iniH*0.5f;  // mSX*0.2f, iniY = mSY*0.4f;
        float delX = mSX*3f, delY = mSY*3f; // Effect Speed.
        
        
        
        
        
        //GUI.DrawTexture(new Rect(mSX * DrawXStart, mSY * DrawYStart - (mSY * 0.045f)  ,mSX * 0.125f, mSY * 0.032774f ), (Texture2D)arrListTxt[14], ScaleMode.StretchToFill, true);
        float mCursorWid = mSX * 0.04375f;
        //float y1 = mSY * 0.873438f, y2 = mSY * 0.076563f, xScale = 1f;
        float y1 = mSY * 0.902438f, y2 = mSY * 0.073663f, xScale = 1f;
         
         // //////////////////////////////////////////////////   Draw Skill Bars...
        int textIdx = Ag.mgIsKick? 9: 6;
         
        //GUI.DrawTexture(new Rect(mSX * DrawXStart - (mSX * 0.0067f), y1 - mSY * 0.01f, mSX * DrawXWidth  + (mSX * 0.0134f), y2 + mSY * 0.02f), (Texture2D)arrListTxt[5], ScaleMode.StretchToFill, true);
        GUI.DrawTexture(new Rect(mSX * DrawXStart , y1, mSX * DrawXWidth , y2), (Texture2D)arrListTxt[textIdx], ScaleMode.StretchToFill, true);
        DrawOneBar ( false, textIdx+1, (int)(300 - mCurPlayer.mGood *0.5), (int)(300 + mCurPlayer.mGood*0.5) );
        
        
        
        //if ((Ag.mgIsKick && Ag.mySelf.IsPerfectOn()) || !Ag.mgIsKick ) 
        DrawOneBar ( false, textIdx+2, (int)(300 - mCurPlayer.mPerfect *0.5 * sclPotion), (int)(300 + mCurPlayer.mPerfect*0.5 * sclPotion ) );
    
     /*} else {
            DrawOneBar ( false, 7, (int)(300 - mCurPlayer.mGood*0.5), (int)(300 + mCurPlayer.mGood*0.5) );
            DrawOneBar ( false, 8, (int)(300 - mCurPlayer.mPerfect *0.5), (int)(300 + mCurPlayer.mPerfect*0.5) );
        }   //*/
        
           
        if (mStage.mIsTouched) {
            //Ag.mgSkill = mCurPlayer.GetPosition( mStage.mCursorPosition );
            //mStatusSillBar = true; ljk 11/20
            
            mEffPosi.Set(  iniX - timeDiffer * delX, iniY - timeDiffer * delY );
            mEffPosiGood.Set ( iniX - timeDiffer * delX * 0.5f, iniY - timeDiffer * delY * 0.5f );
            mEffSize.Set( iniW + timeDiffer * delX * 2f, iniH + timeDiffer * delY * 2f );
            
            //------------------------------Effect
            if ( timeDiffer < 0.2 && Ag.mgSkill == 2 ){     //  Perfect
             //Debug.Log ("mEffect");
                GUI.DrawTexture( new Rect (mEffPosi.x, mEffPosi.y, mEffSize.x, mEffSize.y), mEffect, ScaleMode.StretchToFill, true);
            }
         
         
            if ( timeDiffer < 0.2 && Ag.mgSkill == 1 ){     //  Good 
                //Debug.Log ("mEffect");
                GUI.DrawTexture( new Rect (mEffPosiGood.x, mEffPosiGood.y, mEffSize.x * 0.5f, mEffSize.y * 0.5f), mEffect2, ScaleMode.StretchToFill, true);
            }
            
            Texture2D theTex = mMissTxr;
            if (Ag.mgSkill == 1) theTex = mGoodTxr;
            if (Ag.mgSkill == 2) theTex = mPrftTxr;
            GUI.DrawTexture( new Rect (mSX*0.37f, mSY*0.8f, mSX*0.2f, mSY*0.067f ), theTex, ScaleMode.StretchToFill, true);
            
        }
        if (mStage.WillDrawCursor() ) DrawCursor();  // Draw Cursor..  Call......
    }
    
    
    void DrawOneBar( bool pIsEnemy, int curCol2, int sta, int end) {
        //float y1 = mSY * 0.873438f, y2 = mSY * 0.076563f, xScale = 1f;
        float y1 = mSY * 0.902438f, y2 = mSY * 0.073663f, xScale = 1f;
        float staX = xScale * mSX * ( DrawXStart + DrawXWidth * (float) sta / 1000.0f );
        float width = xScale * mSX * ( DrawXWidth * (float) (end - sta) / 1000.0f ) ;
        
     if (pIsEnemy) { 
         //
         staX = mDirRec.x + mDirRec.width * sta / 1000f;
         width = mDirRec.width * (end - sta) / 1000f;
         y2 = mDirRec.height;  
         GUI.DrawTexture(new Rect(staX, mDirRec.y, width, y2), (Texture2D)arrListTxt[curCol2], ScaleMode.StretchToFill, true);
            mCurEnem.SetBioRythmStateBar();
            GUI.DrawTexture(mEnemyBioRec, mCurEnem.mBioRythmStateBar , ScaleMode.StretchToFill, true);
     } else {
            //Debug.Log ("Curcol2                        !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + curCol2);
         GUI.DrawTexture(new Rect(staX, y1, width, y2), (Texture2D)arrListTxt[curCol2], ScaleMode.StretchToFill, true);
            
        }
        //Ag.LogNewLine(10);
        //Ag.LogString("DrawOneBar :: sta >> " + sta + ", end " + end + " << \n");
        //Ag.LogString("DrawOneBar :: Rect >> " + staX + ", " + y1 + " ,  Size >> " + width + ", " + y2 + " << \n");
        
        //GUI.DrawTexture(new Rect(staX, mSY *0.7f, width, mSY*0.2f), 
        
         
    }
    
    
    //  ////////////////////////////////////////////////     Game :: Direction of Enemy Showing...
    void DrawSmallEnemyDirection() {
        //mStage.mCurEnemy.SetDirPosition();
        if (mCurEnem == null || mCurEnem.arrArea == null) return;
        int i, num = mCurEnem.arrArea.Count;
        for(i=0; i<num; i++) {
            int[] curVal = (int[]) mCurEnem.arrArea[i];  // LR, UD, Start, End
            // Draw....
            int sta = curVal[1], end = curVal[2];
            DrawOneBar( true, curVal[0], sta, end );
            Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!keeper view Color               "+curVal[0]);
            
            //DrawOneBar( true, mCurEnem.GetDirectionColor(  false, curVal[0] +1 ), sta, end );
        }
        
    }
    
    
    //  ////////////////////////////////////////////////     Draw Moving Cursor 
    void DrawCursor(){
        float y1 = mSY * 0.902438f, y2 = mSY * 0.073663f, xScale = 1f;
        float curPosi;
        
        string stt = mStateArr.GetCurStateName();
        
        if (stt == "MidPausPotion" || stt == "MidPausBiggerPotion" || stt == "BeforeDirPotion" || stt == "MidPausBiggerGamdDir")
            curPosi = 0;
        else
            curPosi = mStage.GetCursorPosition();  // 0 ~ 1000
        
        if ( mStage.mIsTouched && !mSkillSound && 
            (/* ( stt == "GameDir" && Ag.mgDirection == 0 ) || */( stt == "GameSkl" && Ag.mgSkill == 0 ) )  ) {
            SoundManager.Instance.Play_Effect_Sound("Bad");
            mSkillSound = true;
        }
        
        if ( mStage.mIsTouched && !mSkillSound && ( stt == "GameDir" && Ag.mgDirection > 0 && Ag.mgDirection < 5 )) 
        {
            SoundManager.Instance.Play_Effect_Sound("SelectDirection");
            mSkillSound = true;
        }
        GUI.Label ( new Rect(100,100,200,100),curPosi.ToString()); 
        //GUI.Label ( mEnScr, mPreEnWin.ToString(), mGuiCur);
            
        
        //int mTextureNUM;
        float mCursorWid;
        float cordX = mSX * ( DrawXStart + DrawXWidth * (float) curPosi / 1000.0f );
        //if( mStage.WillDrawDirection() ){
        float cursorWid = 0.025f;  // 0.010417f;
        mCursorWid = mSX * cursorWid;
        cordX = mSX * ( (DrawXStart - 0.5f * cursorWid ) + DrawXWidth * (float) curPosi / 1000.0f );
        
        GUI.DrawTexture(new Rect(cordX , y1 - mSY * 0.02f , mCursorWid , y2 + mSY * 0.05f ), 
        (Texture2D)arrListTxt[36], ScaleMode.StretchToFill, true);
   }
    
    
    
    
   void DirectionDrag() {
        //int DragNum = 0;
        string[] Lcode = {"RU","LU","RD","LD"};
        string[] Rcode = {"RU","LU","RD","LD"};
        mDidDragStarted = false;
        // Distance..
        float distDrag = Mathf.Sqrt(Mathf.Pow(mVecInit.y - mVecFin.y, 2) + Mathf.Pow(mVecInit.x - mVecFin.x, 2) );
        if (distDrag < 0.05 * Ag.mgScrX || distDrag < 50 ) return;  // [2012:12:6:MOON] Swipe Distance
        
        Vector2 dirVec = mVecFin - mVecInit; int dirVal;
        // Right... 
        if ( dirVec.x > 0 ) {
            dirVal = (dirVec.y > 0) ? 1: 3;
        } else {
            dirVal = (dirVec.y > 0) ? 2: 4;
        }
        
        Ag.mgDirection = (byte)dirVal;
        //mDidDragStarted = false;
       
        if (DragNum < 1) {
            DragNum = dirVal;
            KickerViewMove (mKickerViewName[dirVal-1]);
        } if (DragNum != dirVal && DragNum > 0) {
            
            mCameraDefn.animation.Play(Lcode[DragNum-1]+"TO"+Rcode[dirVal-1]);
            DragNum = dirVal;
        }
        
        mStage.TouchProcess();
        SetPlayerDir2();
    }
    
    
    void KeeperDirectionDrag (int pNum) {
        //int DragNum = 0;
        string[] Lcode = {"RU","LU","RD","LD"};
        string[] Rcode = {"RU","LU","RD","LD"};
        
        if (DragNum < 1) {
            
            DragNum = pNum;
            KickerViewMove (mKickerViewName[pNum-1]);
        }
        if (DragNum != pNum && DragNum > 0) {
            
            
            
            mCameraDefn.animation.Play(Lcode[DragNum-1]+"TO"+Rcode[pNum-1]);
            DragNum = pNum;
        }
    }
    
    
    string[] mKickerViewName = {"RightUpview","LeftUpview","RightDownView","leftDownView"};
    void KickerViewMove (string pName) {
        mCameraDefn.animation.Play(pName);
    }
}
