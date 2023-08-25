using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject human;
    public float speed = 6;
    public bool thrown = false;
    public Vector3 launchoffset;
    public GameObject globalStats;

    // Start is called before the first frame update
    void Start()
    {
        human = globalStats.GetComponent<GlobalStats>().human;
        if (thrown)
        {

            {
               // Destroy();
                var direction = transform.right + transform.up;
                GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);

            }
            transform.Translate(launchoffset);
            thrown = false;
        }
    }
   

    // Update is called once per frame
    void Update()
    {
/*        if (!thrown)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }*/

    }

    // for come back the chicken to human after get human food
    // if we have time change the code to show completely the reture 

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "HumanFood")
        {
            Emerge();
         }
       /* else
        {
            Destroy(Chicken);
        }*/
    }

    void Emerge()
    {
        Debug.Log("Happens");
        GameObject newChicken = Instantiate(this.gameObject, (human.transform.position + new Vector3(0,1,0)), human.transform.rotation);
        this.globalStats.GetComponent<GlobalStats>().currentChicken = newChicken;
        newChicken.GetComponent<Throw>().globalStats = this.globalStats;
        Destroy(this.gameObject);
    }
     


}
