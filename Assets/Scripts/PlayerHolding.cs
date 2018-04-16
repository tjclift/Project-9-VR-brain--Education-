using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHolding : MonoBehaviour {

    public static bool hasObject;
    public static GameObject holdingObject;

    // Update is called once per frame
    void Update ()
    {
        // Only occur if we are holding an object.
        if (hasObject)
        {
            // On left click (we dont need to look at the object to put it down)
            if (Input.GetMouseButtonDown(0))
        {
                //Add collisions back to this object.
                holdingObject.GetComponent<Collider>().enabled = true;

                //detach object from player
                holdingObject.transform.parent = null;
                holdingObject.GetComponent<Rigidbody>().isKinematic = false;
                holdingObject.GetComponent<Rigidbody>().useGravity = true;

                //Player is no longer holding an object
                hasObject = false;
            }
        }


    }

}