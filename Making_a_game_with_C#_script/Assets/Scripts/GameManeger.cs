using UnityEngine;
//we use it for change of scene
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour
{

    bool game_has_ended = false;

    public GameObject levelcompleteUI;

    public GameObject level_failed_UI;

    public float GameDelay=2;

    public void CompleteLevel()
    {
        levelcompleteUI.SetActive(true);
    }

    public void EndGame()
    {
        if (game_has_ended == false)
        {
            game_has_ended = true;
            Debug.Log("GAME OVER!");
            level_failed_UI.SetActive(true);
            Invoke("restart", GameDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
