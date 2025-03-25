using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public float speed = 2;
    Animator animator;
    SpriteRenderer sr;
    public bool canRun = true;
    public bool canAttack = true;
    public float gravity = 0.075f;
    public float jump = 0.1f;
    void Start()
    {
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

  
    void Update()
    {
        
        Vector3 pos = transform.position;
        
        float direction = Input.GetAxis("Horizontal");
        sr.flipX = direction < 0;

        animator.SetFloat("speed", Mathf.Abs(direction));

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("attack");
            canRun = false;
        }

        if(canRun == true)
        {
            pos += transform.right * direction * speed * Time.deltaTime;
        }       

        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("jump");
            canAttack = false;
            pos.y += jump;
            
        }
        
        if (pos.y > 0)
        {
            pos.y -= gravity;
        }
        else
        {
            pos.y = 0;
        }
        transform.position = pos;
    }
    public void AttackHasFinished()
    {
        canRun = true;
    }

    public void JumpHasFinished()
    {
        canAttack = true;
    }
}
