using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DEBUG_UI_BUTTON : MonoBehaviour {
	public GameObject player;
	public Text DEBUG_UI_BUTTON_TEXT;
	Vector3 player_Position;


	[SerializeField] private Button MyButton = null;

	void Update ()
	{
		//display player x,y,z
		getPlayerPosition ();
		DEBUG_UI_BUTTON_TEXT.text = "PLAYER POSITION:\n" +  
			player_Position.x.ToString("F3") + ", \n" + 
			player_Position.y.ToString("F3")+ ", \n" + 
			player_Position.z.ToString("F3");



		if (Input.GetMouseButtonDown (0)) //click to destroy debug button
		{
			Destroy (MyButton.gameObject);
		}
	}



	void getPlayerPosition()
	{
		player_Position = player.gameObject.transform.position;
	}



}
