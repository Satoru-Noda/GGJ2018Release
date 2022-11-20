using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LunchStage : MonoBehaviour {

	public int StageNumber = 12;	//ビルド設定のシーン番号 Splashシーン

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (StageNumber);
		}
	}
}
