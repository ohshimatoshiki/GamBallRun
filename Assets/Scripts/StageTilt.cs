using UnityEngine;

public class StageTilt : MonoBehaviour
{
    [SerializeField] private float maxTilt = 24f;
    [SerializeField] private float tiltSpeed = 2f;
    [SerializeField] private float tiltForward = 6f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Quaternion targetRotation = Quaternion.Euler(
            horizontal * maxTilt,
            0f,
            tiltForward
        );

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            tiltSpeed * Time.deltaTime
        );
    }
}