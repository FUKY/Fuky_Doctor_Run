using UnityEngine;
using System.Collections;

public class ItemScrips : MonoBehaviour {

	public int key;
	public Sprite sprite;
	// Use this for initialization
	void Start () {
		
	}

	public void Init()
	{

	}

	public void Update()
	{
		transform.Translate (Vector3.left*Time.deltaTime*4.0f);
	}
	
	// Update is called once per frame
	public void UpdateX () {
		gameObject.GetComponent<SpriteRenderer> ().sprite = sprite;
	}
}
