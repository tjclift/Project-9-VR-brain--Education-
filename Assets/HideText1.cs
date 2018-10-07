using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideText1 : MonoBehaviour {

	public GameObject text2;
	int count=0;

	public void JaduSee(){

		print ("jaduuuu");
		count++;
		if (count % 2 == 1) {
			text2.SetActive (true);
		} else {
			text2.SetActive (false);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
