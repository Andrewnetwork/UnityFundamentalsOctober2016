using UnityEngine;
using System.Collections;

public class CubeGameMaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		GameObject pc = GameObject.Find ("PlayerCube");

		print (pc.transform.position [1]);

		if (pc.transform.position [1] < 0) {
			print ("YOU LOSE");
			UnityEngine.SceneManagement.SceneManager.LoadScene ("YouLose");
		}
	}
}
