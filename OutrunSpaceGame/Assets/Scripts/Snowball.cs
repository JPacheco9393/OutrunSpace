using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snowball : MonoBehaviour
{
    Rigidbody2D rb;

    void Awake(){
        rb=GetComponent<Rigidbody2D>();
    }
    void Start(){
        rb.velocity = new Vector3(0,-5,0);
    }
    void OnTriggerEnter2D(Collider2D other){
            if (other.CompareTag("Player")){
            Debug.Log("OnTriggerEnter2D for Obstacle on AsteroidProjectile.cs has worked");
            SceneManager.LoadScene("Main Menu");
            }
        }

    public void Launch(Vector3 targetPosition){
        rb.velocity = targetPosition - transform.position;
    }
}
