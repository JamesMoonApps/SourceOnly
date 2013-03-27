using UnityEngine;
using System.Collections;

public static class HmExtendMethods 
{
    
    public static int Jarisoo(this int pVal)
    {
        return (int)( Mathf.Log10 (pVal) + 1 );
    }
    
    public static int NthNum(this int pVal, int pNth)
    {
        string str = pVal.ToString ();  // ex) pVal = 234, pNth = 2
        if (str.Length - 1 < pNth)  // 3-1 < 3 case..
            return -1; // Error..
        return int.Parse (str.Substring (pNth, 1));
    }

}