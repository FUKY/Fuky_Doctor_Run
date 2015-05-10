using UnityEngine;
using System.Collections;

public class MapMove : MonoBehaviour {

	private Vector3 velocity = Vector3.zero;

	public float moveSpeedMap = 2.0f;

	public Transform startTranform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = transform.position;

		newPos.x += Time.deltaTime*-moveSpeedMap;

		transform.position = newPos;

		if (newPos.x < -20) {
			transform.position = startTranform.position;
		}
		//transform.Translate (-Vector3.right*Time.deltaTime*moveSpeedMap);
		//transform.position = Vector3.SmoothDamp(transform.position,new Vector3(-100.0f,0,0),ref velocity, 10.5f);
	}
}
