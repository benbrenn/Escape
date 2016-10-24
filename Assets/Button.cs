using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public GameObject door;
	bool first = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision coll) {
		if (first) {
			Destroy (door);
			this.transform.Translate (0, -0.75f, 0);
			first = false;
			this.GetComponent<Collider> ().enabled = false;
		}
	}

}
