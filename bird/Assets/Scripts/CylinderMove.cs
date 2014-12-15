using UnityEngine;
using System.Collections;

public class CylinderMove : MonoBehaviour 
{

	public Vector3 MinPosition;
	public Vector3 MaxPosition;

	public float Speed;

	void FixedUpdate()
	{
		Vector3 pos = transform.position;

		pos.x -= Speed * Time.deltaTime;

		if (pos.x < MinPosition.x) 
		{
			pos.x = MaxPosition.x;
			pos.z = Random.Range(MinPosition.z, MaxPosition.z);
		}

		transform.position = pos;
	}
}
