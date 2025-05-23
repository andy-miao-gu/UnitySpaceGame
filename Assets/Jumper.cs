using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Jumper script started!");
        Jump(); // Initial jump
    }

    void FixedUpdate()
    {
        if (Mathf.Abs(rb.linearVelocity.y) < 0.01f) // Ball nearly on the ground
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}