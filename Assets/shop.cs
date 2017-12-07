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
	public GameObject path;


	void Start ()
	{
		//waveSpawner = WaveSpawner.instance;
	}

	public void CenterGate()
	{
		WaypointScript.L1 = false;
		WaypointScript.R1 = false;
		WaypointScript.C1 = true;
		path.SetActive (false);
		//Debug.Log ("East Gate");
		//Enemy.gate = 1;
	}

	public void RightGate()
	{
		WaypointScript.L1 = false;
		WaypointScript.R1 = true;
		WaypointScript.C1 = false;
		path.SetActive (false);
		//Debug.Log ("North Gate");
		//Enemy.gate = 4;
	}
	public void LeftGate()
	{
		WaypointScript.L1 = true;
		WaypointScript.R1 = false;
		WaypointScript.C1 = false;
		path.SetActive (false);
		//path.SetActive (false);
	}

	public void PurchaseMelee()
	{
		Debug.Log ("melee");
//		waveSpawner.SpawnEnemy (waveSpawner.enemyPrefabMelee);
		ButtonHit = false;
		WaveSpawner.MinonBuild = 1;
		path.SetActive (true);
		WaypointScript.lights = true;
		StartCoroutine (SpawnWave());

	}

	public void PurchaseRange()
	{
		Debug.Log ("range");
		WaveSpawner.MinonBuild = 2;
		WaypointScript.lights = true;
		path.SetActive (true);
	}

	public void PurchaseAOE()
	{
		Debug.Log ("AOE");
		WaveSpawner.MinonBuild = 3;
		WaypointScript.lights = true;
		path.SetActive (true);

	}

	IEnumerator SpawnWave()
	{
		//path.SetActive (false);
		canclickM = true;
		canClickR = true;
		canClickAOE = true;
		//MeleeButton.interactable = true;
		//RangeButton.interactable = true;
		//SupportButton.interactable = true;
		yield return new WaitForSeconds (0.5f);
		ButtonHit = true;
		Reset ();
	}

	void Update (){

		if (WaypointScript.lights == false) {
			path.SetActive (false);
		}
		if (WaveSpawner.currency >= 3.0f && ButtonHit == true) {
			canclickM = true; 
			//path.SetActive (true);
//			MeleeButton.interactable = true;
			//path.SetActive (false);

		} else {
			canclickM = false; 
			//path.SetActive (false);

//			MeleeButton.interactable = false;

		}

		if (WaveSpawner.currency >= 4.0f && ButtonHit == true) {
			canClickR = true;
			//path.SetActive (false);

//			RangeButton.interactable = true;
		} else {
			canClickR = false;
			//path.SetActive (false);

//			RangeButton.interactable = false;
		}

		if (WaveSpawner.currency >= 4.0f && ButtonHit == true) {
			canClickAOE = true;
			//path.SetActive (false);
//			SupportButton.interactable = true;
		} else {
			canClickAOE = false;
			//path.SetActive (false);

//			SupportButton.interactable = false;

		}
	}
			void Reset (){
				WaypointScript.L1 = false;
				WaypointScript.R1 = false;
				WaypointScript.C1 = false;
		return;

			}




}
