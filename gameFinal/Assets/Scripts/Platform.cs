using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
<<<<<<< Updated upstream
    public float jumpForce = 50f;
=======
    // Start is called before the first frame update
    void Start()
    {

    }
>>>>>>> Stashed changes

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {

            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);

        }

    }
}
