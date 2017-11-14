using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapSphere : MonoBehaviour {

	public float radius = 0f;
	public Collider[] colliders;
	public LayerMask mask;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		colliders = Physics.OverlapSphere (transform.position, radius, mask);

		//if (colliders > 0) {

		//}
	}
}
