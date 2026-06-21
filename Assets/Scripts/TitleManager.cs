using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private GameObject titlePanel;
    [SerializeField] private GameObject howToPlayPanel;

    private void Start()
    {
        Time.timeScale = 1f;
        ShowTitle();
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void ShowHowToPlay()
    {
        if(howToPlayPanel != null)
        {
            howToPlayPanel.SetActive(true);
        }
        if(titlePanel != null)
        {
            titlePanel.SetActive(false);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToTitle()
    {
        ShowTitle();
    }

    public void ShowTitle()
    {
        if(howToPlayPanel != null)
        {
            howToPlayPanel.SetActive(false);
        }
        if(titlePanel != null)
        {
            titlePanel.SetActive(true);
        }
    }
}