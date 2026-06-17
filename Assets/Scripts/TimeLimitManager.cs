using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeLimitManager : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private float timeLimit = 60f;
    [SerializeField] private GameObject timeUpPanel;

    private float remainingTime;
    private bool isRunning = false;

    void Start()
    {
        Time.timeScale = 1f;

        if (timeUpPanel != null)
        {
            timeUpPanel.SetActive(false);
        }

        StartTimer();
    }

    void Update()
    {
        if (!isRunning) return;

        remainingTime -= Time.deltaTime;

        if (remainingTime <= 0f)
        {
            remainingTime = 0f;
            isRunning = false;
            UpdateTimeText();

            TimeUp();
            return;
        }

        UpdateTimeText();
    }

    public void StartTimer()
    {
        remainingTime = timeLimit;
        isRunning = true;
        UpdateTimeText();
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    private void UpdateTimeText()
    {
        timeText.text = "Time: " + remainingTime.ToString("F1");
    }

    private void TimeUp()
    {
        Debug.Log("時間切れ！");

        if (timeUpPanel != null)
        {
            timeUpPanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }
}