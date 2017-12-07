using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorMinionManager : MonoBehaviour {

	Animator anim; 
	public bool isAttacking = false;
	public GameObject wizzardPrefab;
	GameObject temp; 
	public Transform AvatarLocation;
	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		canAttack (isAttacking);
		
	}
	


	public void canAttack(bool isAttacking){
		anim.SetBool ("isAttacking", isAttacking);
	
	}

	public void InstantiateFire(){

		temp = Instantiate (wizzardPrefab, AvatarLocation.transform.position, Quaternion.identity);	
		Invoke ("DestroyTemp", 5f);
	}

	void DestroyTemp (){
		Destroy (temp);
	}
}
