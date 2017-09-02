using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("Quit", 3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Quit() {
		Application.Quit();
	}


}
