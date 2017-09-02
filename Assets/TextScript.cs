using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(FlashText());
	}

	private IEnumerator FlashText()
	{
		yield return new WaitForSeconds(5);

		Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
