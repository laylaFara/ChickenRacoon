using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFood2 : MonoBehaviour
{
    private ChickenFoodCounter chickenFoodCounter;
    private AudioSource audioKljuc;

    // Start is called before the first frame update
    void Awake()
    {

        chickenFoodCounter = GameObject.Find("BFCounter").GetComponent<ChickenFoodCounter>(); // Pronalazi se GO brojKljuceva na kome treba da se prona?e skripta BrojacKljuceva.

        // audioKljuc = GameObject.Find("ZvukKljuc").GetComponent<AudioSource>();
    }
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("CUJEM ZVUK");
        if (other.gameObject.tag == "Chicken")
        {
            chickenFoodCounter.counter++;
            Destroy(gameObject);

            // Debug.Log("CUJEM ZVUK");
            //  audioKljuc.Play();
        }

    }
}
