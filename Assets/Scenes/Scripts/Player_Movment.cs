using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    public float horizontalMovement;
    public float verticalMovement;
    public float playerSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1   
        horizontalMovement = Input.GetAxis("Horizontal") * playerSpeed; // range -10 meter/frame to +10 meter/frame 
        horizontalMovement *= Time.deltaTime; // to change to per second instead of per frame 
        verticalMovement = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;


        // translate along the z axis
        // transform.Translate (x,y,z)
        transform.Translate(horizontalMovement, 0, verticalMovement);
        Debug.Log(horizontalMovement);
        
    }
}
