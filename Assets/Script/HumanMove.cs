using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMove : MonoBehaviour
{
    public float moveSpeed = 05;
    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        jump();
        var horiz = Input.GetAxis("Horizontal");
        Vector3 movment = new Vector3(horiz, 0f, 0f);
        transform.position += movment * Time.deltaTime * moveSpeed;

        var animator = GetComponent<Animator>();

        if(Mathf.Approximately(horiz, 0f))
        {
            animator.SetBool("IsRunning", false);

        }
        else
        {
            animator.SetBool("IsRunning", true);
        }
    }

    void jump()
    {
         var animator = GetComponent<Animator>();
        var jumping = Input.GetButtonDown("Jump");
        if (jumping && isGrounded )
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 9f), ForceMode2D.Impulse);
           
        }
         animator.SetBool("IsJumping", !isGrounded);

       

      
    }
}

