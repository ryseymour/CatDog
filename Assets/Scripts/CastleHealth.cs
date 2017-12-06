using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleHealth : MonoBehaviour {
	public float health = 1000;
	public float updateHealth;
	public Image healthbar;

	// Use this for initialization
	void Start () {
		updateHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		healthbar.fillAmount = updateHealth/health;

		if (updateHealth <=0f) {
			Destroy(gameObject);
			return;
	}


}
}
