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
		getPlayerPosition ();
		DEBUG_UI_BUTTON_TEXT.text = "" + player_Position.x + ", " + player_Position.y + ", " + player_Position.z;
		if (Input.GetMouseButtonDown (0))
		{
			Destroy (MyButton.gameObject);
		}
	}



	void getPlayerPosition()
	{
		player_Position = player.gameObject.transform.position;
	}



}
