using UnityEngine;
using System.Collections;

public class MoveBasket : MonoBehaviour
{

	private Vector3 pos;

	void Start ()
	{
		pos = transform.position;
	}
	
	void Update ()
	{
		transform.position = new Vector3 (pos.x + Mathf.PingPong (Time.time, 4), pos.y, pos.z);
	}
}
