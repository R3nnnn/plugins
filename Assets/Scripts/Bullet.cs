using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float life = 2f;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Monstruo" || other.gameObject.name == "Monstruo (1)" || other.gameObject.name == "Monstruo (2)"/* || other.gameObject.name == "Monstruo (3)" || other.gameObject.name == "Monstruo (4)"*/)
        {
            print("first if");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        life -= Time.deltaTime;
        if (life < 0 && gameObject.name!= "BulletSpawn")
        {
            print("second if");
            Destroy(gameObject);
        }
        
    }
}
