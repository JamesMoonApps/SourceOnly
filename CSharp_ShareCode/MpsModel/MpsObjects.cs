using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;


public enum Fff
{
    YOUNG,
    ONEY,
    TWOER,
    THREEN
}



//  ////////////////////////////////////////////////     ////////////////////////     >>>>> Model Class ........ <<<<<
public class MpsModel
{
    public string mName, mState;
    public GameObject mGobj;

    public Vector3 manInitAe;
    public Vector3 manDora;
    public HtRsrcMan mRsrcMan = new HtRsrcMan("Com");
    
    public virtual void SetState(string pStt)
    {
        mState = pStt;

        if (GetType().ToString() == "HmFriend") {
            (" HmVentureMan  :: SetState    " + "  Its Hm Friend  " + this.mName ).HtLog ();
            ((HmFriend)this).mGobj.GetComponent<HtFriendIdv>().SetState(pStt);
        }


    }
    
    public virtual void CreateJinsim()
    {
    }

    public virtual void DestroyJinsim()
    {
    }
}



//  ////////////////////////////////////////////////     Hm God..  + - 
public class HmGod : MpsModel
{
    public Godirum mIrum;
    
    public HmGod (Godirum pIrum)
    {
        mIrum = pIrum;
        
        // Create Position Setting...
        manInitAe = new Vector3 (0, 0, 0);
        manDora = new Vector3 (0, 0, 180);
        
        mRsrcMan.SetInstantComPrefab("God", this);
    }
    
    public void IntroduceAction()
    {
        mGobj.GetComponent<HtGod> ().IntroduceAction ();
    }
    
    public override void CreateJinsim()
    {
        base.CreateJinsim ();
    }
    
    
    
}

