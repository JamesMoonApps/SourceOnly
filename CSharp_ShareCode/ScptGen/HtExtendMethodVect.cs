using UnityEngine;
using System.Collections;

public static class HtExtendMethodVect
{
	public static void MoveBack(this Transform pTarget, float pVal)
	{
		pTarget.position = new Vector3(pTarget.position.x, pTarget.position.y, pTarget.position.z + pVal);
	}
	
	public static Vector3 GetApplyVect3(this Transform pTarget, Vector3 pVect)
	{
		return pTarget.position = pTarget.position + pVect;
	}
	
	
	public static void ApplyVect3(this Transform pTarget, Vector3 pVect)
	{
		pTarget.position = pTarget.position + pVect;
	}

    public static Vector3 Freeze(this Vector3 pTarget)
    {
        return pTarget;
    }    
	
	public static void MoveXY(this Transform pTarget, float pDisp, bool pIsVertical) 
	{
		Vector3 camCo = pTarget.position;
		if (pIsVertical)
			camCo.y += pDisp;
		else
			camCo.x += pDisp;
		pTarget.position = camCo;
	}    
	
	public static float DiffenceXY(this GameObject pFrom, GameObject pTopo, bool pIsVertical)
	{
		return pFrom.transform.position.DiffenceXY(pTopo.transform.position, pIsVertical);
	}
	
	public static float DiffenceXY(this Vector3 pFrom, Vector3 pTopo, bool pIsVertical)
	{
		if (pIsVertical)
			return pTopo.y - pFrom.y;
		else
			return pTopo.x - pFrom.x;
	}
	
	public static float DistanceXY(this GameObject pFrom, GameObject pTopo, bool pIsVertical)
	{
		return pFrom.transform.position.DistanceXY(pTopo.transform.position, pIsVertical);
	}
	
	public static float DistanceXY(this Vector3 pFrom, Vector3 pTopo, bool pIsVertical)
	{
		if (pIsVertical)
			return Mathf.Abs(pTopo.y - pFrom.y);
		else
			return Mathf.Abs(pTopo.x - pFrom.x);
	}
	
	public static float Distance3D(this Vector3 pFrom, Vector3 pTopo)
	{
		return Mathf.Sqrt(Mathf.Abs(pTopo.x - pFrom.x) + Mathf.Abs(pTopo.y - pFrom.y) + Mathf.Abs(pTopo.z - pFrom.z));
	}
	
	
	public static float CurrentPosition(this GameObject pObj, bool pIsVertical)
	{
		return pObj.transform.position.CurrentPosition(pIsVertical);
	}
	
	public static float CurrentPosition(this Vector3 pVec, bool pIsVertical)
	{
		if (pIsVertical)
			return pVec.y;
		return pVec.x;
	}
	
	public static void OffsetFront(this Transform pTrans, float pValue)
	{
		Vector3 cur = pTrans.position;
		("Current z  " + cur.z).HtLog();
		pTrans.position = new Vector3(cur.x, cur.y, cur.z - pValue);
	}
	
	public static Vector3 Move(this Vector3 pVec, bool pIsVertical, float pDist)
	{
		if (pIsVertical)
			return new Vector3(pVec.x, pVec.y + pDist, pVec.z);
		return new Vector3(pVec.x + pDist, pVec.y, pVec.z);
	}
	
	public static float AddXYZ(this Vector3 pObj) // Calculate Scale Size...
	{
		return pObj.x + pObj.y + pObj.z;
	}
	
	public static Vector3 Vect3(this Vector2 pObj, float pZ = 0)
	{
		return new Vector3(pObj.x, pObj.y, pZ);
	}
	
	public static Vector2 Vect2(this Vector3 pObj)
	{
		return new Vector2(pObj.x, pObj.y);
	}
	
	public static Vector3 IntDivide(this Vector3 pFrObj, Vector3 pToObj, float pFr, float pTo) 
	{
		//("x " + (pFr * pFrObj.x + pTo * pToObj.x) / (pFr + pTo) + " , Y scale  " + (pFr * pFrObj.y + pTo * pToObj.y) / (pFr + pTo)).HtLog();
		return new Vector3( (pFr * pFrObj.x + pTo * pToObj.x) / (pFr + pTo), 
		                   (pFr * pFrObj.y + pTo * pToObj.y) / (pFr + pTo), 
		                   (pFr * pFrObj.z + pTo * pToObj.z) / (pFr + pTo) );
	}
	
	public static Vector3 IntDivideXY(this Vector3 pFrObj, Vector3 pToObj, float pFr, float pTo) 
	{
		//("x " + (pFr * pFrObj.x + pTo * pToObj.x) / (pFr + pTo) + " , Y scale  " + (pFr * pFrObj.y + pTo * pToObj.y) / (pFr + pTo)).HtLog();
		return new Vector3( (pFr * pFrObj.x + pTo * pToObj.x) / (pFr + pTo), 
		                   (pFr * pFrObj.y + pTo * pToObj.y) / (pFr + pTo),      pFrObj.z );
	}
	
	
	
	public static Vector2 IntDivide(this Vector2 pFrObj, Vector2 pToObj, float pFr, float pTo) 
	{
		//("x " + (pFr * pFrObj.x + pTo * pToObj.x) / (pFr + pTo) + " , Y scale  " + (pFr * pFrObj.y + pTo * pToObj.y) / (pFr + pTo)).HtLog();
		return new Vector2( (pFr * pFrObj.x + pTo * pToObj.x) / (pFr + pTo), (pFr * pFrObj.y + pTo * pToObj.y) / (pFr + pTo) );
	}
	
	public static float IntDivide(this float pFromVal, float pToVal, float pFr, float pTo)
	{
		if (pFr + pTo == 0)
			return 0;
		return (pFr * pFromVal + pTo * pToVal) / (pFr + pTo);
	}
}