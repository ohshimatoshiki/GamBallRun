using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Replay();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            BackToTitle();
        }        
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToTitle()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("Title");
    }
}
