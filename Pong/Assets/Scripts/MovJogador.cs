using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJogador : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0.2f, 0);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, -0.2f, 0);
		}
	}
}
