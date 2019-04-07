using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJogador2 : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (0, Input.GetAxis("Mouse Y"), 0);
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0.2f, 0);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, -0.2f, 0);
		}
	}
}
