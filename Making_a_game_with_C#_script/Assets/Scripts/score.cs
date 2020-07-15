using UnityEngine;
//Use only when working with UI
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    

    // Update is called once per frame
    void Update()
    {

        //adding the player z postion to the text file
        //text must be a string
        scoreText.text = player.position.z.ToString("0");
    }
}
