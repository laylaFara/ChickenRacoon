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
        var raccooncome = Input.GetKeyDown(KeyCode.LeftAlt);

            if (raccooncome)
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
            //  projectilePrefab.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }


    }
}
