using UnityEngine;
using System.Collections;

public class MUDGameController : MonoBehaviour {

	public GameObject[] Redfood;
	const int AMOUNTOFFOOD = 1000;


	void Start ()
	{
		


	}


	
	// Update is called once per frame
	void Update () {
	
	}



void SpawnRedFood()
{
	int RedFoodSpawn = AMOUNTOFFOOD;
	while (RedFoodSpawn > 0)
	{
		float randomX = Random.Range(1.0f ,1000.0f);
		float randomY = Random.Range(1.0f, 10.0f);
		float randomZ = Random.Range(1.0f, 10.0f);

		Redfood[AMOUNTOFFOOD] = GameObject.CreatePrimitive(PrimitiveType.Cube);
		Redfood[AMOUNTOFFOOD].transform.position = new Vector3(randomX , randomY, randomZ);
		Redfood[AMOUNTOFFOOD].transform.localScale = new Vector3 (.1f, .1f, .1f);
		RedFoodSpawn--;
	}
}
}