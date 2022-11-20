using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	public int loadSceneNumber = 1;    //１ステージ目のビルド設定 シーン番号
	public float waiteForSecons = 2.0f;

	void Start () {
		// コルーチンを実行
		StartCoroutine ("CallStartStage");  
	}  

	// コルーチンの実装
	private IEnumerator CallStartStage() {  
		// 指定秒数後に次のシーンをロードする
		yield return new WaitForSeconds (waiteForSecons);

		SceneManager.LoadScene (loadSceneNumber);
	}  

}
