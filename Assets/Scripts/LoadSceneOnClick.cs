using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour {

	public void NextLevelButton(string levelName)
	{
		SceneManager.LoadScene (1);
	}
}