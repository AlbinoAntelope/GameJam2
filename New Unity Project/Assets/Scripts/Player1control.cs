using UnityEngine;
using System.Collections;

public class Player1control : MonoBehaviour {
	
	public float speed;
	public float tilt;
	public Boundary boundary;

	[System.Serializable]
	public class Boundary{
		public float xMin, xMax;
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("H_1");
		Vector3 moveVector = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.velocity = moveVector * speed;
		rb.position = new Vector3
			(
				Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
				rb.position.y,
				0.0f
			);
		rb.rotation = Quaternion.Euler (0.0f, 0.0f, moveHorizontal * -tilt);
	}
}
