using UnityEngine;
using System.Collections;

public class MovePlane : MonoBehaviour {

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
	}
}
