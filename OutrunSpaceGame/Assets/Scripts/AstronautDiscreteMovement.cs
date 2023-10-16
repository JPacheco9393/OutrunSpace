using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautDiscreteMovement : MonoBehaviour
{
    protected Rigidbody2D rb;
    [SerializeField] protected float astroSpeed = 1;
    [SerializeField] float jumpForce = 15;
    [SerializeField] AnimationStateChanger animationStateChanger;
    [SerializeField] Transform body;
    public float mag;

    [SerializeField] LayerMask groundMask;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
        mag = Input.GetAxisRaw("Horizontal");
    }

    // public void AstronautMoveTransform(Vector3 vel){
    //     transform.position += vel * Time.deltaTime;
    // }

    public void AstronautMoveRB(Vector3 vel){
        rb.velocity = vel * astroSpeed;
        //vel *= astroSpeed;
        
        vel.y = rb.velocity.y;
        rb.velocity=vel;
        if(vel.magnitude > 0){
            animationStateChanger.ChangeAnimationState("Walk");
            if(vel.x > 0){
                body.localScale = new Vector3(1,1,1);
            }else if(vel.x < 0){
                body.localScale = new Vector3(-1,1,1);
            }
        }
        else{
            animationStateChanger.ChangeAnimationState("Idle");
        }
    }
    public void Stop(){
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
    }
    public void Jump(){
        if(Physics2D.OverlapCircleAll(transform.position-new Vector3(0, .5f, 0), 1, groundMask).Length > 0){
        rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode2D.Impulse);   
        }
        
    }
}
