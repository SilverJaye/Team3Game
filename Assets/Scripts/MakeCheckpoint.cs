using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCheckpoint : MonoBehaviour
{

	GameObject objToSpawn;
	public float waitTime = 0.2f;

	// Draw a line every fram. This is as smooth and fast as Unity can do

	//	void FixedUpdate()
	//	{
	//		objToSpawn = new GameObject ("Checkpoint");
	//		objToSpawn.tag = "Checkpoint";
	//		objToSpawn.transform.position = this.transform.position;
	//	}

	// Draw it after every certain amount of time
	void Start()
	{
		StartCoroutine(DrawPath(waitTime));
	}

	IEnumerator DrawPath(float timeRate)
	{
		while (true)
		{
			objToSpawn = new GameObject("Checkpoint");
			objToSpawn.tag = "Checkpoint";
			objToSpawn.transform.position = this.transform.position;
			// wait before do this again
			yield return new WaitForSeconds(timeRate);
		}
	}

}