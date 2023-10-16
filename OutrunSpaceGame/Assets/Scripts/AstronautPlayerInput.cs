using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautPlayerInput : MonoBehaviour
{
    [SerializeField] AstronautMovement astronautMovement;
    [SerializeField] float astroSpeed = 1;
    //[SerializeField] SpriteRenderer spriteRenderer;

    void Awake(){
        astronautMovement = GetComponent<AstronautMovement>();
    }
    void Start(){
    }

    void FixedUpdate()
    {
        Vector3 vel = Vector3.zero;
        // if(Input.GetKeyDown(KeyCode.W)){
        //     vel.y = 1;
        // }else 
        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(astroSpeed*Time.deltaTime,0,0);
        }else if(Input.GetKey(KeyCode.A)){
            transform.position -= new Vector3(astroSpeed*Time.deltaTime,0,0);
            //spriteRenderer.flipX = true;
        }
        else{
            astronautMovement.Stop();
        }
        // else if(Input.GetKeyDown(KeyCode.D)){
        //     vel.x  = 1;
        // }
        
        if(Input.GetKey(KeyCode.Space)){
            astronautMovement.Jump();
        }
        //astonautMovement.AstronautMoveRB(vel);
    }
}

