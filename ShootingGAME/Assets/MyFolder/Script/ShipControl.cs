using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {
	
	float X_Speed = 0.1f;
	float Z_Speed = 0.1f;
	
	void Start() {
	}
	
	void Update() {
		
		float vertical = Input.GetAxis("Vertical");
		
		float horizontal = Input.GetAxis("Horizontal");
		
		if (Input.GetKey("up")) {
			transform.Translate(0, 0, vertical * Z_Speed);
		}
		if (Input.GetKey("down")) {
			transform.Translate(0, 0, vertical * Z_Speed);
		}
		if (Input.GetKey ("left")) {
			transform.Translate (horizontal * X_Speed, 0, 0);
		}
		if (Input.GetKey("right")) {
			transform.Translate(horizontal * X_Speed, 0, 0);
		}
	}
}
