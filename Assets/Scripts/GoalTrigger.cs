using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject goalText;

    private bool isGoal = false;

    void Start()
    {
        goalText.SetActive(false); // 最初は非表示
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isGoal) return;

        if (other.CompareTag("Ball"))
        {
            isGoal = true;
            goalText.SetActive(true); // GOAL!を表示

            Time.timeScale = 0f; // 停止する
        }
    }
}