using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BLUEFOOD : MonoBehaviour {
	public character player;
	public int blueTarget;

	[SerializeField] private Button MyButton = null; // assign in the editor
	void Start()
	{ 
		MyButton.onClick.AddListener(() => { blueLevelUp();});
	}
	void blueLevelUp()
	{
		blueTarget = player.blueLevelTarget;
		if (player.blueFood >= blueTarget) {

			player.charLevel++;
			player.blueFood -= blueTarget;
			player.defense++;
			player.defense++;
			player.blueLevelTarget *= blueTarget / 5;

		}

	}
}
