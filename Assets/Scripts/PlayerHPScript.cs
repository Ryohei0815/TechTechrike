using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHPScript : MonoBehaviour {

	public int playerHP = 100;

	// Use this for initialization
	void Start () {

		Debug.Log ("敵のHPは" + playerHP);
		
	}
	
	// Update is called once per frame
	void Update () {

		if (playerHP == 0) {
			Debug.Log ("GameOver");
		}
		
	}

	private void OnTriggerEnter(Collider other){
		playerHP--;
		Debug.Log ("プレイヤーのHPは" + playerHP);
	}

}
