using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

public class EfctBaseClass : MonoBehaviour {
	
	int mCounter = 0, mSeldomActionNum = 200;

	int mLimit;

	~EfctBaseClass() {
		//Ag.LogIntenseWord("  >> Delete of AmSceneBase Object <<  ");
	}
	
	//  ////////////////////////////////////////////////     Starting Init Job
	public virtual void Start () {
		SetAsset();
		StartCoroutine("Wait");
	}
	
	public IEnumerator Wait() {
		; //Ag.LogString("   AmSceneBase :: Wait for " + mTimeLooseAtStartPoint + " sec ");
		yield return new WaitForSeconds(0.1f);
		; //Ag.LogString("   AmSceneBase :: Wait for " + mTimeLooseAtStartPoint + " sec   !!!  D O N E  !!!");
		BaseStartSetting();
	}
	
	public virtual void OnDisable() {
		AgStt.muiHQ.DetachScene(this);
	}
	
	public virtual void BaseStartSetting() {
		Ag.LogString( "   AmSceneBase::BaseStartSetting  Part of >>>>>  " + GetType().ToString() + "   <<<<<");

	}
	
	public virtual void OnApplicationQuit() {
		Ag.LogString ("   AmSceneBase :: OnApplicationQuit");

	}
	
	public virtual void SetAsset() 
	{
	}


	//  ////////////////////////////////////////////////     ////////////////////////     >>>>>  Update related  <<<<<
	public virtual void Update () {
		mCounter++;
		if ((mCounter % mSeldomActionNum) == 0)
			SeldomAction();
	}
	
	public virtual void SeldomAction() {

	}
	
	//  ////////////////////////////////////////////////     OnGUI related
	public virtual void OnGUI() {
	}
	

}
