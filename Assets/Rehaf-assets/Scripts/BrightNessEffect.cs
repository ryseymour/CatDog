using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BrightNessEffect : MonoBehaviour {

	// Use this for initialization
//	public bool isDog;
	Color  initialColor, changeColor;
	Color temp;
	Image img;
//	public Text txt1, txt2; //text one dog text 2 cat -- same for animators 
//	public Animator anim1, anim2;
	void Start () {
		img = GetComponent<Image> ();
		initialColor = img.color;
		temp = initialColor;
		temp.a = 1;
		temp = Color.white;
		changeColor = temp;
		//if we want text accompanied 
//		anim1 = txt1.GetComponent<Animator> ();
//		anim2 = txt2.GetComponent<Animator> ();


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void increaseBrigtness(){
		img.color= temp;
		img.color = Color.white;
//		if (isDog) {
//			anim1.Play ("IN");
//		} else {
//			anim2.Play ("IN");
//
//		}
	}
	public void decreaseBrigtness(){
		img.color= initialColor;
//		if (isDog) {
//			anim1.Play ("OUT");
//		} else {
//			anim2.Play ("OUT");
//		}
	}
}
