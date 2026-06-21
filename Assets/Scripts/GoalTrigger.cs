using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GoalTrigger : MonoBehaviour
{
    [SerializeField] private GameObject resultPanel;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI rankText;

    private bool isGoal = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isGoal) return;

        if (other.CompareTag("Ball"))
        {
            isGoal = true;

            float clearTime = Time.timeSinceLevelLoad;

            resultPanel.SetActive(true);

            timeText.text = "Time: " + clearTime.ToString("F2");

            if (clearTime <= 40f)
            {
                rankText.text = "Rank: S";
            }
            else if (clearTime <= 60f)
            {
                rankText.text = "Rank: A";
            }
            else if (clearTime <= 90f)
            {
                rankText.text = "Rank: B";
            }
            else
            {
                rankText.text = "Rank: C";
            }

            Time.timeScale = 0f;
        }
    }

    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }
}