using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{

	public float move;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			transform.position = new Vector3(0, move, 0);
			move-= 10;
		}
	}
}
