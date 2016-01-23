using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour {

	public float speed;
	public float direction;

	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.velocity = transform.forward * speed;
	}

	// Update is called once per frame
	void Update () {

	}
}
