using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautDiscreteMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 10;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveTransform(Vector3 vel){
        transform.position += vel * Time.deltaTime;
    }

    public void MoveRB(Vector3 vel){
        rb.velocity = vel * speed;
    }
}
