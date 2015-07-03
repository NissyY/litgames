using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControl: MonoBehaviour {

	public int score;

	void Start () {
		score = 0;
		GetComponent<Text> ().text = "Break Enemy : " + score.ToString ();
	}

	void Updata(){
		score = GameObject.Find ("Torch").GetComponent<Bullet> ().resultscore;
		GetComponent<Text> ().text = "Break Enemy : " + score.ToString ();
	}
}