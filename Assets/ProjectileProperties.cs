using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileProperties : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool inside;
    void Awake()
    {
        inside = false;
    }

    void FixedUpdate(){
		if(inside){ //when inside the Magnet apply magnet's forces
			Vector2 direction = (transform.position - rb.transform.position); //find the direction to move
			float travelSpeed = Vector2.Distance(transform.position, rb.transform.position); //set the speed of the score bubble to the distance between it and the player
			rb.AddForce(-direction * travelSpeed); //apply force (This works but can sometimes cause the coins/objects to orbit your player forever
		}
	}
    void OnTriggerEnter2D(Collider2D other){ //score bubble is set to isTrigger (when it enters another collider this is run)
		if(other.tag == "magnet"){ //if inside the magnet
			inside = true;
		}
        else inside = false; //omit this line if you want the coins to only be attracted to your object while within the magnet. I found this line to be unnecessary for gameplay. 
	}
}
