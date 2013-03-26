using UnityEngine;
using System.Collections;

//  ////////////////////////////////////////////////     ////////////////////////     >>>>> String & Debug.... <<<<<
public static class HtExtendMethodStr
{
	
	
	
	
	public static void HtLog(this string pStr ) {
		if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.Android)
			Debug.Log ("LOG >> " + pStr + " \n");
		else
			//GeneralFunction.NativeLog("Ag.LogString  >>>>>>>>>>>>>>>>>>>> [ " + pStr + " ]");
			GeneralFunction.NativeLog("UNITY C# Log :: " + pStr );
	}
	
	//  ////////////////////////////////////////////////     4 Debugging ....
	public static void Show(this UiState pObj)
	{
		(" State ...... " + pObj.ToString() ).HtLog();
	}
	
	public static string Show(this Vector3 pVec)
	{
		return pVec.ToString();
	}
	
	public static string ShowPosi(this GameObject pObj)
	{
		return pObj.transform.position.Show();
	}
	
	public static string ShowPosi(this Transform pObj)
	{
		return pObj.position.Show();
	}
	
}
