using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypointScript : MonoBehaviour {

	public EnemyWaypointScript EnemytargetWaypointNext;
	public bool isTurretLocation = false;
	public bool isEnemyTurret = false;
	public GameObject find;
	public static bool ER1;
	public static bool EL1;
	public static bool EC1;
	public EnemyWaypointScript nextER1;
	public EnemyWaypointScript nextEC1;
	public EnemyWaypointScript nextEL1;


	void OnDrawGizmos() {
		if (EnemytargetWaypointNext != null) {
			Gizmos.color = Color.red;

			Gizmos.DrawLine (transform.position, EnemytargetWaypointNext.gameObject.transform.position);
		}

		if (find != null) {
			Gizmos.color = Color.blue;

			Gizmos.DrawLine (transform.position, find.gameObject.transform.position);
		}
	}

	// Use this for initialization
	void Start () {
		//nextR1 = gameObject("WaypointR.1(WaypointScript)");
		ER1 = false;
		EC1 = false;
		EL1 = false;
	}



	// Update is called once per frame
	void Update () {

		if (this.gameObject.name == "EnemyStartPoint" && ER1 == true) {
			EnemytargetWaypointNext = nextER1;
			Reset ();
		}
		if (this.gameObject.name == "EnemyStartPoint"&& EC1 == true) {
			EnemytargetWaypointNext = nextEC1;
			Reset ();
			}
		if (this.gameObject.name == "EnemyStartPoint"&& EL1== true) {
			EnemytargetWaypointNext = nextEL1;
			Reset ();
			}
			

			//next = WaypointScript.Instantiate("WaypointR.1(WaypointScript)");
			//Debug.Log ("next");
			//next = gameObject.name ("WaypointR.1(WaypointScript));
			//next=GetComponent(WaypointScript);
			//find = GameObject.("WaypointR.1"(WaypointScript));
			//next = find;
			//next = GameObject.Find ("WaypointR.1(WaypointScript)");
			//next = find.GetComponent (WaypointScript);
		}

	void Reset() {
		//R1 = false;
		//C1 = false;
		//L1 = false;
		return;
	}
	}

