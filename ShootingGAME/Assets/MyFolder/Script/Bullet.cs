using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	PlayerControl playercontrol;

	float bulletSpeed = 0.5f;
	
	void Start () {
		Destroy (this.gameObject, 4);//own destroy after 5seconds
	}

	void Update () {
		transform.Translate (transform.forward * bulletSpeed);//go z direction: speed = bulletSpeed 
	}
}
