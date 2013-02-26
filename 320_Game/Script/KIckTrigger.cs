using UnityEngine;
using System.Collections;

public class KIckTrigger : MonoBehaviour {
	GameObject mGamematch320, Explode_02,Explode03;
    
	

	// Use this for initialization
	void Start () {
		if (Application.loadedLevelName == "310Game_2") mGamematch320 = GameObject.Find("MainControllView").gameObject.gameObject;
		Explode_02 = (GameObject)Resources.Load("Effect/Explode_02");
        Explode03 = (GameObject)Resources.Load("Effect/Exp02");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void OnTriggerEnter (Collider pCol) {
        if (Application.loadedLevelName == "310Game_2" && mGamematch320.GetComponent<MainRpsMatch>().mStateArr.GetCurStateName() == "AnimaPlay" && pCol.tag == "KickBall") {
            if (Ag.mgIsKick){
                if(Ag.mgSkill == 1 || Ag.mgSkill == 0) {
                    Instantiate(Explode03,new Vector3(0.2397667f,0.1346343f,-34.64585f ), Quaternion.identity);
                    SoundManager.Instance.Play_Effect_Sound("Shoot_Good");
                } else {
                    Instantiate(Explode_02,new Vector3(0.2397667f,0.1346343f,-34.64585f ), Quaternion.identity);
                    SoundManager.Instance.Play_Effect_Sound("Shoot_Perfect");
                }
            } else {
                if(Ag.mgEnemSkill == 1 || Ag.mgEnemSkill == 0) {
                    Instantiate(Explode03,new Vector3(0.2397667f,0.1346343f,-34.64585f ), Quaternion.identity);
                    SoundManager.Instance.Play_Effect_Sound("Shoot_Good");
                } else {
                    Instantiate(Explode_02,new Vector3(0.2397667f,0.1346343f,-34.64585f ), Quaternion.identity);
                    SoundManager.Instance.Play_Effect_Sound("Shoot_Perfect");
                }
            }
        }
		
		if (Application.loadedLevelName != "310Game_2"){
             if(Ag.mgSkill == 1 || Ag.mgSkill == 0) {
                    Instantiate(Explode03,new Vector3(0.2397667f,0.1346343f,-34.64585f ), Quaternion.identity);
                    SoundManager.Instance.Play_Effect_Sound("Shoot_Good");
                } else {
                    Instantiate(Explode_02,new Vector3(0.2397667f,0.1346343f,-34.64585f ), Quaternion.identity);
                    SoundManager.Instance.Play_Effect_Sound("Shoot_Perfect");
                }
            
            
        }
        
    }
}

