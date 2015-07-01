using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScript: MonoBehaviour {
	private float time = 30;
	public GameObject ResetButton;
	public GameObject gameClearText;
	public GameControl gamecontrol;
	void Start () {

		//float型からint型へCastし、String型に変換して表示
		GetComponent<Text>().text = ((int)time).ToString();
		gameClearText.SetActive(false);
	}
	
	void Update (){
		//1秒に1ずつ減らしていく
		if(gamecontrol.flg ==1){
			time -= Time.deltaTime;
		}
		if (time < 0) {
			StartCoroutine ("GameClear");
		}
	
		//マイナスは表示しない
		if (time < 0)
			time = 0;
		GetComponent<Text> ().text = ((int)time).ToString ();
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