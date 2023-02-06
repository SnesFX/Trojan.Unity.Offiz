using System.Diagnostics;
using UnityEngine;

public class CloneWindow : MonoBehaviour
{
    public int numberOfClones = 2;

    public void Clone()
    {
        // Get the path to the current application
        string applicationPath = Application.dataPath.Replace("/Assets", "");

        // Start a new instance of the current application
        Process.Start(applicationPath + "/" + Application.productName + ".exe");
    }

    private void Start()
    {
        for (int i = 0; i < numberOfClones; i++)
        {
            Clone();
        }
    }
}

