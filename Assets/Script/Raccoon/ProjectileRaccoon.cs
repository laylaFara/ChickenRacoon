using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileRaccoon : MonoBehaviour
{
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

        

    }

    public void Raccooncome()
    {
        Instantiate(projectilePrefab, transform.position, transform.rotation);
        Debug.Log("I Spawn");
    }
}
