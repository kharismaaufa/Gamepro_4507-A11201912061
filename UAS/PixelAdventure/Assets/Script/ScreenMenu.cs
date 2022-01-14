using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenMenu : MonoBehaviour
{
    public void LoadNewGame(){
        SceneManager.LoadScene("MultiLevel");
    }

    public void MenuGame(){
        SceneManager.LoadScene("Menu");
    }

    public void MenuInsctruction(){
        SceneManager.LoadScene("Insctruction");
    }
    public void Level1(){
        SceneManager.LoadScene("Level1");
    }
    public void Level2(){
        SceneManager.LoadScene("Level2");
    }
    public void Level3(){
        SceneManager.LoadScene("Level3");
    }
}
