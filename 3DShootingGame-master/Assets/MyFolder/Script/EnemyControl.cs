using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	public ScoreControl scorecontrol;
    public GameObject EnemyBullet;
    public GameObject Explosion;
	public int addScore = 1;
    float Z_Speed = 0.7f;
    float intervalTime;


	void Start () {
        intervalTime = 0;
		transform.Rotate (0, 180, 0);
//		scorecontrol = GameObject.Find("ScoreControl").GetComponent<ScoreControl>().score;
	}
	void Update () {
        transform.Translate(0, 0, 1 * Z_Speed);
        Quaternion quat = Quaternion.Euler(0, 180, 0);
        intervalTime += Time.deltaTime;
        if (intervalTime >= 1.5f) {
            intervalTime = 0.0f;
            Instantiate(EnemyBullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), quat);
        }
	}
	void OnTriggerEnter(Collider coll) {
        if (coll.gameObject.tag == "PlayerBullet") {
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Destroy(this.gameObject);
//			scorecontrol = scorecontrol + addScore;
        }
    }
}
