using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToTitleScreen : MonoBehaviour {

	public void NextLevelButton(string levelName)
	{
		SceneManager.LoadScene (0);
	}
}
