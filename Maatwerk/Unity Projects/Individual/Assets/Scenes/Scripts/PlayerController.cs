using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Vector2 lastMove;

    private Animator animator;

    private bool move;

    private Rigidbody2D playerRigid;

    private bool Attack;
    public float AttackTime;
    private float AttackTimeCounter;

    // Use this for initialization
    public void Start()
    {
        animator = GetComponent<Animator>();
        playerRigid = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    public void Update()
    {
        move = false;
        if (Attack == false)
        {
            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                playerRigid.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, playerRigid.velocity.y);
                move = true;
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            }

            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            {
                playerRigid.velocity = new Vector2(playerRigid.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
                move = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            }

            if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
            {
                playerRigid.velocity = new Vector2(0f, playerRigid.velocity.y);
            }

            if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
            {
                playerRigid.velocity = new Vector2(playerRigid.velocity.x, 0f);
            }

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                AttackTimeCounter = AttackTime;
                Attack = true;
                playerRigid.velocity = Vector2.zero;
                animator.SetBool("Attacking", true);
            }
        }

        if (AttackTimeCounter > 0)
        {
            AttackTimeCounter -= Time.deltaTime;
        }
        else if (AttackTimeCounter <= 0)
        {
            Attack = false;
            animator.SetBool("Attacking", false);
        }


        animator.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));

        animator.SetBool("Moving", move);
        animator.SetFloat("LastMoveX", lastMove.x);
        animator.SetFloat("LastMoveY", lastMove.y);
    }
}