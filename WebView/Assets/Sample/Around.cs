using UnityEngine;
using System.Collections;

public class Around : MonoBehaviour
{
	void Update ()
	{
		transform.RotateAround (Vector3.zero, Vector3.up, 10 * Time.deltaTime);
	}
}
