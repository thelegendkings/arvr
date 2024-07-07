using UnityEngine;

public class BounceObject : MonoBehaviour
{
    public float bounceHeight = 0.1f; // Height of the bounce
    public float bounceSpeed = 0.1f; // Speed of the bounce

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position using a sine function to create a bouncing effect
        float newY = initialPosition.y + Mathf.Sin(Time.time * bounceSpeed) * bounceHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
