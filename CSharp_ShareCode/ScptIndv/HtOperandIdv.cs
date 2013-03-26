using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class HtOperandIdv : HtIndvBase {
    
    public AudioSource mIntroSound;
    public Fff myFff;
    
    // Use this for initialization
    public override void Start () {
        
    }
    
    // Update is called once per frame
    public override void Update () {
        
    }
    
    public void IntroduceAction()
    {
        if (mIntroSound != null)
            mIntroSound.Play ();
        // myFff = ONEY ...
        
        mIntroSound = (AudioSource)Resources.Load ("Com/Friends/Sound" + myFff.ToString () + "_Intro"); 
        
    }
    
    
}
