using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PMenuMgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void Resume()
    {
        GetComponent<Canvas>().enabled = false;
        //reset the time scale to 1
        Time.timeScale = 1;
        Cursor.visible = false;
    }

}
