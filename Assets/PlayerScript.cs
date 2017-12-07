using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public WaypointScript targetWaypoint;
	//public WaypointScript targetWaypoint2;

	public bool isTechnician = false;
	bool castle = false;
	bool castle2 = false;
	bool move = true;
	private float castleHealth;


	//public float PlayerSpeed;
	public int collision;

	//public Image healthbar;

	// Use this for initialization
	void Start () {
		//PlayerSpeed = gameObject.GetComponent<Enemy>().speed;

	}

	void Awake () {
		//targetWaypoint2 = targetWaypoint; 
		//targetWaypoint = WaypointScript;
		//targetWaypoint= WaypointScript.next;
		//GameObject.Find ("StarPoint");

	}

	//public void Initalize

	// Update is called once per frame
	void Update () {
		//PlayerSpeed = 0;
		collision = gameObject.GetComponent<Enemy> ().stopCollider;
		//collision = gameObject.GetComponent<PlayerCatapult> ().stopCollider;
		if (move && collision == 0) {
			transform.LookAt (targetWaypoint.gameObject.transform.position + new Vector3(0, 0.5f, 0));
			transform.position += transform.forward * 10f * Time.deltaTime;
		}

		if (Vector3.Distance(gameObject.transform.position, targetWaypoint.gameObject.transform.position) < 1) {
			//Decide what to do next
			if (isTechnician && targetWaypoint.isTurretLocation) {
				move = false;
			} if (targetWaypoint.isCastle) {
				move = false;
				castleHealth = GameObject.Find ("EnemyCastle").GetComponent<CastleHealth> ().updateHealth = GameObject.Find ("EnemyCastle").GetComponent<CastleHealth> ().updateHealth - 1f;
			}

			//if (targetWaypoint.)

			if (collision == 1) {
				move = false;
			}
			else if (targetWaypoint.next != null) {
				targetWaypoint = targetWaypoint.next;
			}			
		}
	}
}
