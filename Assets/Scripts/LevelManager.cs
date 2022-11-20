using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelManager
{
	public static int NowStage = 1;

	public static void Next ()
	{
		if (NowStage == 0) NowStage++;	// 安直なステージ遷移バグ回避

        NowStage++;

		if (NowStage < SceneManager.sceneCountInBuildSettings) {	
			load (NowStage);
		} else {
			Reset ();
		}

		Debug.Log("LeveManager Next() " + "NowStage is :" + NowStage + " sceneCountInBuildSettings is:" + SceneManager.sceneCountInBuildSettings);
	}

	public static void Reset ()
	{
		NowStage = 0;
		load (NowStage);
	}

	private static void load (int stage)
	{
		SceneManager.LoadScene (stage);
	}

}
