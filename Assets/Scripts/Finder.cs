using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finder : MonoBehaviour {


	public void UpdateValues(int newAttack, int newDefense){ 

		
		FungusManager.instance.sendInValues (newAttack, newDefense);
	
	}

	public void MoveScenes(int nextSceneNumber){
		OurSceneManager.instance.MoveToScene (nextSceneNumber);
	
	}
}
