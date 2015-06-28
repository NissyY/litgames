using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	PlayerControl playercontrol;
	
	float bulletSpeed = 1.0f;
	
	void Start () {
		Destroy (this.gameObject, 5);//own destroy after 5seconds
	}
	
	void Update () {
		transform.Translate (transform.forward * bulletSpeed);//go z direction: speed = bulletSpeed 
	}
}
