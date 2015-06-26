using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

    public GameObject EnemyBullet;
    public GameObject Explosion;
    float Z_Speed = 0.7f;
    float intervalTime;


	// Use this for initialization
	void Start () {

        intervalTime = 0;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 0, -1 * Z_Speed);

        Quaternion quat = Quaternion.Euler(0, 180, 0);

        intervalTime += Time.deltaTime;
        if (intervalTime >= 2) {
            intervalTime = 0.0f;
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        }
	
	}



	void OnTriggerEnter(Collider coll) { //Attack judge 
        if (coll.gameObject.tag == "PlayerBullet") {//which object touch
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Destroy(this.gameObject);

        }

    }
}
