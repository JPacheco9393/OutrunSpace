using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerInput : MonoBehaviour{
    [SerializeField] float speed = 1;
    DiscreteMovement movement;
    ThrusterEngine thrusterEngine;
    private Rigidbody2D rb;
    Vector3 vel = Vector3.zero;

        
    Rigidbody2D m_Rigidbody;
    float m_Speed;

    void Awake()
    {
        // movement = GetComponent<DiscreteMovement>();
        // rb = GetComponent<Rigidbody2D>();
        
    }
    void Start(){
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
        //Set the speed of the GameObject
        m_Speed = 2.5f;
    }
    void FixedUpdate(){
        

        if(Input.GetKey(KeyCode.W)){
            //transform.position += new Vector3(0,speed*Time.deltaTime,0);
            //rb.velocity = transform.up * speed;
            //thrusterEngine.ToggleThrusters();
            m_Rigidbody.velocity = -transform.up * m_Speed;
        }
        if(Input.GetKey(KeyCode.S)){
            //transform.position -= new Vector3(0,speed*Time.deltaTime,0);
            
            m_Rigidbody.velocity = transform.up * m_Speed;
        }
        if(Input.GetKey(KeyCode.A)){
            //transform.position -= new Vector3(speed*Time.deltaTime,0,0);
            transform.Rotate(0.0f, 0.0f, (speed*Time.deltaTime)*100);
            //transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * m_Speed, Space.World);
        }
        if(Input.GetKey(KeyCode.D)){
            //transform.position += new Vector3(speed*Time.deltaTime,0,0);
            transform.Rotate(0.0f, 0.0f, (speed*Time.deltaTime)*-100);
            //transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * m_Speed, Space.World);
        }


        //movement.MoveRB(vel);
    }


    // Update is called once per frame
    void Update(){

        movement.MoveTransform(vel);


    }
}
