using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualController : MonoBehaviour {

	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("ControllerHorizontal");	
		float v = Input.GetAxis ("ControllerVertical");	
		float b = Input.GetAxis ("ControllerTrigger");

		//print ("Keys: " + h + " " + v + " " + b);
		this.gameObject.transform.position += speed * Time.deltaTime * 
			   (h * new Vector3 (1, 0, 0) + v * new Vector3 (0, 0, 1));
	}
}
