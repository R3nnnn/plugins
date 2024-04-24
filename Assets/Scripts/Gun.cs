using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform BulletSpawn;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Q))
        {
            var bullet = Instantiate(bulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawn.forward * bulletSpeed;
        }
    }
}
