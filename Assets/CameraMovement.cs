﻿using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float speed = 5;
	public GameObject player1;
	public GameObject player2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player1.transform.position.z > this.transform.position.z + 1 || player2.transform.position.z > this.transform.position.z + 1) {
			//transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10);

			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 0.1f);
		}
	}
}
