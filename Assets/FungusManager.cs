using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FungusManager : MonoBehaviour {
	public static FungusManager instance = null;
	  float attack = 0;
	  float defense = 0; 
	 void Awake() {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
		else{
			Destroy (gameObject);
	}

	}

	public void sendInValues( float _attack, float _health){
		this.attack += _attack; // add 10 example 
		this.defense += _attack; 
	}





}
