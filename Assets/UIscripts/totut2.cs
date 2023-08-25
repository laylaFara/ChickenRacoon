using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class totut2 : MonoBehaviour
{
  

    void OnTriggerEnter2D (Collider2D Colider)
	{
		if(Colider.gameObject.tag == "Player"){
		SceneManager.LoadScene(sceneName:"LvLTut2");}
	}
}
