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
        var animator = GetComponent<Animator>();
        var horiz = Input.GetAxis("Horizontal");
        jump();
        Vector3 movment = new Vector3(horiz, 0f, 0f);
        transform.position += movment * Time.deltaTime * moveSpeed;

        if (Mathf.Approximately(horiz, 0f))
        {
            animator.SetBool("ChickRun", false);

        }
        else
        {
            animator.SetBool("ChickRun", true);
        }



    }

    void jump()
    {
        var animator = GetComponent<Animator>();
        var jumping = Input.GetButtonDown("Jump");
        if (jumping && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 9f), ForceMode2D.Impulse);
        }
        animator.SetBool("ChickJump", !isGrounded);
    }
}
