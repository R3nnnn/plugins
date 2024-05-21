using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform BulletSpawn;
    public GameObject bulletPrefab;
    public float bulletSpeed = 200;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawn.forward * bulletSpeed * Time.deltaTime;
            audioSource.Play();
        }
    }

}
