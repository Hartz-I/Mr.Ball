using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
