using UnityEngine;
using System.Collections;

public class BirdMove : MonoBehaviour 
{
	public float Speed;
	void FixedUpdate()
	{
		if (Input.touchCount > 0)
		//if (Input.GetKey ("space")) 
		{
			rigidbody.velocity = transform.forward * Speed;
		} 
		else 
		{
			rigidbody.velocity = transform.forward * -Speed * 2;
		}

	}
}
