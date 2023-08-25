using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class GubljenjeZivota : MonoBehaviour {

	//private BrojacZivota brojacZivota;
	public Transform igrac;

	//void Awake() 
//	{
//		brojacZivota = GameObject.Find ("brojZivota").GetComponent<BrojacZivota> ();
//	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		void OnTriggerEnter2D(Collider2D other)
   {
        if (other.gameObject.tag == "Player")
        {
			Smrt();
        }
     }

	public void Smrt() {
		//brojacZivota.ukupnoZivota--;
	    igrac.transform.position = new Vector3 (-22.08f, -5.16f, 0);
		//if (brojacZivota.ukupnoZivota == 0) {
		//	SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
		//}
	}

}
