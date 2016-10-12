using UnityEngine;
using System.Collections;

public class BuildWallDetect : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Brick")
		{
			GameObject go = GameObject.Find("WallGen");
			WallGen other = (WallGen) go.GetComponent(typeof(WallGen));

			other.buildWall ();

			AudioSource audio = GetComponent<AudioSource>();

			audio.Play();


		}
	}
}
