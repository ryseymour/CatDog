using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyWaveSpawner : MonoBehaviour {

	public Transform enemyPrefabMelee;
	public Transform enemyPrefabRange;
	public Transform enemyPrefabAOE;
	public Transform spawnPoint;
	public float timeBetweenWaves = 5f;

	public static int MinonBuild;
	public static int GateChoice;

	//public GameObject SetMinonToBuild;

	public Text waveCountdownText;

	private float countdown = 2f;

	private int waveIndex= 1;

	void Update()
	{
		if (countdown <= 0f) {
			//StartCoroutine (SpawnWave());
			SpawnEnemy ();
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;

		//waveCountdownText.text = Mathf.Round(countdown).ToString ();
	}

	//IEnumerator SpawnWave()
	//{
		//waveIndex++;
		//for (int i = 0; i < waveIndex; i++) {
			//SpawnEnemy ();
			//yield return new WaitForSeconds (0.5f);
		//}

	//}

	void SpawnEnemy ()
	{


			Instantiate (enemyPrefabMelee, spawnPoint.position, spawnPoint.rotation);

	}
}
