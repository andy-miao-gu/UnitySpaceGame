using UnityEngine;

public class Mover3 : MonoBehaviour
{
    private Rigidbody rb;
    private bool isGrounded = true;

    void Start()
    {
        Debug.Log("Hello Unity!");
        Debug.Log("Game Started");
        rb = GetComponent<Rigidbody>();
    }

    void JUMPYHIGH(float height)
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * height, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void move_forward(float speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void move_backward(float speed)
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    void move_left(float speed)
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void move_right(float speed)
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void Update()
    {
        Debug.Log("Game Running");

        if (Input.GetKey(KeyCode.Y)) move_forward(10f);
        if (Input.GetKey(KeyCode.H)) move_backward(10f);
        if (Input.GetKey(KeyCode.G)) move_left(10f);
        if (Input.GetKey(KeyCode.J)) move_right(10f);
        if (Input.GetKeyDown(KeyCode.Space)) JUMPYHIGH(7f); // Use a realistic height value
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
