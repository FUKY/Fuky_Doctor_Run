using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public float distanceTime = 3.0f;
	public GameObject item;
	float subTime = 0.0f;

	float startTime = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		subTime = Time.time - startTime;
		int num = Random.Range (0,ResourceController.Instance.MedicineLibrary.Count);
		if (subTime > distanceTime) {

			GameObject prefab = Instantiate(item);
			ItemScrips itemScript = prefab.GetComponent<ItemScrips>();
			itemScript.key = num;
			itemScript.sprite = ResourceController.Instance.MedicineLibrary[num];
			prefab.transform.SetParent(transform);
			itemScript.UpdateX();
			startTime =Time.time;
		}
	}
}
