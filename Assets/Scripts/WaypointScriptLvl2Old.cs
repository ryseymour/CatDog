using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScriptLvl2Old : MonoBehaviour {

	public WaypointScript next;
	public bool isTurretLocation = false;
	public bool isEnemyTurret = false;
	public bool isCastle = false;
	public GameObject find;
	public static bool R1;
	public static bool L1;
	public static bool C1;
	public static bool R2;
	public static bool L2;
	public static bool C2;
	public WaypointScript nextR1;
	public WaypointScript nextC1;
	public WaypointScript nextL1;
	public WaypointScript nextR2;
	public WaypointScript nextL2;
	public WaypointScript nextC3;


	void OnDrawGizmos() {
		if (next != null) {
			Gizmos.color = Color.red;

			Gizmos.DrawLine (transform.position, next.gameObject.transform.position);
		}

		if (find != null) {
			Gizmos.color = Color.blue;

			Gizmos.DrawLine (transform.position, find.gameObject.transform.position);
		}
	}

	// Use this for initialization
	void Start () {
		//nextR1 = gameObject("WaypointR.1(WaypointScript)");
		R1 = false;
		C1 = false;
		L1 = false;
		R2 = false;
		C2 = false;
		L2 = false;
	}



	// Update is called once per frame
	void Update () {
		if (this.gameObject.name == "StartPoint" && R1 == true) {
			next = nextR1;
			Reset ();
		}
		if (this.gameObject.name == "StartPoint"&&C1 == true) {
				next = nextC1;
			Reset ();
			}
		if (this.gameObject.name == "StartPoint"&&L1== true) {
				next = nextL1;
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

