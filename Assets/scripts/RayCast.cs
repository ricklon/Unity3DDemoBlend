using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	float distance = 1000.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			//Debug.Log ("MouseDown");

			Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			/*
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, 100)) {
				Debug.Log("Hit something");
			}*/

			if (Physics.Raycast(rayOrigin, out hitInfo, distance))
			{
				Debug.Log("Cast an array: " + hitInfo.transform.tag);
				Debug.DrawLine (rayOrigin.direction, hitInfo.point);
				//adjust camera to attempt to look at target or point clicked on
				//not quite right yet
				transform.LookAt(hitInfo.point);
			}
		}



	}
}
