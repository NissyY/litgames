﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    
    float bulletSpeed = 2;

	void Start () {
		Destroy (this.gameObject, 5);
	}
	void Update () {
        transform.Translate(0, 0, bulletSpeed);
	}
	void OnTriggerEnter(Collider coll) {
		if ((coll.gameObject.tag == "Enemy") || (coll.gameObject.tag == "EnemyBullet")) {
			Destroy (this.gameObject);
		}

	}
}