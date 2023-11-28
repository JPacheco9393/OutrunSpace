using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] protected float speed = 5;
    [SerializeField] float jumpForce = 5;
    [SerializeField] AnimationStateChanger animationStateChanger;
    [SerializeField] Transform body;
  
    protected Rigidbody2D rb;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float groundCheckRadius = .75f;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Start(){

    }

    public void MoveRB(Vector3 vel){
        rb.velocity = vel * speed;
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
        if(Physics2D.OverlapCircleAll(transform.position-new Vector3(0,.5f,0),groundCheckRadius,groundMask).Length > 0){
            rb.AddForce(new Vector3(0,jumpForce,0),ForceMode2D.Impulse);
        }
          
    }
}