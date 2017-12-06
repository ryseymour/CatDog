using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour {

	//WaveSpawner waveSpawner;
	//public GameObject MeleeButton;
	//public GameObject RangeButton;
	//public GameObject SupportButton;
	public GameObject MeleeButton;
	public Button RangeButton;
	public Button SupportButton;
	public bool ButtonHit = true;
	public bool canclickM = false;
	public bool canClickR = false;
	public bool canClickAOE = false;


	void Start ()
	{
		//waveSpawner = WaveSpawner.instance;
	}

	public void CenterGate()
	{
		WaypointScript.L1 = false;
		WaypointScript.R1 = false;
		WaypointScript.C1 = true;
		//Debug.Log ("East Gate");
		//Enemy.gate = 1;
	}

	public void RightGate()
	{
		WaypointScript.L1 = false;
		WaypointScript.R1 = true;
		WaypointScript.C1 = false;
		//Debug.Log ("North Gate");
		//Enemy.gate = 4;
	}
	public void LeftGate()
	{
		WaypointScript.L1 = true;
		WaypointScript.R1 = false;
		WaypointScript.C1 = false;
	}

	public void PurchaseMelee()
	{
		Debug.Log ("melee");
//		waveSpawner.SpawnEnemy (waveSpawner.enemyPrefabMelee);
		ButtonHit = false;
		WaveSpawner.MinonBuild = 1;
		StartCoroutine (SpawnWave());

	}

	public void PurchaseRange()
	{
		Debug.Log ("range");
		WaveSpawner.MinonBuild = 2;
	}

	public void PurchaseAOE()
	{
		Debug.Log ("AOE");
		WaveSpawner.MinonBuild = 3;

	}

	IEnumerator SpawnWave()
	{

		canclickM = true;
		canClickR = true;
		canClickAOE = true;
		//MeleeButton.interactable = true;
		//RangeButton.interactable = true;
		//SupportButton.interactable = true;
		yield return new WaitForSeconds (0.5f);
		ButtonHit = true;
	}

	void Update (){
		if(WaveSpawner.currency >= 3.0f && ButtonHit == true){
			canclickM = true; 
//			MeleeButton.interactable = true;

		}else{
			canclickM = false; 

//			MeleeButton.interactable = false;

		}

		if (WaveSpawner.currency >= 4.0f && ButtonHit == true) {
			canClickR = true;
//			RangeButton.interactable = true;
		} else {
			canClickR = false;

//			RangeButton.interactable = false;
		}

		if (WaveSpawner.currency >= 4.0f && ButtonHit == true) {
			canClickAOE = true;

//			SupportButton.interactable = true;
		}else{
			canClickAOE = false;

//			SupportButton.interactable = false;

}

}
}
