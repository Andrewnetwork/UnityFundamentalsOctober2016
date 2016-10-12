using UnityEngine;
using System.Collections;

public class WallGen : MonoBehaviour {

	public GameObject brick;
	// Use this for initialization
	public void buildWall()
	{
		for (int y = 0; y < 10; y++) {
			for (int x = 0; x < 10; x++) {
				Instantiate(brick, new Vector3(x+.5f, y+.5f, 0), Quaternion.identity);
			}
		}
	}
}
