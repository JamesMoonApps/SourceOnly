using UnityEngine;
using System.Collections;

public class CANANI : MonoBehaviour {
 public int Num ;
    public float NumInterVal = 0.1f;
    public bool mFlag = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
         if(mFlag){
            Num=  (int)(Time.time / NumInterVal);
            //Num++;
            var Num1=Num % 4 ;
            GameObject.Find ("UI Root/Camera/Anchor/Panel/RedBull/Background").GetComponent<UISprite>().spriteName = (Num1+2).ToString();
        }
	
	}
}
