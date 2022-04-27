using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    private float moveX;
    float inputHorizontal;
    float inputVertical;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        if(inputHorizontal != 0)
        {
            rb.AddForce(new Vector2(inputHorizontal * moveSpeed, 0f));
        }
        if(inputHorizontal > 0)
        {
            gameObject.transform.localScale = new Vector3(.5f, .5f, .5f);
        }
        if (inputHorizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(-.5f, .5f, .5f);
        }

        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity = velocity;
    }


}
