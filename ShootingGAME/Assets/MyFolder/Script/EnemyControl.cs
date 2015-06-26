using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

	public GameObject Prefab;
	float intervalTime;

	void Start () {
		intervalTime = 0;
	}

	void Update () {
		transform.Rotate (0, 0.5f, 0);

		intervalTime += Time.deltaTime;
		if (intervalTime >= 0.2f) {
			intervalTime = 0.0f;
			Instantiate (Prefab, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		}
	}
}
