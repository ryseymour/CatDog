using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretHP : MonoBehaviour {

	public float health = 50f;
	public float updateHealth;
	public Image healthbar;
	public GameObject turret;

	// Use this for initialization
	void Start () {
		updateHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		healthbar.fillAmount = updateHealth/health;

		if (updateHealth <=0f) {
			turret.SetActive(false);
			return;
		}

	}
}
