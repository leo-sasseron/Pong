using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pontos : MonoBehaviour {

	public static int ptsp1;
	public static int ptsp2;

	public Text score1;
	public Text score2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		score1.text = ptsp1.ToString();
		score2.text = ptsp2.ToString();
	}
		
}
