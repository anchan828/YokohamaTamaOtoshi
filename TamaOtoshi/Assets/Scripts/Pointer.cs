using UnityEngine;
using System.Collections;

public class Pointer : MonoBehaviour
{
	private int point = 0;

	void OnTriggerEnter (Collider c)
	{
		Debug.Log ("call");
		if (c.name.Equals ("Ball(Clone)")) {
			point++;
			Destroy (c.gameObject);
		}
	}
	
	void OnGUI ()
	{
		GUILayout.Label ("" + point);
	}
}
