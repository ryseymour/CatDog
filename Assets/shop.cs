using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour {

	//WaveSpawner waveSpawner;
	//public GameObject MeleeButton;
	//public GameObject RangeButton;
	//public GameObject SupportButton;
	public Button MeleeButton;
	public Button RangeButton;
	public Button SupportButton;
	public bool ButtonHit = true;


	void Start ()
	{
		//waveSpawner = WaveSpawner.instance;
	}

	public void EastGate()
	{
		Debug.Log ("East Gate");
		Enemy.gate = 1;
	}

	public void NorthGate()
	{
		Debug.Log ("North Gate");
		Enemy.gate = 4;
	}

	public void PurchaseMelee()
	{
		Debug.Log ("melee");
		//waveSpawner.SpawnEnemy (waveSpawner.enemyPrefabMelee);
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
		
		//MeleeButton.interactable = true;
		//RangeButton.interactable = true;
		//SupportButton.interactable = true;
		yield return new WaitForSeconds (0.5f);
		ButtonHit = true;
	}

	void Update (){
		if(WaveSpawner.currency >= 2.0f && ButtonHit == true){
			MeleeButton.interactable = true;

		}else{
			MeleeButton.interactable = false;

		}

		if (WaveSpawner.currency >= 4.0f && ButtonHit == true) {
			RangeButton.interactable = true;
		} else {
			RangeButton.interactable = false;
		}

		if (WaveSpawner.currency >= 4.0f && ButtonHit == true) {
			SupportButton.interactable = true;
		}else{
			SupportButton.interactable = false;

}

}
}
