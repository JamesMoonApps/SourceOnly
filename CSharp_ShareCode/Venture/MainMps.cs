using UnityEngine;
using System.Collections;

public class MainMps : AmSceneBase {

    //HtVentureMan mMan = new HtVentureMan();
    StateArray arrStt = new StateArray ();

    HmFriend mForm, mLatt;
    HmGod mGod;

    public delegate void StateChanged(string pStt);
    public StateChanged delStateChg;

    HtManager mMan = new HtManager();


    //  ////////////////////////////////////////////////     Starting Init Job
    public override void Start ()
    {
        mTimeLooseAtStartPoint = 0.1f; // Second
        mSeldomActionNum = 500;
        SetState ();
        base.Start ();
        muiActive = true;
        
        Ag.Init();
    }
    
    public override void BaseStartSetting () // called from Start.. After Time Loose
    {
        base.BaseStartSetting ();
        
        //Ag.LogIntenseWord("Set column 3 10");
        myGUI.SetColumns(3, 10);

    }
    
    void SetState ()
    {
        // Process of One Operation .. So it has mForm, mLatt, mGod..

        arrStt.AddAMember ("Init", 2f);
        arrStt.AddEntryAction (() => {
            Ag.LogString (" Init state ");
            mMan.SetOperation(12, 21, Godirum.PLU);
        });
        
        arrStt.AddAMember ("Create", 3f);
        arrStt.AddEntryAction (() => {

        });

        /*
        arrStt.AddAMember ("FormerIntro", 2f);
        arrStt.AddEntryAction (() => {
            mForm = mMan.GetFormer();
            mForm.IntroduceAction();
        });

        arrStt.AddAMember ("GodIntro", 2f);
        arrStt.AddEntryAction (() => {
            mGod = mMan.GetGod();
            mGod.IntroduceAction();
        });

        arrStt.AddAMember ("LatterIntro", 2f);
        arrStt.AddEntryAction (() => { 
            mLatt = mMan.GetLatter();
            mLatt.IntroduceAction();
        });

        // Freezing and 
        arrStt.AddAMember ("Freeze", 0.5f);
        arrStt.AddEntryAction (() => { 
            ;
        });
        */
        arrStt.AddAMember ("JinsimIntro", 3f);
        arrStt.AddEntryAction (() => { 
            mMan.CreateJinsim();
        });
        
        arrStt.AddAMember ("Split", 0.5f);
        arrStt.AddEntryAction (() => { });
        
        arrStt.AddAMember ("Transform", 0.5f); // Multi Case.. 
        arrStt.AddEntryAction (() => { });
        
        arrStt.AddAMember ("ObeyGod", 0.5f);
        arrStt.AddEntryAction (() => { });

        arrStt.AddAMember ("Result", 0.5f);
        arrStt.AddEntryAction (() => {
            mMan.DestroyJinsim();
        });
        
        arrStt.AddAMember ("OverLimit", 0.5f);
        arrStt.AddEntryAction (() => { });
        
        arrStt.AddAMember ("JinsimHide", 0.5f);
        arrStt.AddEntryAction (() => { });
        
        arrStt.AddAMember ("NewBorn", 0.5f);
        arrStt.AddEntryAction (() => { });
        
        arrStt.SetStateWithNameOf ("Init");
        arrStt.SetSerialExitMember ();

        arrStt.delStateChange += (string pStt ) => {

            mMan.SetState(pStt);

        };

    }
    public override void SetAsset ()
    {
        base.SetAsset ();
        

    }
    
 
    //  ////////////////////////////////////////////////     Update related
    public override void Update ()
    {
        base.Update ();

        arrStt.DoAction ();
    }
    
    //  ////////////////////////////////////////////////     OnGUI related
    public override void OnGUI ()
    {
        base.OnGUI ();
        
        muiCol = 0; muiRow = 0;
        
        if (myGUI == null) return;
        
        if (!muiActive) 
            return;
        
        if (GUI.Button (myGUI.GetRect (muiCol, muiRow++), " < Login Scene > ")) {
            //AgStt.muiHQ.DetachScene(this);
            Application.LoadLevel("Login");
        }
        
        if (GUI.Button (myGUI.GetRect (muiCol, muiRow++), " Login ")) {
        
        }
        
    }
}
