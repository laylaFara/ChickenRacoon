using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject Chicken;
    public GameObject human;
    public float speed = 4;
    public bool thrown;
    public Vector3 launchoffset;

    // Start is called before the first frame update
    void Start()
    {
        if (thrown)
        {
            var direction = -transform.right + transform.up;
            GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);
           

        }
        transform.Translate(launchoffset);
    }

    // Update is called once per frame
    void Update()
    {
     

    }

    // for come back the chicken to human after get human food
    // if we have time change the code to show completely the reture 
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(Chicken);
        Instantiate(Chicken, human.transform.position, human.transform.rotation);
    }

}
