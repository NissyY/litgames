using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	float X_Speed = 0.1f;
	float Y_Speed = 0.05f;

	public GameObject Prefab;
	float intervalTime;

	void Start () {

		intervalTime = 0;
	
	}
	void Update () {
		float vertical = Input.GetAxis("Vertical");//-1~1 get value
		float horizontal = Input.GetAxis("Horizontal");//-1~1 get value

//		if (Input.GetKey("left")) {
//			transform.Translate(horizontal * X_Speed, 0, 0);
//			transform.Rotate(0, 0.3f, 0);
//		}
//		if(Input.GetKey("right")){
//			transform.Translate(horizontal * X_Speed, 0, 0);
//			transform.Rotate(0, -0.3f, 0);
//		}
		if(Input.GetKeyDown("left")){
			transform.Rotate(0, -30, 0);
		}
		if(Input.GetKey("up")){
			transform.Translate(0, vertical * Y_Speed, 0);
		}
		if(Input.GetKey("down")){
			transform.Translate(0, vertical * Y_Speed, 0);
		}
		//up down 
		Vector3 pos = transform.position;
		//pos.y = Mathf.Clamp(transform.position.y, 9.0f, 11.2f);
		//transform.position = pos;
	
		intervalTime += Time.deltaTime;//nowFlame time - beforeFlame time
		if (Input.GetKey ("space")) {
			if (intervalTime >= 0.2f) {
				intervalTime = 0.0f;
				Instantiate (Prefab, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			}
		}
	}
}