using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    
    float bulletSpeed = 2;
	
    void Start () {
        Destroy(this.gameObject, 5);//deleate
	}

	void Update () {
        transform.Translate(0, 0, bulletSpeed);//bullet go to Z direction 2m/s 
	}
}
