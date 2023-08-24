using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChockenMove : MonoBehaviour
{
    public float moveSpeed = 03;
    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        jump();
        Vector3 movment = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movment * Time.deltaTime * moveSpeed;


    }

    void jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 9f), ForceMode2D.Impulse);
        }
    }
}
