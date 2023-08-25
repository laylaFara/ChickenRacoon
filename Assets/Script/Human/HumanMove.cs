using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMove : MonoBehaviour
{
    public float moveSpeed = 05;
    public bool isGrounded = false;
    public GameObject globalStats;
    public GameObject human;
    public GameObject chickenPrefab;
    public Throw Throw;
    public GameObject projectileracoon;
    public bool hasSpawnedRaccoon = false;
    public float spawnTimer = 60;
    public float spawnCountdown = 0;
    // Start is called before the first frame update
    void Start()
    {
        human = globalStats.GetComponent<GlobalStats>().human;
       
    }

    // Update is called once per frame
    void Update()
    {
        jump();
        var horiz = Input.GetAxis("Horizontal");
        Vector3 movment = new Vector3(horiz, 0f, 0f);
        transform.position += movment * Time.deltaTime * moveSpeed;

        var animator = GetComponent<Animator>();

        if (Mathf.Approximately(horiz, 0f))
        {
            animator.SetBool("IsRunning", false);

        }
        else
        {
            animator.SetBool("IsRunning", true);
        }



        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            GameObject newChicken = Instantiate(chickenPrefab, (human.transform.position + new Vector3(3, 3, 0)), human.transform.rotation);
            Destroy(this.globalStats.GetComponent<GlobalStats>().currentChicken);
            this.globalStats.GetComponent<GlobalStats>().currentChicken = newChicken;
            newChicken.GetComponent<Throw>().globalStats = this.globalStats;
            newChicken.GetComponent<Throw>().thrown = true;
        }

        if(hasSpawnedRaccoon)
        {
            spawnCountdown += Time.deltaTime;
            if(spawnCountdown > spawnTimer)
            {
                spawnCountdown = 0;
                hasSpawnedRaccoon = false;
            }
        }

    }

    void jump()
    {
        var animator = GetComponent<Animator>();
        var jumping = Input.GetButtonDown("Jump");
        if (jumping && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 9f), ForceMode2D.Impulse);

        }
        animator.SetBool("IsJumping", !isGrounded);




    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "RacoonComes" && !hasSpawnedRaccoon)
        {
            projectileracoon.GetComponent<ProjectileRaccoon>().Raccooncome();
            Debug.Log("I Enter");
            hasSpawnedRaccoon = true;
        }
    }
}

