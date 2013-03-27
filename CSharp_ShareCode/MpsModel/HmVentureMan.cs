using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;



public enum Venture
{
    NONE,
    ONE,
    TWO
}

public enum Godirum
{
    PLU,
    MIN,
    MUL,
    DIV
}


//  ////////////////////////////////////////////////     ////////////////////////     >>>>> Total Manager ........ <<<<<
public class HtManager 
{
    // One Equation ...
    public HmEquation mEq = new HmEquation();


    public string mState;

    public HtManager()
    {
        Cns.SetConstants ();
    }

    public void SetOperation(int pF, int pL, Godirum pGod)
    {
        mEq.AddSimpleOperation (pF, pL, pGod);
    }

    public void SetCreateCoordi()
    {

    }

    public HmFriend GetFormer()
    {
        return mEq.GetFormer ();
    }

    public HmFriend GetLatter()
    {
        return mEq.GetLatter ();
    }

    public HmGod GetGod()
    {
        return mEq.GetGod ();
    }



    public void SetState(string pStt)
    {
        //(" HmVentureMan  :: SetState    " + pStt + "        arrObjct.Count is  " + arrObject.Count).HtLog ();
        mState = pStt;
        mEq.SetState (pStt);
    }

    public void CreateJinsim()
    {
        mEq.CreateJinsim ();
    }

    public void DestroyJinsim()
    {
        mEq.DestroyJinsim ();
    }

}
