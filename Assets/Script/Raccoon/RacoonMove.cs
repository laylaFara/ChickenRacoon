using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacoonMove : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.right * 10f;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);


    }

   
}
