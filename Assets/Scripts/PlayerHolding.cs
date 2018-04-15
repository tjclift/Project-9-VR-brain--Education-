using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHolding : MonoBehaviour {

    public static bool hasObject;
    public static GameObject holdingObject;
	
	// Update is called once per frame
	void Update ()
    {
        // On left click (we dont need to look at the object to put it down)
        if (Input.GetMouseButtonDown(0))
        {
            // Only occur if we are holding an object.
            if (hasObject)
            {
                //Remove all collisions from this object.
                holdingObject.GetComponent<Collider>().enabled = true;

                //detach object from player
                holdingObject.transform.parent = null;
                holdingObject.GetComponent<Rigidbody>().isKinematic = false;
                holdingObject.GetComponent<Rigidbody>().useGravity = true;

                //Player is no longer holding an object
                PlayerHolding.hasObject = false;
            }
        }


    }

}