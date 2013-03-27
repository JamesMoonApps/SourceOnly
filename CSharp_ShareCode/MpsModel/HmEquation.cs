using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;


//  ////////////////////////////////////////////////     ////////////////////////     >>>>> Equation  ........ <<<<<
public class HmEquation : MpsModel
{

    // Item can be an Equation also...
    List<MpsModel> arrItem  = new List<MpsModel>(); // 23 + 43 * 2 ... 

    public override void SetState (string pStt)
    {
        base.SetState (pStt);
        foreach (MpsModel obj in arrItem) {
            obj.SetState(pStt);
        }
    }

    public bool CheckValidItemList()
    {
        int num = arrItem.Count;
        if (num == 0)
            return false;
        
        return true;
    }
    
    public HmFriend GetFormer()
    {
        return (HmFriend) arrItem [0];
    }
    public HmFriend GetLatter()
    {
        return (HmFriend) arrItem [2];
    }
    
    public HmGod GetGod()
    {
        return (HmGod) arrItem [1];
    }


    //  ////////////////////////////////////////////////    Simple Sub Methods ...

    public void AddSimpleOperation (int pF, int pL, Godirum pGod)  // 35 78 Plus ...
    {
        Ag.LogIntense (3, true);
        (" HmEquation :: AddSimpleOperation  " + pF + "  " + pGod.ToString () + "  " + pL).HtLog ();
        SetItemInt (pF, new Vector3(-7, 0, 0) );
        SetGod (pGod, new Vector3 (0, 0, 0));
        SetItemInt (pL, new Vector3 (7, 0, 0));
        (" HmEquation :: AddSimpleOperation  ___________ End ").HtLog();
        Ag.LogIntense (3, false);
    }



    public void SetItemInt(int pVal, Vector3 pAe)  // 35
    {
        HmEquation nObj = new HmEquation ();
        arrItem.Add (nObj);
        
        int jari = pVal.Jarisoo ();
        (" HmEquation :: SetItemInt   >> jari = " + jari).HtLog ();
        
        for (int k=0; k<jari; k++) {
            HmFriend obj = new HmFriend(pVal.NthNum(k), new Vector3(pAe.x + k * Cns.mgWidthOfFriend, pAe.y, pAe.z) );
            (" HmEquation :: SetItemInt  >>>>  Add Unit Number   " + obj.mName).HtLog();
            nObj.arrItem.Add(obj);
        }
    }
    
    public void SetItemEqua()
    {
    }
    
    public void SetGod( Godirum pIrum, Vector3 pAe )
    {
        HmGod nObj = new HmGod (pIrum);
        arrItem.Add (nObj);
    }

    public override void CreateJinsim()
    {
        foreach (MpsModel item in arrItem) {
            item.CreateJinsim();
        }
    }

    public override void  DestroyJinsim()
    {
        foreach (MpsModel mpsObj in arrItem) {
            mpsObj.DestroyJinsim();
        }

    }
    
}
