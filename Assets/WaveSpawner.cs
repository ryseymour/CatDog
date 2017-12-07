using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public Transform enemyPrefabMelee;
	public Transform enemyPrefabRange;
	public Transform enemyPrefabAOE;
	public Transform spawnPoint;
	public float timeBetweenWaves = 5f;

	public static int MinonBuild;
	public static int GateChoice;

	public WaypointScript Startpoint;
	public WaypointScript targetWaypoint;
	public bool tech;
	public GameObject minion1;
	public GameObject minion2;
	public GameObject minion3;
	//public GameObject SetMinonToBuild;

	public Text waveCountdownText;

	private float countdown = 5f;

	private int waveIndex= 1;

	public static float currency = 0f;

	int currencyMax= 100;
	int currencyMin= 0;

	public GameObject Orignizer;

	void Update()
	{
		Debug.Log ("currency" + currency);
		if (countdown <= 0f) {
			//StartCoroutine (SpawnWave());

			countdown = timeBetweenWaves;
			currency = currency + 1;
		}

		countdown -= Time.deltaTime;

		//waveCountdownText.text = Mathf.Round(countdown).ToString ();
		waveCountdownText.text = Mathf.Round(currency).ToString();

		SpawnEnemy ();
//		StartCoroutine (SpawnWave());
	}

	//IEnumerator SpawnWave()
	//{
		//waveIndex++;
		//for (int i = 0; i < waveIndex; i++) {
			
			//yield return new WaitForSeconds (0.5f);
		
		//}

	//}

	void SpawnEnemy ()
	{
		if (currency > currencyMin) { //base check for buyins suff 

			if (MinonBuild == 1) { 
				//PlayerScript temp =
				//GameObject temp =

				//temp.targetWaypoint = Startpoint;
				if (currency <= currencyMax && currency > 3) {
					Debug.Log ("IS THIS EVER TRUE !!!!");
					currency = currency - 3;
					GameObject temp = Instantiate (minion1, transform.position, Quaternion.identity);
					temp.AddComponent<PlayerScript> (); // you were missing the () after player script  :) 
					temp.GetComponent<PlayerScript> ().targetWaypoint = Startpoint; 
					temp.name = "minion_test";
					temp.transform.parent = Orignizer.transform; //just to see it in hirarcy + to track 
					MinonBuild = 4;
				}
			}
			if (MinonBuild == 2) {
				Debug.Log ("IS THIS EVER TRUE !!!!");
				// currency is now  5 <= 100 ^^ 5 > 0 
				if (currency <= currencyMax && currency > 5) {
					currency = currency - 5;
					GameObject temp2 = Instantiate (minion2, transform.position, Quaternion.identity);
					temp2.AddComponent<PlayerScript> ();
					temp2.GetComponent<PlayerScript> ().targetWaypoint = Startpoint;
					temp2.name = "minion2_test";
					temp2.transform.parent = Orignizer.transform;
					MinonBuild = 4;

			
				}
				
		

				//Instantiate (enemyPrefabRange, spawnPoint.position, spawnPoint.rotation);
				//currency = currency - 4;
				//MinonBuild = 4;
			}

			if (MinonBuild == 3) {
				Debug.Log ("IS THIS EVER TRUE !!!!");

				if (currency <= currencyMax && currency > 10) {
					currency = currency - 10;
					GameObject temp3 = Instantiate (minion3, transform.position, Quaternion.identity);
					temp3.AddComponent<PlayerScript> ();
					temp3.GetComponent<PlayerScript> ().targetWaypoint = Startpoint;
					temp3.GetComponent<PlayerScript> ().isTechnician = true;
					temp3.name = "minion3_test";
					temp3.transform.parent = Orignizer.transform;
					MinonBuild = 4;
				}
				//Instantiate (enemyPrefabAOE, spawnPoint.position, spawnPoint.rotation);
				//currency = currency - 4;
				//MinonBuild = 4;
			}

			if (MinonBuild == 4) {
				return;
			}
		}


}
	void WaitforIt ()
	{
		return;
	}

}
