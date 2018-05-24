using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTesting : MonoBehaviour {

    public static RaycastHit hit;
    public static GameObject hitObject;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, 3.0f))
        {
            hitObject = hit.transform.gameObject;
            print(hitObject.name.ToString() + " - Distance: " + hit.distance.ToString());
        }
        else
        {
            hitObject = null;
        }
            
    }
}
