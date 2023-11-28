using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovementController : MonoBehaviour
{
    
    [SerializeField] LayerMask groundMask;
    public Transform groundCheck;
    public float groundCheckRadius;
    private bool isTouchingGround;
    
    [SerializeField] Movement movement;


    void Awake(){
    }

    void Start(){
    }

    void FixedUpdate(){
        Vector3 vel = Vector3.zero;
        if(Input.GetKey(KeyCode.A)){
            vel.x = -1;
        }else if(Input.GetKey(KeyCode.D)){
            vel.x = 1;
        }
        else{
            movement.Stop();
        }
        movement.MoveRB(vel);
        if(Input.GetKey(KeyCode.Space)){
            movement.Jump();}


    }

}
