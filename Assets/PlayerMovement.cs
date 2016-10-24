using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public bool player1 = true;
	public float speed = 5;
	public float buffer = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player1) {
			if (Input.GetAxis ("Horizontal") > buffer || Input.GetAxis ("Horizontal") < buffer * -1) {
				if (Input.GetAxis ("Vertical") > buffer || Input.GetAxis ("Vertical") < buffer * -1)
					transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis ("Vertical") * Time.deltaTime * speed);
				else
					transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime * speed, 0, 0);
			} else { 
				if (Input.GetAxis ("Vertical") > buffer || Input.GetAxis ("Vertical") < buffer * -1)
					transform.Translate (0, 0, Input.GetAxis ("Vertical") * Time.deltaTime * speed);
				else
					transform.Translate (0, 0, 0);
			}
		} else {
			if (Input.GetAxis ("Horizontal2") > buffer || Input.GetAxis ("Horizontal2") < buffer * -1) {
				if (Input.GetAxis ("Vertical2") > buffer || Input.GetAxis ("Vertical2") < buffer * -1)
					transform.Translate (Input.GetAxis ("Horizontal2") * Time.deltaTime * speed, 0, Input.GetAxis ("Vertical2") * Time.deltaTime * speed);
				else
					transform.Translate (Input.GetAxis ("Horizontal2") * Time.deltaTime * speed, 0, 0);
			} else { 
				if (Input.GetAxis ("Vertical2") > buffer || Input.GetAxis ("Vertical2") < buffer * -1)
					transform.Translate (0, 0, Input.GetAxis ("Vertical2") * Time.deltaTime * speed);
				else
					transform.Translate (0, 0, 0);
			}
		}
	}
}
