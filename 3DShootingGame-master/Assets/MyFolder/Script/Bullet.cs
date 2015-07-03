using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    
    float bulletSpeed = 2;
	public int resultscore;
	void Start () {
		Destroy (this.gameObject, 5);
	}
	void Update () {
        transform.Translate(0, 0, bulletSpeed);
	}
	void OnTriggerEnter(Collider coll) {
		if ((coll.gameObject.tag == "Enemy") || (coll.gameObject.tag == "EnemyBullet")) {
			Destroy (this.gameObject);
			resultscore = GameObject.Find ("Canvas").GetComponent<ScoreControl> ().score;
			resultscore = resultscore+1;
		}

	}
}