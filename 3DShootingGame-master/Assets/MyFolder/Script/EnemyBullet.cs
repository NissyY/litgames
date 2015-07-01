using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	
	float bulletSpeed = 2;
	

	void Start () {
		Destroy(this.gameObject, 5);
	}

	void Update () {
		transform.Translate(0, 0, bulletSpeed);
	}
	void OnTriggerEnter(Collider coll) {
		if (coll.gameObject.tag == "Player") {
			Destroy(this.gameObject);
		}
	}
}
