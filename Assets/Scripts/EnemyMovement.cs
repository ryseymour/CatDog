using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour {

	//public float speed = 10f;

	private Transform target;
	private int wavepointIndex = 0;
	//public static int randomInt;

	public float radius = 0f;
	public Collider[] colliders;
	public Collider[] selfColliders;
	public Collider[] turretCollider;
	public LayerMask mask;
	public LayerMask maskSelf;
	public LayerMask turret;
	public float health = 50;
	private float herohealth;
	private float turrethealth;
	private float castlehealth;
	public float updateHealth;
	public Image healthbar;
	//public GameObject backBlock;

	//private float enemyhealth;
	public int stopCollider;

	//public static int gate;

	void Awake()
	{
		var randomInt = Random.Range (0, 100);
		Debug.Log (randomInt);
		if (randomInt >= 75) {
			//target = EnemyWaypoints.Enemypoints [0];
			//target = gameObject.name "
			EnemyWaypointScript.ER1 = true;
			EnemyWaypointScript.EL1 = false;
			EnemyWaypointScript.EC1 = false;
		}

		if (randomInt <= 25) {
			EnemyWaypointScript.EL1 = true;

			EnemyWaypointScript.ER1 = false;
			EnemyWaypointScript.EC1 = false;

			//target = EnemyWaypoints2.Enemypoints2 [0];
		}

		if (randomInt >= 50 && randomInt < 75) {
			EnemyWaypointScript.EC1 = true;
			EnemyWaypointScript.ER1 = false;
			EnemyWaypointScript.EL1 = false;
		}

		updateHealth = health;

	}

	void Update ()
	{
		//Vector3 dir = target.position - transform.position;
		//transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);

		//if (Vector3.Distance (transform.position, target.position) <= 0.2f) {
			//GetNextWaypoint();
		//}

		healthbar.fillAmount = updateHealth/health;

		if (updateHealth <=0f) {
			Destroy(gameObject);
			WaveSpawner.currency = WaveSpawner.currency + 1;
			//currencyPlus = GameObject.Find ("GameMaster").GetComponent<WaveSpawner> ().gameObject.currency = currency + 1;
			return;

		}

		if (colliders.Length >= 1 || selfColliders.Length>1 || turretCollider.Length>1) {

			//speedchange.PlayerSpeed = 0f;

			//GameObject variable = this.gameObject;
			//variable.GetComponent<PlayerScript> ().PlayerSpeed = 0f;


			//speedchange = 0f;
			//float speedChange = 
			//speed = 0f;
			stopCollider = 1;

			Debug.Log ("stop");
			//ColliderHealth ();

		} else {
			//variable.GetComponent<PlayerScript> ().PlayerSpeed = 5f;
			//speedchange.PlayerSpeed = 5f;
			//speed = 10f;
			stopCollider = 0;
		}


			
	}

	void FixedUpdate ()
	{
		colliders = Physics.OverlapSphere (transform.position, radius, mask);


			foreach (Collider col in colliders) {
				herohealth = col.gameObject.GetComponent<Enemy> ().updateHealth = col.gameObject.GetComponent<Enemy> ().updateHealth- 1f;
				//turrethealth = col.gameObject.GetComponent<Turret> ().updateHealth = col.gameObject.GetComponent<Turret> ().updateHealth - 1f;
				//enemyhealth = EnemyMovement.health - 1;
			return;
			}

		if (herohealth == null) {
			return;
		}
		turretCollider = Physics.OverlapSphere (transform.position, radius, turret);
		if (turretCollider != null) {
			
			foreach (Collider col in turretCollider) {
				turrethealth = col.gameObject.GetComponent<TurretHP> ().updateHealth = col.gameObject.GetComponent<TurretHP> ().updateHealth - 1f;
				Debug.Log ("turret");
				return;
			}
		}

		if (turrethealth == null) {
			return;
		}



		selfColliders = Physics.OverlapSphere (transform.position, radius, maskSelf);

		//if (colliders.Length ==1) {
		//speed = 0f;
		//Debug.Log ("stop");

		//}
	}

	//void GetNextWaypoint()
	//{

		//if(wavepointIndex >= EnemyWaypoints.Enemypoints.Length - 1)
		//{
			//Destroy(gameObject);
			//return;
		//}
//
		
		//wavepointIndex++;
		//target = EnemyWaypoints.Enemypoints [wavepointIndex];
//}
}
