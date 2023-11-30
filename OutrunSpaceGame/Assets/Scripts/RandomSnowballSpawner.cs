using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSnowballSpawner : MonoBehaviour

{
    [SerializeField] GameObject snowPrefab;

    void Start(){
        SpawnSnowballsOverTime();

    }

    void SpawnSnowballsOverTime(){
        StartCoroutine(SpawnSnowballsOverTimerRoutine());

        IEnumerator SpawnSnowballsOverTimerRoutine()
        {
        while (true){
            yield return new WaitForSeconds(1);
            GameObject newBox = Instantiate(snowPrefab,new Vector3(Random.Range(-5,5),5,0), Quaternion.identity);
            Destroy(newBox, 10); 
        }
        
        

        yield return null;
        }
    }


}

