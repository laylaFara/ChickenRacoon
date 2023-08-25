using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanFood : MonoBehaviour
{
    private HumanFoodCounter humanFoodCounter;
    private AudioSource audioKljuc;

    // Start is called before the first frame update
    void Awake(){

        humanFoodCounter = GameObject.Find("HFCounter").GetComponent<HumanFoodCounter>(); // Pronalazi se GO brojKljuceva na kome treba da se pronađe skripta BrojacKljuceva.
        
       // audioKljuc = GameObject.Find("ZvukKljuc").GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    
void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag=="Player") {
            humanFoodCounter.counter++;
            Destroy(this.gameObject);
            
           //   Debug.Log("CUJEM ZVUK");
            //  audioKljuc.Play();
        }

    }
}
