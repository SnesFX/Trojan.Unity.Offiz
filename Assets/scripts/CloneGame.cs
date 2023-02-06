using UnityEngine;
using UnityEngine.SceneManagement;

public class CloneGame : MonoBehaviour
{
    public float cloneDelay = 1.0f;

    private void Start()
    {
        InvokeRepeating("Clone", cloneDelay, cloneDelay);
    }

    public void Clone()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
