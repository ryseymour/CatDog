using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	public float speed = 10f;

	private Transform target;
	//private int wavepointIndex = 0;

	public static int gate;

	public float radius = 0f;
	public Collider[] colliders;
	public Collider[] colliders2;
	public Collider[] selfColliders;
	public Collider[] turretCollider;
	public LayerMask mask;
	public LayerMask mask2;
	public LayerMask maskSelf;
	public LayerMask turret;
	private float enemyhealth;
	private float enemyhealth2;
	private float turrethealth;
	public float health = 50;
	public float updateHealth;
	public float damage = 1f;
	public float def= 1;

	public PlayerScript speedchange;
	public int stopCollider;
	public Animator anim;
	//private float SpeedStop = 0f;

	public Image healthbar;

	void Awake()
	{
		speedchange = gameObject.GetComponent<PlayerScript> ();
		updateHealth = health;
		//if (gate == 1) {
			//target = Waypoints.points [0];
		//}

		//if (gate == 4) {
			//target = Waypoints2.points2 [0];
		//}

	}

	void Start(){
		health += FungusManager.instance.attack;
		damage += FungusManager.instance.attack;
		anim = GetComponentInChildren<Animator> ();

	}

	void Update ()
	{
		//Vector3 dir = target.position - transform.position;
		//transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);

		//if (Vector3.Distance (transform.position, target.position) <= 0.2f) {
			//GetNextWaypoint();
		//}
		Debug.Log("new health is "+ health+ " nwew dmg is "+ damage);
		healthbar.fillAmount = updateHealth/health;

		if (updateHealth <=0f) {
			anim.SetBool ("IsDead", true);
			Invoke ("Destroyself", 1.5f);
			return;

		}
		if (colliders.Length >= 1 || selfColliders.Length>=2 || turretCollider.Length>1 || colliders2.Length >= 1){

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

	//void ColliderHealth()
	{
		//speed = 0f;
		colliders = Physics.OverlapSphere (transform.position, radius, mask);

		foreach (Collider col in colliders) {
			enemyhealth = col.gameObject.GetComponent<EnemyMovement> ().updateHealth = col.gameObject.GetComponent<EnemyMovement> ().updateHealth - damage ;


			if (anim.GetBool ("isAttacking") == false) {
				anim.SetBool ("isAttacking", true);
			}

			return;
			//enemyhealth = EnemyMovement.health - 1;
		}
		if (enemyhealth == null) {
			return;
		}

		colliders2 = Physics.OverlapSphere (transform.position, radius, mask2);

		foreach (Collider col in colliders2) {
			enemyhealth2 = col.gameObject.GetComponent<EnemyMovement2> ().updateHealth = col.gameObject.GetComponent<EnemyMovement2> ().updateHealth - damage ;

			return;
		}
		if (enemyhealth2 == null) {
			return;
		}

		turretCollider = Physics.OverlapSphere (transform.position, radius, turret);

		foreach (Collider col in turretCollider) {
			turrethealth = col.gameObject.GetComponent<TurretHP> ().updateHealth = col.gameObject.GetComponent<TurretHP> ().updateHealth - damage ;
			Debug.Log ("turret");
			return;
		}

		if (turrethealth == null) {
			return;
		}

		selfColliders = Physics.OverlapSphere (transform.position, radius, maskSelf);

		



		//int healthhit = 




		//if (colliders.Length ==1) {
			//speed = 0f;
			//Debug.Log ("stop");

		//}
	}


	void Destroyself(){
		Destroy (gameObject);
	}


	//void OnTriggerEnter(Collider other){
		//if (other.CompareTag("Minion"))
			//Debug.Log ("wait");
		//speedchange.PlayerSpeed = 0f;
			
	
	//}

	//void GetNextWaypoint()
	//{

		//if(wavepointIndex >= Waypoints.points.Length - 1)
		//{
			//Destroy(gameObject);
			//return;
		//}

		
		//wavepointIndex++;
		//target = Waypoints.points [wavepointIndex];
//}
}
