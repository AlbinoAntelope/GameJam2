using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float speed = 0.01f;
	public float direction;

	// Use this for initialization
	void Start () {
		// Intially Enemy has no direction
		direction = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * direction * speed);
	}

	void OnCollisionEnter (Collision collision) {
		GameObject gameObj = collision.collider.gameObject;

		if (gameObj.CompareTag ("Shot1")) {
			direction = 1;
		}
		if (gameObj.CompareTag ("Shot2")) {
			direction = -1;
		}
	}
}
