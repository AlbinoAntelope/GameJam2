using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ggscript : MonoBehaviour {
	public Text winText;
	public string blurb;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		GameObject gameObj = other.gameObject;

		if (gameObj.CompareTag ("Enemy")) {
			winText.text = blurb;
		}
	}
}
