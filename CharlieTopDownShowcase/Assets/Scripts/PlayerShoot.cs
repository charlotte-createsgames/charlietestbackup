using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour



    
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float bulletSpeed = 10f;
    [SerializeField]
    float bulletLifetime = 2.0f;
    float timer = 0;
    [SerializeField]
    float shootDelay = 0.5f;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //0.016667 = 60 Frames Per Second
        //IF you click
        if (Input.GetButton("Fire1") && timer > shootDelay)
        {
            timer = 0; //reset timer
            //shoot towards mouse cursor
            Vector3 mousePos = Input.mousePosition; 
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            Vector3 mouseDir = mousePos - transform.position;
            //normalize vector so we don't have wonky speed
            mouseDir.Normalize();
            //spawn bullet
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //push bullet toward mouse
            bullet.GetComponent<Rigidbody2D>().velocity = mouseDir * bulletSpeed;
            Destroy(bullet, bulletLifetime);
        }

    }
}
