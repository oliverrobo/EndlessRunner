using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    //Create a reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerobject;

    // Start is called before the first frame update
    void Start()
    {
        // Find the Rigidbody2D component that is attached to the same object as this script
        playerobject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Create a 'float' that will be equal to the players horizontal input
        float movementValuex = Input.GetAxis("Horizontal");

        //Change the x velocity of the Rigidbody2D to be equal to the movement value 
        playerobject.velocity = new Vector2(movementValuex, playerobject.velocity.y);
    }
}
