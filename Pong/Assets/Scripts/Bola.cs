using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

	Rigidbody2D bola;
	float aleatorioX;
	float aleatorioY;

	// Use this for initialization
	void Start () {
		bola = GetComponent <Rigidbody2D> ();
		//bola.AddForce (new Vector2 (0.05f, 0.05f));
		aleatorioX = Random.Range (0, 10);
		aleatorioY = Random.Range (0.010f, -0.02f);

		if (aleatorioX < 5) {
			bola.AddForce (new Vector2 (-0.07f, aleatorioY));
		} else {
			bola.AddForce (new Vector2 (0.07f, aleatorioY));
		}
	}

	void Update() {
		if (bola.velocity.magnitude > 15) {
			bola.velocity *= 0.9f;
		}

		if (bola.velocity.magnitude < 3) {
			bola.velocity *= 3f;
		}
	}

	//OnCollisionEnter2D(Collision2D outro) {
		//if (outro.gameObject.tag == "Player") {
			//bola.vellocity = bola.vellocity + outro.gameObject.bola.vellocity;
		//}
	//}

	void OnTriggerEnter2D (Collider2D parede) {
		if (parede.gameObject.tag == "ColisaoE") {
			Pontos.ptsp1++;
			Debug.Log (Pontos.ptsp1 + "player2 pontuou");
		} else if (parede.gameObject.tag == "ColisaoD") {
			Pontos.ptsp2++;
			Debug.Log (Pontos.ptsp2 + "player1 pontuou");
		}
	}

	void OnTriggerExit2D (Collider2D parede) {
		if (parede.gameObject.tag == "ColisaoD" || parede.gameObject.tag == "ColisaoE") {
			transform.position = new Vector3 (0, 0, transform.position.z);
			bola.velocity = new Vector2 (0, 0);
			Time.timeScale = 1;
		}
	}
}