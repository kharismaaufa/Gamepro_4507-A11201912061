using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenMenu : MonoBehaviour
{
    public void LoadNewGame(){
        SceneManager.LoadScene("Main");
    }

    public void MenuGame(){
        SceneManager.LoadScene("Menu");
    }

    public void MenuInsctruction(){
        SceneManager.LoadScene("Insctruction");
    }
}
