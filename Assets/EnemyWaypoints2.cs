using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypoints2 : MonoBehaviour {

	public static Transform[] Enemypoints2;

	void Awake ()
	{
		Enemypoints2 = new Transform[transform.childCount];
		for (int i = 0; i < Enemypoints2.Length; i++) {
			Enemypoints2[i] = transform.GetChild (i);
		}

	}

}
