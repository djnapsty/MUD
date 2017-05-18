using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GREENBUTTON : MonoBehaviour {
	public character player;
	public int greenTarget;

	[SerializeField] private Button MyButton = null; // assign in the editor
	void Start()
	{ 
		MyButton.onClick.AddListener(() => { levelUp();});
	}
	void levelUp()
	{
		greenTarget = player.greenLevelTarget;
		if (player.greenFood >= greenTarget) {

			player.charLevel++;
			player.greenFood -= greenTarget;
			player.attack++;
			player.attack++;
			player.greenLevelTarget *= 2;

		}

	}
}
