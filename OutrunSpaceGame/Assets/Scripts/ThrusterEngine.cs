using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterEngine : MonoBehaviour
{
    public ParticleSystem thruster1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleThrusters(){
        if(thruster1.isPlaying){
            thruster1.Stop();
        }
        else{
            thruster1.Play();
        }
    }
}
