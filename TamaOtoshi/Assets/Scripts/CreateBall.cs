using UnityEngine;
using System.Collections;

public class CreateBall : MonoBehaviour
{
	
	public GameObject ball;

	void Update ()
	{
		bool isTouch = false;
		
#if UNITY_EDITOR
		isTouch = Input.GetMouseButtonDown (0);
#elif UNITY_ANDROID
			isTouch=Input.touchCount>0;
#endif
		
		if (isTouch) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				Debug.Log (hit.transform.name);
				if (hit.transform.name.Equals ("TouchMe")) {
					Instantiate (ball, hit.point + Vector3.back * 0.5f, Quaternion.identity);
				}
			}
		}
	}
}
