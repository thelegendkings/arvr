using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform plane; // Reference to the plane GameObject

    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // Apply movement to the sphere
        GetComponent<Rigidbody>().AddForce(moveDirection * moveSpeed);

        // Move the plane with the sphere
        if (plane != null)
        {
            plane.position = transform.position + Vector3.down * 0.5f; // Adjust the value as needed to position the plane under the sphere
        }
    }
}