using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class android_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float side_movement=70;
    public void move_right()
    {
        rb.AddForce(side_movement*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void move_left()
    {
        rb.AddForce(-side_movement*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
