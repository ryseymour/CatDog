using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTurnerOnner : MonoBehaviour {

	PathCubeForMouseOver parentThing;
	public int gatechoice;


	// Use this for initialization
	void Start () {
		parentThing = transform.parent.GetComponent<PathCubeForMouseOver> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter() {
		parentThing.mouseOverCount++;

		//parentThing.lalala();
	}

	void OnMouseDown () {
		
		if (gatechoice == 3) {
		Debug.Log("R1");	
		WaypointScript.L1 = false;
		WaypointScript.C1 = false;
		WaypointScript.R1 = true;
			return;
		}
		if (gatechoice == 2) {
			Debug.Log("c1");	
			WaypointScript.L1 = false;
			WaypointScript.C1 = true;
			WaypointScript.R1 = false;
			return;
		}
		if (gatechoice == 1) {
			Debug.Log("l1");	
			WaypointScript.L1 = true;
			WaypointScript.C1 = false;
			WaypointScript.R1 = false;
			return;
		}

		//if (gatechoice == 4)


	}

	void OnMouseExit() {
		parentThing.mouseOverCount--;
		//parentThing.lalala();
	}
}
