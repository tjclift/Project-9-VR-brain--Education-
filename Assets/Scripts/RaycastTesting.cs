using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTesting : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        Vector3 fwd = transform.TransformDirection(Vector3.back);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, fwd, out hit, 5.5f))
        {
            print("There is something in front of the object!");
            Debug.Log(hit.transform.gameObject.name);
            Debug.Log(hit.distance);

            if (hit.transform.gameObject.name == "Player")
            {
                transform.GetComponent<Renderer>().material.color = Color.blue;
            }

            if (hit.transform.gameObject.name == "fNRIS Hat")
            {
                transform.GetComponent<Renderer>().material.color = Color.black;
            }
        }
        else
        {
            transform.GetComponent<Renderer>().material.color = Color.white;
        }
            
    }
}
