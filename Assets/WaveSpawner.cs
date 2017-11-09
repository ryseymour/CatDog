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

	//public GameObject SetMinonToBuild;

	public Text waveCountdownText;

	private float countdown = 2f;

	private int waveIndex= 1;

	void Update()
	{
		if (countdown <= 0f) {
			StartCoroutine (SpawnWave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;

		waveCountdownText.text = Mathf.Round(countdown).ToString ();
	}

	IEnumerator SpawnWave()
	{
		waveIndex++;
		for (int i = 0; i < waveIndex; i++) {
			SpawnEnemy ();
			yield return new WaitForSeconds (0.5f);
		}

	}

	void SpawnEnemy ()
	{

		if (MinonBuild == 1){
		Instantiate (enemyPrefabMelee, spawnPoint.position, spawnPoint.rotation);
	}
		if (MinonBuild == 2){
			Instantiate (enemyPrefabRange, spawnPoint.position, spawnPoint.rotation);
		}

		if (MinonBuild ==3){
			Instantiate (enemyPrefabAOE, spawnPoint.position, spawnPoint.rotation);
		}
}
}
