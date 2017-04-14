using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class REDBUTTON : MonoBehaviour {
	public character player;
	public int target;

	[SerializeField] private Button MyButton = null; // assign in the editor

	void Start()
	{ 
		MyButton.onClick.AddListener(() => { levelUp();});
	}
	void levelUp()
	{
		target = player.levelTarget;
		if (player.redFood >= target) {
			
			player.charLevel++;
			player.redFood -= target;
			player.attack++;
			player.defense++;
			target *= target / 5;
			
		}
	
	}
		
}
