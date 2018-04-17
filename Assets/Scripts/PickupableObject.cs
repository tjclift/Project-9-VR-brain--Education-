using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableObject : MonoBehaviour
{
    private float distanceFromPlayer;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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


    public void OnMouseUp()
    {
        // First make sure the object isn't already attached to the player and the player is within proximity.
        if (!GameVariables.playerHasObject && distanceFromPlayer < GameVariables.InteractRange)

        {
            //Remove physics from this object.
            this.GetComponent<Collider>().enabled = false;
            this.GetComponent<Rigidbody>().isKinematic = true;
            this.GetComponent<Rigidbody>().useGravity = false;

            //attach object to the player.
            transform.parent = GameVariables.Player.transform;
            this.transform.localPosition = new Vector3(0.63f, 0.25f, 1.20f);
            this.transform.localEulerAngles = new Vector3(0, 0, 0);

            //Player is now holding an object
            GameVariables.playerHasObject = true;
            GameVariables.playerHoldingObject = gameObject;
        }

    }
}

