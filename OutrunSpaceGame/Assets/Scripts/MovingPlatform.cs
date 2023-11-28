using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    //public Transform platform;
    public Transform posA, posB;
    //public float speed = 1.5f;
    public float speed;
    Vector3 targetPos;

    //int direction = 1;

    private void Start(){
        targetPos = posB.position;
    }

    private void Update()
    {
        // Vector2 target = currentMovementTarget();

        // platform.position=Vector2.Lerp(platform.position, target, speed*Time.deltaTime);

        // float distance = (target - (Vector2)platform.position).magnitude;
        
        // if (distance <= 0.1f){
        //     direction *= -1;
        // }
        if (Vector2.Distance(transform.position, posA.position) < 0.05f)
        {
            targetPos = posB.position;
        }
        if (Vector2.Distance(transform.position, posB.position) < 0.05f)
        {
            targetPos = posA.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
    }

    // Vector2 currentMovementTarget(){
    //     if (direction == 1){
    //         return startPoint.position;
    //     }
    //     else{
    //         return endPoint.position;
    //     }
    // }

    // private void OnDrawGizmos(){
    //     if(platform!=null && startPoint!=null && endPoint != null){
    //         Gizmos.DrawLine(platform.transform.position, startPoint.position);
    //         Gizmos.DrawLine(platform.transform.position, endPoint.position);
    //     }
    // }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            collision.transform.parent = this.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }
}
