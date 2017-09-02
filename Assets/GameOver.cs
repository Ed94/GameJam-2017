using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "enemy") {
			SceneManager.LoadScene("gameover");
		}

		if (other.gameObject.tag == "exit") {
			SceneManager.LoadScene("end");
		}
	}
}
