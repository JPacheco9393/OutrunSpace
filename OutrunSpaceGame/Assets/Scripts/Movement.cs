using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float speed = 5;
    [SerializeField] float jumpForce = 7;
    [SerializeField] AnimationStateChanger animationStateChanger;
    [SerializeField] Transform body;
    AudioSource jumpSound;
    Rigidbody2D rb;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float groundCheckRadius = .25f;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Start(){
        jumpSound=GetComponent<AudioSource>();
    }

    public void Move(Vector3 vel){
        vel *= speed;
        vel.y = rb.velocity.y;
        rb.velocity = vel;
        if(vel.magnitude > 0){
            animationStateChanger?.ChangeAnimationState("Walk",speed/5);

            if(vel.x > 0){
                body.localScale = new Vector3(1,1,1);
            }else if(vel.x < 0){
                body.localScale = new Vector3(-1,1,1);
            }

        }else{
            animationStateChanger?.ChangeAnimationState("Idle");
        }
    }
    public void Stop(){
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
    }
    public void Jump(){
        if(Physics2D.OverlapCircleAll(transform.position-new Vector3(0,.5f,0), 1, groundMask).Length > 0){
            jumpSound.Play();
            rb.AddForce(new Vector3(0,jumpForce,0),ForceMode2D.Impulse);
            Debug.Log("Jump has worked");
        }
          
    }
}