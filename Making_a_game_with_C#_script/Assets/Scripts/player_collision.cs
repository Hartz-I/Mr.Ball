using System.Net.Sockets;
using UnityEngine;

public class player_collision : MonoBehaviour
{
    //connects with the player_movement script
    public player_movement movement;

    //this is made for collision
    //when the current object hits something!
    void OnCollisionEnter(Collision collisionInfo) //gives info about "Collision"
    {
        //finds the name of what we hit!
        //using name can lead to a mistake so we use tag!
        if(collisionInfo.collider.tag == "obsticle")
        {
            //calls the movement script and disables it
            //or we can use GetComponent<player_movement>()
            movement.enabled = false;
            //Linking with game maneger
            Time.timeScale = 0.3f;
            FindObjectOfType<GameManeger>().EndGame();
        } else
        {
            Time.timeScale = 1f;
        }
    }
}
