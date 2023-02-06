using UnityEngine;

public class BounceCamera : MonoBehaviour
{
    public float bounceSpeed = 1.0f;
    public float bounceAmount = 50.0f;

    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        float x = bounceAmount * Mathf.Sin(Time.time * bounceSpeed);
        float y = bounceAmount * Mathf.Cos(Time.time * bounceSpeed);
        transform.position = originalPosition + new Vector3(x, y, 0);
    }
}
