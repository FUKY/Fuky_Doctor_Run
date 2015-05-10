using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public float distanceTime = 3.0f;

	float subTime = 0.0f;

	float startTime = 0.0f;

	public GameObject vatCan;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		subTime = Time.time - startTime;

		if (subTime > distanceTime) {

			Instantiate(vatCan,transform.position,transform.rotation);
			startTime =Time.time;
		}
	}
}
