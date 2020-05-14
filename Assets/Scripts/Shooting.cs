using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;

    public float fireRate = 0.001f;

    public AudioClip laser;
    private AudioSource audioSrc;
    
    [SerializeField]private float nextFire = 0.0f;


     void Start()
    {
        audioSrc = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            audioSrc.PlayOneShot(laser, 1.0f);

            Shoot();
        }     

       
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

       Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

        bulletRb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);

    }
}
