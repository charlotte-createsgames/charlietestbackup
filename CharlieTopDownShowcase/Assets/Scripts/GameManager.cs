using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverUI.activeInHierarchy)
        {
            Cursor.visible = true;
            
        }
        else
        {
            Cursor.visible = false;
        }
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");

    }
}
