using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndButton : MonoBehaviour {

	public string nextLevel = "";
	bool first = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision coll) {
		if (first) {

			this.transform.Translate (0, -0.75f, 0);
			first = false;
			this.GetComponent<Collider> ().enabled = false;
			SceneManager.LoadScene (nextLevel);
		}
	}
}
