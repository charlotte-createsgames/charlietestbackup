using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Enter : MonoBehaviour
{


    [SerializeField]
    //string levelToLoad = Dead
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //IF we hit an end trigger, you win
        if (collision.gameObject.tag == "Level2")
        {

        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //IF we hit an enemy, reduce player hp
        if (collision.gameObject.tag == "Level2")
        {

            //add consequences
            //IF health gets too high, reload current level, try again, you're dead

            {
             SceneManager.LoadScene("Level2");
             
                SceneManager.UnloadSceneAsync("SampleScene");
                //SceneManager.LoadScene(levelToLoad);
            }
        }
    }
}
