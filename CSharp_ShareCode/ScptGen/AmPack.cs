// [2013:1:14:MOON] Re boot 
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


//  ////////////////////////////////////////////////     ////////////////////////     >>>>>  Am PackUnit  <<<<<
public class AmPackUnit
{
    public enum Stage { READY, SENT, RECEIVED }
    public Stage mStage = Stage.READY;
    public ushort mPID { get; set; }
    public int mRcivID { get; set; }
    public byte[] mBuffer = new byte[0];
    public bool mIsSendOnly = false;
    
    // delegate members
    public delegate void ParseEach(AmPackUnit pPack);
    public ParseEach dlgtParseEach;
    //public FunctionPointer evtPars;
    
    // ready, sent
    public AmPackUnit() 
    {
    }
    
    public AmPackUnit(int pSize) 
    {
        mBuffer = new byte[pSize];
    }
    
    public void Sent() {
        mStage = Stage.SENT;
    }
    
    public void Received() {
        mStage = Stage.RECEIVED;
    }
    
    public void Parsing() {
        dlgtParseEach(this);
        Received();
    }
    
}


//  ////////////////////////////////////////////////     ////////////////////////     >>>>>  Am Pack  <<<<<
public class AmPack
{
    // Header
    public ushort wMark, wPID, wLen;
    public UInt64 uSocket;
    // Packet    public byte[] mBuffer;
    

    // Parsing
    public uint mPacketNoReceiveCounter = 0;
    protected int idx;    // Parsing Index.
    public byte mLength;   // Encoding String Length..
    
    // General
    public bool mIsSendOnly = false;
    public int mReceivePackID = 0;
    
    
    //  ////////////////////////////////////////////////     Creation ..
    public AmPack ()
    {
        Init ();
    }
    
 
 
    void Init ()
    {
        wMark = 0x1234;
        wLen = wPID = 0;   
        //uSocket = Ag.mgSocket;  
        idx = 0;
        //mBuffer = new byte[0];
    }
    
    public byte[] ConvertStringToByteArray (string str2)
    { 
        return (new System.Text.UTF8Encoding ()).GetBytes (str2); 
    }
    
    public byte[] MergeByte (byte[] pA, byte[] pB)
    {
        int na = pA.Length, nb = pB.Length;
        if (na == 0) {
            return pB;
        }
        byte[] rv = new byte[ pA.Length + pB.Length ];
        System.Buffer.BlockCopy (pA, 0, rv, 0, na);
        System.Buffer.BlockCopy (pB, 0, rv, na, nb);
        return rv;
    }
    
    
    //  ////////////////////////////////////////////////     ////////////////////////     >>>>>  4 Debugging..  <<<<<
    public void Mark___Log (bool pIsEncoding, string pMsg)
    {
        string str = "AmPack::Mark___Log";
        if (pIsEncoding)
            str += " >>>_ Send _<<< ";
        else
            str += " >>>_ Receive _<<< >>>_ ";
        //Debug.Log( str +  pMsg + " _<<<\n");
    }
    
    public void ShowEachByteOfPacket (bool IsSend, AmPackUnit pPack)
    {
        int ii, num;
        if (IsSend)
            num = pPack.mBuffer.Length;
        else
            num = wLen + 14;
        
        for (ii=0; ii<num; ii++) {
            //Debug.Log("Cur byte is:>>" + (byte)mSendBuff[ii] + " // " +  (char)mSendBuff[ii] + " << at " + ii + "\n"  );
            byte cur;
            if (IsSend)
                cur = pPack.mBuffer [ii];
            else
                cur = pPack.mBuffer [ii];
            string hexOutput = String.Format ("{0:X}", cur);
            //System.Text.Encoding.ASCIIEncoding.GetBytes(x.ToString());
            
            if (ii == 14)
                Ag.LogString("______________________________ Above are Header ______________________________");
            
            Debug.Log ("Cur byte is:>>0x " + hexOutput +  ", \t   at \t ____ " + ii + " \t ____  \t DEC : " + cur + " \t _____      \t" +  ((char)cur).ToString() );
        }
        Debug.Log ("______________________________ Total Length = " + num + "\n");
        
    }    
    
    public void ShowHeader (bool pIsSendCase, AmPackUnit thePack)
    {



    }

   
    
}

