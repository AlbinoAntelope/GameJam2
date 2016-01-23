using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour {

	public float speed;
	public float direction;

	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3 (0.0f, direction * speed, 0.0f);
	}

	// Update is called once per frame
	void Update () {

	}
}
