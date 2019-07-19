using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb = new Rigidbody();
    [SerializeField] public float xSpeed = 10;
    [SerializeField] public float ySpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameStart();
    }
    public void gameStart()
    {
        //rb.velocity = Vector3.zero;
        transform.position = new Vector3(0, 0, 0);
        rb.velocity = new Vector3(0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && rb.velocity == Vector3.zero)
        {
            rb.velocity = new Vector3(xSpeed + Random.Range(-1f, 1f), ySpeed + Random.Range(-1f, 1f), 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(rb.velocity.x + Random.Range(-1f, 1f), rb.velocity.y + Random.Range(-1f, 1f), 0);
    }
}
