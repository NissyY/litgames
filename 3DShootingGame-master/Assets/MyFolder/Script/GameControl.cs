using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

    public GameObject GameStartBtn;
    public GameObject starFighterPrefab;
    public GameObject GameOverSet;
    public bool gameFlag;
	public int flg;
	void Start () {
		flg = 0;
        gameFlag = true;
	}
	void Update () {
		if (gameFlag == false) {
			GameOverSet.SetActive (true);   
		}

	}
    public void GameStartButton() {

		Instantiate(starFighterPrefab); 
        GameStartBtn.SetActive(false);
		flg = 1;
	}
    public void GameOverButton() {
        Application.LoadLevel("GameScene01");
    }
}
