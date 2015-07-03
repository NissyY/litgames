using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour {
	
	public int score = 0;
	public Rect point = new Rect(0, 0, 100, 100);
	void Start () {
		score = 0;
	}

	void OnGUI(){
//		GUI.Label (point, "" + GameObject.Find("DroidFighter").GetComponent<EnemyControl>().scorecontrol);
	}

	void Updata(){
//		GameObject.Find("DroidFighter").GetComponent<EnemyControl>().scorecontrol;
	}
	public void AddScore (float addScore) {
		//score += addScore;
	}
}