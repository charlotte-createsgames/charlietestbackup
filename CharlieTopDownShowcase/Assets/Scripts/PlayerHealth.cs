using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float maxHealth;
    public Image healthBar;
    [SerializeField]
    int health = 10;

    private bool isDead;

    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
        if(health <= 0 && !isDead )
        {
            isDead = true;
            gameManager.GameOver();
            Debug.Log("Dead");
            Time.timeScale = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //we want to take damage IF the player hits the enemy capsule
        //bool key = true;
        if (collision.gameObject.tag == "Enemy")
        {
            //health = health - 1;
            health -= 1;
            //health--;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 1;
        }
        if (health < 1)
        {
       
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}