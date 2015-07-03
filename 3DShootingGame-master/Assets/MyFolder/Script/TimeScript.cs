using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScript: MonoBehaviour {
	public float time =  30;
	public GameObject ResetButton;
	public GameObject gameClearText;
	public GameControl gamecontrol;
	public int clearflg;
	void Start () {

		clearflg = 0;
		//float型からint型へCastし、String型に変換して表示
		GetComponent<Text>().text = ((int)time).ToString();
		gameClearText.SetActive(false);
	}
	
	void Update (){
		//1秒に1ずつ減らしていく
		if(GameObject.Find("Main Camera").GetComponent<GameControl>().flg==1){
			time -= Time.deltaTime;
		}
		if (time < 0) {
			StartCoroutine ("GameClear");
		}

		//マイナスは表示しない
		if (time < 0) {
			time = 0;
			GameObject.Find ("Main Camera").GetComponent<GameControl> ().clearFlag = true;
			clearflg = 1;
		}
		GetComponent<Text> ().text = "Time"+((int)time).ToString ();
	}
		IEnumerator GameClear() {
			gameClearText.SetActive(true);
			ResetButton.GetComponent<Button>().interactable = false;
			yield return new WaitForSeconds(2.0f);
			if (Input.GetMouseButtonDown (0)) {
				Application.LoadLevel ("title");
			}
		}
	}