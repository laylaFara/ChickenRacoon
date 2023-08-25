using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class rakkill : MonoBehaviour {

	//private BrojacZivota brojacZivota;

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

		void OnCollisionEnter2D(Collision2D other)
   {
        if (other.gameObject.tag == "Chicken")
        {
			Smrtabc(other.gameObject);
			GetComponent<Rigidbody2D>().velocity = transform.right * 10f;
		}
     }

	public void Smrtabc(GameObject igracabc) {
		//brojacZivota.ukupnoZivota--;
	    igracabc.transform.position = new Vector3 (-22.08f, -5.16f, 0);
		//if (brojacZivota.ukupnoZivota == 0) {
		//	SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
		//}
	}

}
