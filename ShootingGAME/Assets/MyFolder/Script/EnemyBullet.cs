using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	PlayerControl playercontrol;
	
	float bulletSpeed = 0.2f;
	
	void Start () {
		Destroy (this.gameObject, 6);//own destroy after 5seconds
	}
	
	void Update () {
		transform.Translate (180, 0, bulletSpeed);//go z direction: speed = bulletSpeed 
	}
}
