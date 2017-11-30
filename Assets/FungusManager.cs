using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FungusManager : MonoBehaviour {

	public Flowchart fl;
	public  float attack = 0;
	public  float defense = 0; 
	FungusManager instance;
	 void Awake() {
////		instance = this;
//		if (instance != null) {
//			Destroy(gameObject);
//		}else{
//			DontDestroyOnLoad(gameObject);
//		}
		DontDestroyOnLoad(gameObject);

	}

	public void sendInValues( float _attack, float _health){
		attack += _attack; // add 10 example 
		defense += _attack; 
	}





}
