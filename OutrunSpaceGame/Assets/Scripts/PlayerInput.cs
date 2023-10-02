using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] float speed = 1;
    DiscreteMovement movement;
    //ProjectileThrower projectileThrower;
    //PointsHandler pointsHandler;

    void Awake()
    {
        movement = GetComponent<DiscreteMovement>();
        //pointsHandler = GameObject.Find("PointsHandler").GetComponent<PointsHandler>;
        //pointsHandler = GameObject.FindGameObjectWithTag("PointsHandler").GetComponent<PointsHandler>();
        //pointsHandler=PointsHandler.singleton;
        
    }
    void Start(){
        //pointsHandler = PointsHandler.singleton;
    }
    void FixedUpdate(){
        Vector3 vel = Vector3.zero;

        if(Input.GetKey(KeyCode.A)){
            transform.position -= new Vector3(speed*Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(speed*Time.deltaTime,0,0);
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
