using UnityEngine;
using System.Collections;

public class GameFadeINout : MonoBehaviour {
    public float FadeTime = 4.0f;
    public bool isFadeOut = false;
    public bool isBlack = true;
    public Texture2D FadingImg;
    
    private float alphaFadeValue = 0;

 // Use this for initialization
 void Start () {
        FadeTest(true);
       
    }
 // Update is called once per frame
 void Update () {
    }
    
 void OnGUI()
    {
        if(isFadeOut)
            alphaFadeValue -= Mathf.Clamp01(Time.smoothDeltaTime / FadeTime);
        
        else
            alphaFadeValue += Mathf.Clamp01(Time.smoothDeltaTime / FadeTime);
        
//        Debug.Log (alphaFadeValue);
        
        if(isBlack)
            GUI.color = new Color(GUI.color.r,GUI.color.g,GUI.color.b , alphaFadeValue);
        else
            GUI.color = new Color(0,0,0,alphaFadeValue);
        
        GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),FadingImg);
        
        if (alphaFadeValue < 0) {
            DestroyObject(this.gameObject);
        }
    }
    
    
 void FadeTest(bool Fade) {
        print (Fade);
        alphaFadeValue = 1;
        isFadeOut = Fade ;
    }
}
   
