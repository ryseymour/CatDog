using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Fungus;

public class FungusTesting : MonoBehaviour {

//	public Flowchart fl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			Time.timeScale = 0.0001f;    
//			Flowchart.BroadcastFungusMessage ("t");
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			Time.timeScale = 1f;  
		}
		
	}
}
