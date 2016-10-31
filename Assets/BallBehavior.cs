 using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {

	public GameObject door;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider coll) {
		if (coll.tag == "Bubble1") {
			transform.SetParent (coll.transform);
			transform.position = coll.transform.position;
			Destroy (door);

		}
		if (coll.tag == "Bubble2") {
			transform.SetParent(coll.transform);
			transform.position = coll.transform.position;
			Destroy (door);
		}
	}

	void OnTriggerStay(Collider coll) {

		if (coll.tag == "Player1") {
			if (Input.GetButton ("RB")) { 
				transform.SetParent (coll.transform);
				transform.position = new Vector3 (coll.transform.position.x, 0, coll.transform.position.z + 1);

			}
		}


		if (coll.tag == "Player2") {
			if (Input.GetButton ("LB")) { 
				transform.SetParent (coll.transform);
				transform.position = new Vector3 (coll.transform.position.x, 0, coll.transform.position.z + 1);
			}
		}
	}
}
