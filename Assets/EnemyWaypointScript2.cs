using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypointScript2 : MonoBehaviour {

	public EnemyWaypointScript2 EnemyNext2;
	public bool isTurretLocation = false;
	public bool isEnemyTurret = false;
	public bool isCastle = false;
	public GameObject find;
	public static bool R2;
	public static bool L2;
	public static bool C2;
	public EnemyWaypointScript2 nextR2;
	public EnemyWaypointScript2 nextC2;
	public EnemyWaypointScript2 nextL2;


	void OnDrawGizmos() {
		if (EnemyNext2 != null) {
			Gizmos.color = Color.red;

			Gizmos.DrawLine (transform.position, EnemyNext2.gameObject.transform.position);
		}

		if (find != null) {
			Gizmos.color = Color.blue;

			Gizmos.DrawLine (transform.position, find.gameObject.transform.position);
		}
	}

	// Use this for initialization
	void Start () {
		//nextR1 = gameObject("WaypointR.1(WaypointScript)");
		R2 = false;
		C2 = false;
		L2 = false;
	}



	// Update is called once per frame
	void Update () {
		if (this.gameObject.name == "EnemyStartPoint2"  && R2 == true) {
			EnemyNext2 = nextR2;
			Reset ();
		}
		if (this.gameObject.name == "EnemyStartPoint2" &&C2 == true) {
			EnemyNext2 = nextC2;
			Reset ();
			}
		if (this.gameObject.name == "EnemyStartPoint2" &&L2== true) {
			EnemyNext2 = nextL2;
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

