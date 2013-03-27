using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;


struct SwitchingObj {
	
	public Vector3 mefOrigin, mefAltPosi;
	public bool mIsOrigin;
	
	public void SetOrigin(Vector3 pVect)
	{
		mefOrigin = pVect;
		mIsOrigin = true;
	}
	
	public void RandomSetting(float pX, float pY, float pZ)
	{
		float x = AgUtil.RandomInclude (1, (int)(pX * 100)) * 0.01f;
		float y = AgUtil.RandomInclude (1, (int)(pY * 100)) * 0.01f;
		float z = AgUtil.RandomInclude (1, (int)(pZ * 100)) * 0.01f;
		
		mefAltPosi = new Vector3 (x, y, z);
	}
	
	public Vector3 CurPosition()
	{
		mIsOrigin = !mIsOrigin; // Effect of Change Position..
		if (mIsOrigin)
			return mefOrigin;
		return mefAltPosi;
	}
}


//  ////////////////////////////////////////////////     ////////////////////////     >>>>>>>>>>     Effect Freeze     <<<<<<<<<<<<<<  
public class EfctFreeze : EfctBaseClass
{


	SwitchingObj mefSwitchPosi;

	int mLimit;

	//  ////////////////////////////////////////////////     Starting Init Job
	public override void Start ()
	{
		base.Start ();
		mSeldomActionNum = 5;

		mefSwitchPosi.SetOrigin (transform.position);
		mefSwitchPosi.RandomSetting (0.5f, 0.7f, 0.1f);
	}
	
	public override void BaseStartSetting ()
	{
		base.BaseStartSetting ();

	}
	
	string mBtnNum;
	
	//  ////////////////////////////////////////////////     Update related
	public override void Update ()
	{
		base.Update ();




		//foreach (Touch touch in Input.touches) {        }
	}

	public override void SeldomAction()
	{
		transform.position = mefSwitchPosi.CurPosition ();
	}
	
	//  ////////////////////////////////////////////////     OnGUI related
	public override void OnGUI ()
	{
		base.OnGUI ();

	}
}
