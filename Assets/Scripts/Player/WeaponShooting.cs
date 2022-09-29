using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShooting : MonoBehaviour
{
    public Transform firepoint;
    public Object BulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        Instantiate(BulletPrefab, firepoint.position, firepoint.rotation);      
    }
}
