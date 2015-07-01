using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

    public GameObject GameStartBtn;
    public GameObject starFighterPrefab;
    public GameObject GameOverSet;
    public bool gameFlag;
	public int flg;
	void Start () {
		flg = 1;
        gameFlag = true;
	}
	void Update () {
		if (gameFlag == false) {
			GameOverSet.SetActive (true);   
		}
	}
    public void GameStartButton() {
		//flg = 1;
		Instantiate(starFighterPrefab); 
        GameStartBtn.SetActive(false);
	}
    public void GameOverButton() {
        Application.LoadLevel("GameScene01");
    }
}
