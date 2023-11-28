using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BluePlanet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //nextLevel = SceneManager.GetActiveScene().buildIndex + 1; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        SceneManager.LoadScene("BluePlanetLevel");
    }
}
