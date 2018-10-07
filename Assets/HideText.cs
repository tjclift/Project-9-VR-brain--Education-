using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideText : MonoBehaviour {

	public GameObject text1;
	int count=0;

	public void JaduSee(){
		
		print ("jaduuuu");
		count++;
		if (count % 2 == 1) {
			text1.SetActive (true);
		} else {
			text1.SetActive (false);
		}
	}
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
