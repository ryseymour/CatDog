using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finder : MonoBehaviour {

//	public FungusManager gb; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateValues(int newAttack, int newDefense){ 

		
		FungusManager.instance.sendInValues (newAttack, newDefense);
	
	}
}
