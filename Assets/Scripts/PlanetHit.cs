using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

//ガス惑星などのお邪魔な自分自身のクラス実装
public class PlanetHit : MonoBehaviour
{

	public int HitType;


	void Start ()
	{
	}

	void OnCollisionEnter (Collision hit)
	{//Playerタグでなければ、そのままスルー。Playerタグ以外はlostクラスへ
		if (!"Player".Equals (hit.gameObject.tag)) {
			return;
		}
		lost (hit.gameObject);
	}
		
	private void lost (GameObject player)
	{//ガス惑星（じしん）の衝突制御
		switch (HitType) {
		case 0:
			GameSystemManager.Clear ();

			return;
		case 1:
			player.SetActive (false);
			this.gameObject.SetActive (false);
			GameSystemManager.Over ();
			return;
		default :
			return;
		}

	}

}
