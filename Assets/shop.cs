using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour {

	//WaveSpawner waveSpawner;


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
		WaveSpawner.MinonBuild = 1;
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
}
