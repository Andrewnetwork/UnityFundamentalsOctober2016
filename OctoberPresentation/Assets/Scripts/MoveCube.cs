using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

	public float movementSpeed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

		// If we want smoothing: https://unity3d.com/learn/tutorials/topics/scripting/delta-time

		/* Doesn't give us the collision detection we want. 
		transform.Translate (movementSpeed*Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, 
			movementSpeed*Input.GetAxis ("Vertical") * Time.deltaTime );
		*/
	
		Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		rb.MovePosition(transform.position + direction * movementSpeed * Time.deltaTime);

	}
}
