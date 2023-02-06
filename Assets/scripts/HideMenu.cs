using UnityEngine;

public class HideMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
