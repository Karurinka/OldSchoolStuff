using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeController : MonoBehaviour
{
    public float MoveSpeed;
    public float WaitToReaload;

    private Rigidbody2D enemyRigid;

    private bool moving;
    public float TimeBetweenMove;
    public float timeBetweenMoveCounter;

    public float TimeToMove;
    private float timeToMoveCounter;

    private Vector3 moveDirection;

    private bool reload;

    private GameObject player;


    // Use this for initialization
 
    public void Start()
    {
        enemyRigid = GetComponent<Rigidbody2D>();
        moving = false;

        //timeBetweenMoveCounter = timeBetweenMove;
        //timeToMoveCounter = TimeToMove;

        timeBetweenMoveCounter = Random.Range(TimeBetweenMove * 0.75f, TimeBetweenMove * 1.25f);
        timeToMoveCounter = Random.Range(TimeToMove * 0.75f, TimeToMove * 1.25f);
    }

    // Update is called once per frame
    public void Update()
    {
        if (moving == true)
        {
            timeToMoveCounter -= Time.deltaTime;
            enemyRigid.velocity = moveDirection;

            if (timeToMoveCounter < 0f)
            {
                moving = false;
                //timeBetweenMoveCounter = timeBetweenMove;
                timeBetweenMoveCounter = Random.Range(TimeBetweenMove * 0.75f, TimeBetweenMove * 1.25f);
            }
        }
        else
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            enemyRigid.velocity = Vector2.zero;

            if (timeBetweenMoveCounter < 0f)
            {
                moving = true;
                //timeToMoveCounter = TimeToMove;
                timeToMoveCounter = Random.Range(TimeToMove * 0.75f, TimeToMove * 1.25f);

                moveDirection = new Vector3(Random.Range(-1f, 1f) * MoveSpeed, Random.Range(-1f, 1f) * MoveSpeed, 0f);
            }
        }
        if (reload == true)
        {
            WaitToReaload -= Time.deltaTime;
            if (WaitToReaload < 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                player.SetActive(true);
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.gameObject.name == "Player")
        //{
        //    //Destroy(other.gameObject);
        //    other.gameObject.SetActive(false);
        //    reload = true;

        //    player = other.gameObject;
        //}
    }
}
