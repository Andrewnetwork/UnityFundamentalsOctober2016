using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour {

	public float turnSpeed = 4.0f;
	public Transform player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = new Vector3(player.position.x, player.position.y + 8.0f, player.position.z + 7.0f);
	}
	
	// Update is called once per frame
	void Update () {
		offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
		transform.position = player.position + offset; 
		transform.LookAt(player.position);


	}
}
