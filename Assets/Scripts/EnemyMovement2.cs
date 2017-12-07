using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement2 : MonoBehaviour {

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
	public float health = 150;
	private float herohealth;
	private float turrethealth;
	private float castlehealth;
	public float updateHealth;
	public Image healthbar;
	bool canClick;
	//private float enemyhealth;
	public int stopCollider;
	public  Animator anim;
	//public static int gate;

	void Awake()
	{
		var randomInt = Random.Range (0, 100);
		Debug.Log (randomInt);
		if (randomInt >= 75) {
			//target = EnemyWaypoints.Enemypoints [0];
			//target = gameObject.name "
			EnemyWaypointScript2.R2 = true;
			EnemyWaypointScript2.L2 = false;
			EnemyWaypointScript2.C2 = false;
		}

		if (randomInt <= 25) {
			EnemyWaypointScript2.L2 = true;

			EnemyWaypointScript2.R2 = false;
			EnemyWaypointScript2.C2 = false;

			//target = EnemyWaypoints2.Enemypoints2 [0];
		}

		if (randomInt >= 50 && randomInt < 75) {
			EnemyWaypointScript2.C2 = true;
			EnemyWaypointScript2.R2 = false;
			EnemyWaypointScript2.L2 = false;
		}

		updateHealth = health;
		canClick = false;
		anim = GetComponentInChildren<Animator> ();

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

			anim.SetBool("isDead",true);
			if (!canClick) {
				WaveSpawner.currency = WaveSpawner.currency + 1;
				canClick = true;

			}
			Invoke("destroySelf",1.5f);

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
			if (anim.GetBool ("isAttacking") == true) {
				anim.SetBool ("isAttacking", false);
			}
			stopCollider = 0;
		}


			
	}

	void FixedUpdate ()
	{
		colliders = Physics.OverlapSphere (transform.position, radius, mask);


			foreach (Collider col in colliders) {
				herohealth = col.gameObject.GetComponent<Enemy> ().updateHealth = col.gameObject.GetComponent<Enemy> ().updateHealth- 1f;
			if (anim.GetBool ("isAttacking") == false) { //does it once but bein in a foreach ---- umm might change this 
				anim.SetBool ("isAttacking", true);
			}

				//turrethealth = col.gameObject.GetComponent<Turret> ().updateHealth = col.gameObject.GetComponent<Turret> ().updateHealth - 1f;
				//enemyhealth = EnemyMovement.health - 1;
			return;
			}
	

		if (herohealth == null) {
			return;
		}
		turretCollider = Physics.OverlapSphere (transform.position, radius, turret);

		foreach (Collider col in turretCollider) {
			turrethealth = col.gameObject.GetComponent<TurretHP> ().updateHealth = col.gameObject.GetComponent<TurretHP> ().updateHealth- 1f;
			Debug.Log ("turret");
			return;
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

	void destroySelf(){
		Destroy (gameObject);
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
