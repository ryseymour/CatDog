using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAnimationEffect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("DestroyThis", 4);
		
	}
	
	// Update is called once per frame
	void DestroyThis(){
		Destroy (gameObject);
	}
}
