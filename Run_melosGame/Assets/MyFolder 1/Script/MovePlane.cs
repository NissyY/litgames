using UnityEngine;
using System.Collections;

public class MovePlane : MonoBehaviour {


	public GameObject Prefab;
	float intervalTime;

	void Start () {
	}

	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate(0, 1, 0);
		}
		if (Input.GetKey(KeyCode. LeftArrow)) {
			transform.Rotate(0, -1, 0);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Rotate(-0.5f, 0, 0);
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Rotate(0.5f, 0, 0);
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(transform.forward * 0.1f);
		}
		intervalTime += Time.deltaTime;
		if(Input.GetKey("space")){
			if(intervalTime >= 0.1f){
				intervalTime = 0.0f;
				Instantiate(Prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			}
		}
	}
}
