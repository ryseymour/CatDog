using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OurSceneManager : MonoBehaviour {

	//TODO if we move back - scene manager will be null for panel - need to add a rest to fi this issue --- for restart issue 
	public static OurSceneManager instance = null;
	public static bool isCatLevel = false;
	public  int currentLevel = 0;

	void Awake() {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
		else{
			Destroy (gameObject);
		}

	}

	void Update(){
		if (Input.GetKey (KeyCode.M)) {
			MoveToScene ();
		}
	}

	public void MainMeuChoice(bool choice ){

		isCatLevel = choice;
		currentLevel++; //out current level should be one 
		MoveToScene (1);
	}

	public  void resetSCeneData(){ //call this on game over - 
	
		currentLevel = 0;
		isCatLevel = false;
		SceneManager.LoadScene ("Level0");


	}

	public void MoveToScene(int levelnumber){
//		currentLevel++; // two 
		if (isCatLevel) {
			SceneManager.LoadScene ("CLevel" + levelnumber.ToString());
									
		} else {
			SceneManager.LoadScene ("DLevel" + levelnumber.ToString ());
		}

	}

	public void MoveToScene(){
		currentLevel++; // two //this will be used in game 3d scenes - ( current scene at the end will hold the next levels nymber ) 
		if (isCatLevel) {
			SceneManager.LoadScene ("CLevel" + currentLevel.ToString ());

		} else {
			SceneManager.LoadScene ("DLevel" + currentLevel.ToString ());
		}

	}

	public void GoToGameover(){ //lose state 
		if (isCatLevel) {
			SceneManager.LoadScene ("ENDCAT");

		} else {
			SceneManager.LoadScene ("ENDDog");
		}

	
	}


	//not used 
	public void GoToWinScene(){ //lose state 
		if (isCatLevel) {
			SceneManager.LoadScene ("ENDCATwin");

		} else {
			SceneManager.LoadScene ("ENDDogwin");
		}


	}



	//TODO - on game over reset data here fpr current level ...etc 

}




///cat scenes /*
/// 
/// //cat name CLevelx
/// cat name DLevelx
				/// CLevel1 - narrative cat 
				/// Clevel2 - game1 cat 
				/// Clevel3 - narrative cat 2 
				/// Clevel4 is - game2cat 
				/// Clevel5  narrativ e
				/// Clevel6 game
				/// 
				/// DLevel1 - narrative cat 
				/// Dlevel2 - game1 cat 
				/// Dlevel3 - narrative cat 2 
				/// Dlevel4 is - game2cat 
				/// Dlevel5 
				/// */