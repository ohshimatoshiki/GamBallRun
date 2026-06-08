using UnityEngine;
using UnityEngine.InputSystem;

public class StageTilt : MonoBehaviour
{
    public float tiltSpeed = 24f;
    public float maxTilt = 16f;


    
    void Update()
    {
        float horizontal = 0f;
        float vertical = 0f;
        
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1f;
        }
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1f;
        }

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            vertical = -1f;
        }
        else if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            vertical = 1f;
        }

        float xTilt = horizontal * maxTilt;
        float zTilt = -vertical * maxTilt;

        Quaternion targetRotation = Quaternion.Euler(xTilt, 0f, zTilt);

        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            tiltSpeed * Time.deltaTime
        );
    }
}