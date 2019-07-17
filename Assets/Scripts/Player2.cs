using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 1;
    Ball ball = new Ball();
    Rigidbody rb = new Rigidbody();
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.position = Mathf.Clamp(rb.position,new Vector3(24, -8, 0),new Vector3(24,8,0));
        
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.MovePosition(transform.position + transform.up * MoveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.MovePosition(transform.position - transform.up * MoveSpeed * Time.deltaTime);
        }

        Vector3 position = rb.position;
        position.y = Mathf.Clamp(position.y, -8, 8);
        //rb.position = position;
        transform.position = position;

        //Debug.Log(transform.position + ", " + rb.position);
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        ball.BallScored();
    }
    */
}
