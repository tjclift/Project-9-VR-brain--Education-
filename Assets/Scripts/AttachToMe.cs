using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToMe : MonoBehaviour {

    public float distanceFromPlayer;
    public GameObject attachableObject;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        distanceFromPlayer = GameVariables.DistanceFromPlayer(gameObject);
    }

    public void OnMouseEnter()
    {
        if (distanceFromPlayer < 30.0)
        {
            GameVariables.interactAttempt = true;
        }

        if (distanceFromPlayer > 30.0)
        {
            GameVariables.interactAttempt = false;
        }
    }

    public void OnMouseExit()
    {
        GameVariables.interactAttempt = false;
    }

    public void OnMouseDown()
    {
        //Find out if the player is holding an object.
        if (GameVariables.playerHoldingObject == attachableObject && distanceFromPlayer < GameVariables.InteractRange)
        {
            //Player is no longer holding the object.
            GameVariables.playerHasObject = false;

            //Store the game object locally otherwise later we will be referencing a null object.
            GameObject holdingObject = GameVariables.playerHoldingObject;

            //Remove object from the player (Do we need this?)
         //   GameVariables.playerHoldingObject.transform.parent = null;

            //Attach the object to this object
            holdingObject.transform.parent = transform;
            holdingObject.transform.localPosition = new Vector3(0.002f, 0.391f, 0.017f);
            holdingObject.transform.localEulerAngles = new Vector3(0, 0, 0);

        }
    }
}
