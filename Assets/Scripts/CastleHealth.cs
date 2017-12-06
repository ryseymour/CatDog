using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleHealth : MonoBehaviour {
	public float health = 1000;
	public float updateHealth;
	public Image healthbar;
	public bool isPlayerCastle = false;

	// Use this for initialization
	void Start () {
		updateHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		healthbar.fillAmount = updateHealth/health;

		if (updateHealth <=0f) {
			Destroy(gameObject);
			//TODO - change this to game over scene ---- -- -add a a check here that other castle is alive 
			OurSceneManager.instance.MoveToScene(); //check based on isPlayerCatsle - fif plauer castle true go to next win else go to end scene 
			return;
	}


}
}
