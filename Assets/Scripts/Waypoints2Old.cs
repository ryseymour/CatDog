﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints2Old : MonoBehaviour {

	public static Transform[] points2;

	void Awake ()
	{
		points2 = new Transform[transform.childCount];
		for (int i = 0; i < points2.Length; i++) {
			points2[i] = transform.GetChild (i);
		}
			
	}

}
