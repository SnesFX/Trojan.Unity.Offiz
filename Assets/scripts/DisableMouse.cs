using UnityEngine;

public class DisableMouse : MonoBehaviour
{
    private void Update()
    {
        // Check if the mouse position has changed
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            // Discard the input
            Input.ResetInputAxes();
        }
    }
}
