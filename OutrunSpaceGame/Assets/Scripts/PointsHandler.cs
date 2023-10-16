using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHandler : MonoBehaviour
{
    public static PointsHandler singleton;
    int pointsEarned = 0;
    int score = 0;
    public Text scoreText;

    void Awake(){
        if(singleton==null){
            singleton = this;
        }
        else{
            Destroy(this.gameObject);
        }
    }
    void Start(){
        //scoreText = GetComponent<Text>();
        //StartCoroutine(pointRoutine());
        //scoreText.text=pointsEarned.ToString();
        scoreText.text = score.ToString();
    }
    IEnumerator pointRoutine(){
        while(true){
            yield return new WaitForSeconds(1);
            //pointsEarned += 1;
            scoreText.text=pointsEarned.ToString();
        }
        yield return null;
    }
    public void AddPoint(){
        score += 1;
        scoreText.text = score.ToString();
         }

}
