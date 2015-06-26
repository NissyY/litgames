using UnityEngine;
using System.Collections;

public class StarfighterControl : MonoBehaviour {

    float X_Speed = 1;
    float Z_Speed = 1;
	float x = 48.6f;
	float y = 10.0f;
    public GameObject Prefab;
    public GameObject EnemyObject;
    public GameObject Explosion;
    float intervalTime;
    float enemyintervalTime;

    
    void Start() {
        intervalTime = 0;
        enemyintervalTime = 0;
    }

    
    void Update() {

		float vertical = Input.GetAxis("Vertical");//-1~1 get value

		float horizontal = Input.GetAxis("Horizontal");//-1~1 get value

		if (Input.GetKey("left")) {
			transform.Translate(horizontal * X_Speed, 0, 0);
		}
		if (Input.GetKey("right")) {
			transform.Translate(horizontal * X_Speed, 0, 0);
		}

        intervalTime += Time.deltaTime;
        if (Input.GetKey("s")) {
            if (intervalTime >= 0.3f) {
                intervalTime = 0.0f;
                Instantiate(Prefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }

        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(transform.position.x, 13.6f, 83.6f);

        transform.position = pos;

        enemyintervalTime += Time.deltaTime; 
        if (enemyintervalTime >= 1.0f) {
            enemyintervalTime = 0;
            Instantiate(EnemyObject, new Vector3(Random.Range(13.6f, 83.6f), transform.position.y, transform.position.z + 200), Quaternion.identity);
        }

    }

    void OnTriggerEnter(Collider coll) {

        if (coll.gameObject.tag == "EnemyBullet") {

			Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);

			Destroy(this.gameObject);
            
			GameObject.Find("Main Camera").GetComponent<GameControl>().gameFlag = false;
        }
    }
}
