using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 1;

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
