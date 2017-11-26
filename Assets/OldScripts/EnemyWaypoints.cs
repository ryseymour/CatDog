using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypoints : MonoBehaviour {

	public static Transform[] Enemypoints;

	void Awake ()
	{
		Enemypoints = new Transform[transform.childCount];
		for (int i = 0; i < Enemypoints.Length; i++) {
			Enemypoints[i] = transform.GetChild (i);
		}

	}

}
