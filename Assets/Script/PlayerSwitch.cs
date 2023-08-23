using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public HumanMove humancontroller;
    public ChockenMove chickencontroller;
    public bool Player1active = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            SwitchPlayer();
        }
    }

    public void SwitchPlayer()
    {



        if (Player1active)
        {
            humancontroller.enabled = false;
            chickencontroller.enabled = true;
            Player1active = false;
        }

        else
        {
            humancontroller.enabled = true;
            chickencontroller.enabled = false;
            Player1active = true;
        }
    }
    }

