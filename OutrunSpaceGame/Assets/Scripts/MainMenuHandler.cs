using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuHandler : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Overworld");
    }
    public void QuitGame(){
        Debug.Log("QUIT!");
        Application.Quit();
    }
    public void SettingsScreen(){
        SceneManager.LoadScene("Settings Screen");
    }
}
