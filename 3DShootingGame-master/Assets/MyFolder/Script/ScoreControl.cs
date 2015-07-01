using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScrpt : MonoBehaviour {
	
	private int score = 0;
	
	void Start () {

		GetComponent<Text>().text = "Score: " + score.ToString();
	}

	public void AddPoint (int point) {
		score = score + point;
		GetComponent<Text>().text = "Score: " + score.ToString();
	}
}