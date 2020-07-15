using System.Threading;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    // This is a reference to the rigidbody component rb
    // must add rigidbody component also in unity
    public Rigidbody rb;

    //declaring variable for inspector
    public float forward_force = 2000f;
    public float sideways_force = 500f;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    // We are using "FixedUpdate" instead of "Update" 
    // because it is better for messing with physics
    void FixedUpdate()
    {
        //Add a forward force on the z-axi
        rb.AddForce(0, 0, forward_force * Time.deltaTime);


        //adds a force to the right if the key "d" is pressed
        //there are better ways for implementing keys that we can check on the net
        if (Input.GetKey("d"))
        {
            //only executed if the condition is met
            rb.AddForce(sideways_force*Time.deltaTime, 0, 0, ForceMode.VelocityChange );

        }

        //adds a force to the left if the key "a" is pressed
        if (Input.GetKey("a"))
        {
            //only executed if the condition is met
            rb.AddForce(-sideways_force * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }

        // if the ball falls down call the endgame function in GameManeger script
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManeger>().EndGame();
        }
    }
}
