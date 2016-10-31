using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Lava : MonoBehaviour {

	public float speed;
	public string nextLevel = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0, 0, speed * Time.deltaTime);
		if (Input.GetKeyDown ("joystick 1 button 1") || Input.GetKeyDown("joystick 1 button 17")) 
			SceneManager.LoadScene ("MainMenu");
	}

	void OnTriggerEnter(Collider coll) {
		if (coll.tag == "Player1" || coll.tag == "Player2") {
			 SceneManager.LoadScene (nextLevel);
		}

	}
}
