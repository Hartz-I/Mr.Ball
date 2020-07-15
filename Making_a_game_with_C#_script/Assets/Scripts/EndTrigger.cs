using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManeger gameManeger;

    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "player")
        {
            gameManeger.CompleteLevel();
        }
    }
}
