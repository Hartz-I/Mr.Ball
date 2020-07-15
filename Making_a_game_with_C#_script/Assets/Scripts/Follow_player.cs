using System.Collections.Specialized;
using UnityEngine;

public class Follow_player : MonoBehaviour
{
    //variable for adding another object
    //here we add the player with the cam
    public Transform player;

    //stores a vector which has 3 float values
    //good for position
    public Vector3 offset; 

    // Update is called once per frame
    void Update()
    {

        //small t transform is the transform of script object(here camera)
        //so for each frame we are changing camera position with player position
        transform.position = player.position + offset; //offset here makes sure that camera is at a distance from the player
    }
}
