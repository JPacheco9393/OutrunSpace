using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerInput : MonoBehaviour{
    [SerializeField] float speed = 1;
    DiscreteMovement movement;
    ThrusterEngine thrusterEngine;
    private Rigidbody rb;
    Vector3 vel = Vector3.zero;

    void Awake()
    {
        movement = GetComponent<DiscreteMovement>();
        rb = GetComponent<Rigidbody>();
    }
    void Start(){

    }
    void FixedUpdate(){
        

        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0,speed*Time.deltaTime,0);
            thrusterEngine.ToggleThrusters();
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
        // float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");
        // Vector3 movementDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        // movementDirection.Normalize();
        // rb.velocity = movementDirection * speed;

    // Update is called once per frame
    void Update(){

        movement.MoveTransform(vel);


    }
}
