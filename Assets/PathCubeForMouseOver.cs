using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCubeForMouseOver2 : MonoBehaviour {

	public int mouseOverCount = 0;
	public GameObject pathlights;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (mouseOverCount > 0) {

			Debug.Log ("ON: " + gameObject.name);
			pathlights.SetActive (true);
			return;
		} else {
			Debug.Log ("OFF: " + gameObject.name);
			pathlights.SetActive (false);
			return;
		}
	}

	public void updateTheLightsOrSomething() {
		if (mouseOverCount > 0) {
			
			Debug.Log ("ON: " + gameObject.name);
			pathlights.SetActive (true);
			return;
		} else {
			Debug.Log ("OFF: " + gameObject.name);
			pathlights.SetActive (false);
			return;
		}
	}
}
