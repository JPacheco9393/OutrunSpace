using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float speed = 1;
    DiscreteMovement movement;


    void Awake()
    {
        movement = GetComponent<DiscreteMovement>();
    }
    void Start(){

    }
    void FixedUpdate(){
        Vector3 vel = Vector3.zero;

        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0,speed*Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position -= new Vector3(0,speed*Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.A)){
            //transform.position -= new Vector3(speed*Time.deltaTime,0,0);
            transform.Rotate(0.0f, 0.0f, (speed*Time.deltaTime)*100);
        }
        if(Input.GetKey(KeyCode.D)){
            //transform.position += new Vector3(speed*Time.deltaTime,0,0);
            transform.Rotate(0.0f, 0.0f, (speed*Time.deltaTime)*-100);
        }


        movement.MoveRB(vel);
    }

    // Update is called once per frame
    void Update(){

        //movement.MoveTransform(vel);
        // if(Input.GetKeyDown(KeyCode.Q)){
        //     projectileThrower.Throw(Vector3.zero);
        // }



    }
}
