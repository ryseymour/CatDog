using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OurSceneManager : MonoBehaviour {

	//TODO if we move back - scene manager will be null for panel - need to add a rest to fi this issue --- for restart issue 
	public static OurSceneManager instance = null;
	public static bool isCatLevel = false;
	int currentLevel = 0;

	void Awake() {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
		else{
			Destroy (gameObject);
		}

	}


	public void MainMeuChoice(bool choice ){

		isCatLevel = choice;
		MoveToScene (1);
	}


	public void MoveToScene(int levelnumber){
		if (isCatLevel) {
			SceneManager.LoadScene ("CLevel" + levelnumber.ToString ());
									
		} else {
			SceneManager.LoadScene ("DLevel" + levelnumber.ToString ());
		}

	}


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