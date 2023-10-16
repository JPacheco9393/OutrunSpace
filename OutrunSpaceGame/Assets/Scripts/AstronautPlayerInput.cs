using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautPlayerInput : MonoBehaviour
{
    AstronautDiscreteMovement movement;

    void Awake(){
        movement = GetComponent<AstronautDiscreteMovement>();
    }

    void Update()
    {
        Vector3 vel = Vector3.zero;
        if(Input.GetKeyDown(KeyCode.W)){
            vel.y = 1;
        }else if(Input.GetKeyDown(KeyCode.S)){
            vel.y = -1;
        }else if(Input.GetKeyDown(KeyCode.A)){
            vel.x = -1;
        }else if(Input.GetKeyDown(KeyCode.D)){
            vel.x  = 1;
        }
        movement.MoveTransform(vel);
    }
}

