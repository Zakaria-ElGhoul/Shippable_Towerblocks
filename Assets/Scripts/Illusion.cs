using UnityEngine;
using System.Collections;

public class Illusion : MonoBehaviour
{

	public float move;
	private float posX;
	private float posZ;
	private float rotY;
	// Use this for initialization
	void Start()
	{
		posX = Random.Range(300, -300);
		posZ = Random.Range(300, -300);
		rotY = Random.Range(360, -360);
		transform.Rotate(new Vector3(0, rotY, 0));
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
