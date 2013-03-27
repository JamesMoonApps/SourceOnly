using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;





//  ////////////////////////////////////////////////     ////////////////////////     >>>>>  Resource Load Manager  <<<<<
public class Cns
{
    public static float mgWidthOfFriend = 3.1f;




    public static List<List<Vector3>> arrJinsimAe = new List<List<Vector3>>();

    public static void SetConstants()
    {
        List<Vector3> friendList = new List<Vector3> ();

        // Young
        arrJinsimAe.Add (friendList);

        // Oney
        friendList = new List<Vector3> ();
        friendList.Add (new Vector3 (0.00f, 0.00f, 0));
        arrJinsimAe.Add (friendList);

        // Twoer
        friendList = new List<Vector3> ();
        friendList.Add (new Vector3 (0.00f, -1.00f, 0));
        friendList.Add (new Vector3 (0.00f, 1.00f, 0));
        arrJinsimAe.Add (friendList);

        // Threen
        friendList = new List<Vector3> ();
        friendList.Add (new Vector3 (1, 3, 0));
        friendList.Add (new Vector3 (1, 3, 0));
        friendList.Add (new Vector3 (1, 3, 0));
        arrJinsimAe.Add (friendList);

    }


}
