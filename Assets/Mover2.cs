using UnityEngine;

public class Mover2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello Unity!");
        Debug.Log("Game Started");
    }
 
    void FireLaser()
    {
        Debug.Log("Pew Pew!");
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

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Game Running");
        if (Input.GetKey(KeyCode.W))
        {
            move_forward(10f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            move_backward(10f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            move_left(10f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            move_right(10f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireLaser();
        }

    }
}
