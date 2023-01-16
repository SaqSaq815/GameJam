using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public GameObject menu;
    public GameObject option;
    public GameObject credit;
    public GameObject creditCan;
    public GameObject optionCan;

    public void Play()
    {
        SceneManager.LoadScene("Game_Scene");
       
    }

    public void Menu()
    {
        menu.SetActive(true);
        option.SetActive(false);
        credit.SetActive(false);
        creditCan.SetActive(false);
        optionCan.SetActive(false);
    }
    public void Options()
    {
        menu.SetActive(false);
        option.SetActive(true);
        credit.SetActive(false);
        creditCan.SetActive(false);
        optionCan.SetActive(true);
    }
    public void Credit()
    {
        menu.SetActive(false);
        option.SetActive(false);
        credit.SetActive(true);
        creditCan.SetActive(true);
        optionCan.SetActive(false);
    }

    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }
}
