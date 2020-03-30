using UnityEngine;
using System.Collections;

public class Grass_Illusion : MonoBehaviour
{

	public float move;
	private float posX;
	private float posZ;
	// Use this for initialization
	void Start()
	{
		posX = Random.Range(300, -300);
		posZ = Random.Range(300, -300);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			transform.position = new Vector3(posX, move, posZ);
			posX -= 5;
			posZ -= 5;
			move -= 10;
		}
		
	}
}
