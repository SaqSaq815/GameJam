using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ingame : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public GameObject restart;
    public GameObject exit;
    

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            restart.SetActive(true);
            exit.SetActive(true);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Get the name of the active scene
    }


}
