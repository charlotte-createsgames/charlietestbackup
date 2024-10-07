using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHP : MonoBehaviour
{
    [SerializeField]
    float health = 3;
    float maxHP;
    Image healthbar;
    // reduce enemy hp when hit by player bullet
    // destroy enemy when dead

    void Start()
    {
        maxHP = health;
        healthbar = GetComponentsInChildren<Image>()[1];
           }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    { 
    if(collision.gameObject.tag == "PlayerBullet")
        {
            health -= 1;
            healthbar.fillAmount = health / maxHP;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
