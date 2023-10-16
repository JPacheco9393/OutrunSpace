using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenProjectile : MonoBehaviour
{
    Rigidbody2D rb;

    void Awake(){
        rb=GetComponent<Rigidbody2D>();
    }

    void Start(){
        rb.velocity = new Vector3(0,0,0);
        
    }
    public void Launch(Vector3 targetPosition){
        rb.velocity = targetPosition - transform.position;
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            Debug.Log("OnTriggerEnter2D for Obstacle on TokenProjectile.cs has worked");
            PointsHandler.singleton.AddPoint();
            Destroy(this.gameObject);
        }
    }
}