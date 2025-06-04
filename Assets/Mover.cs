using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello Unity!");
        Debug.Log("Game Started");
    }
    void OnCollisionEnter(Collision other) {
    Debug.Log(name + " collided with " + other.gameObject.name);
    }

    void FireLaser()
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("Laser Fired!");
    }


    void move_forward(float speed)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
    }
    void move_backward(float speed)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.back * speed);
    }

    void move_left(float speed)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
    }
    void move_right(float speed)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Game Running");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            move_forward(10f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move_backward(10f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move_left(10f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move_right(10f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireLaser();
        }

    }
}
