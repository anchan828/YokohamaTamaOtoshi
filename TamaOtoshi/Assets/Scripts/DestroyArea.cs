using UnityEngine;
using System.Collections;

public class DestroyArea : MonoBehaviour
{

	void OnTriggerEnter (Collider c)
	{
		Destroy (c.gameObject);
	}
}
