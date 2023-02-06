using UnityEngine;

public class BounceWindow : MonoBehaviour
{
    private float speed = 10.0f;
    private float direction = 1.0f;

    private void Update()
    {
        // Calculate the new position of the window
        float x = direction * speed * Time.deltaTime;
        Rect position = new Rect(x, 0, Screen.width, Screen.height);

        // Update the position of the window
        Screen.SetResolution((int)position.width, (int)position.height, false);

        // Change direction when the window reaches the edge of the screen
        if (position.xMin <= 0 || position.xMax >= Screen.width)
        {
            direction *= -1;
        }
    }
}
