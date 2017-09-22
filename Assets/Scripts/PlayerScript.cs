﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.GetComponent<Rigidbody> ().velocity == new Vector3 (0, 0, 0)) {
			transform.Rotate (new Vector3 (0, 5f, 0));
		}
			
		if (Input.GetKey ("up")) {
			if (gameObject.GetComponent<Rigidbody> ().velocity == new Vector3 (0, 0, 0)) {
				gameObject.GetComponent<Rigidbody> ().velocity = transform.forward * 50f;
			}
		}

	}
}
