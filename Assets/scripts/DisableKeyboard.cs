using UnityEngine;

public class DisableKeyboard : MonoBehaviour
{
    private void Update()
    {
        // Check if any keys are being pressed
        if (Input.anyKey)
        {
            // Discard the input
            Input.ResetInputAxes();
        }
    }
}
