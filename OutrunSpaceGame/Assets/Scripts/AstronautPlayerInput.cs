using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautPlayerInput : MonoBehaviour
{
    [SerializeField] AstronautDiscreteMovement astonautMovement;
    [SerializeField] float astroSpeed = 5;
    //[SerializeField] SpriteRenderer spriteRenderer;

    void Awake(){
        astonautMovement = GetComponent<AstronautDiscreteMovement>();
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
            astonautMovement.Stop();
        }
        // else if(Input.GetKeyDown(KeyCode.D)){
        //     vel.x  = 1;
        // }
        
        if(Input.GetKeyDown(KeyCode.Space)){
            astonautMovement.Jump();
        }
        //astonautMovement.AstronautMoveRB(vel);
    }
}

