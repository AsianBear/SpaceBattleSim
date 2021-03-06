﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDetect : MonoBehaviour
{

    private float timeBtwShot;
    public float startTimeBtwShots;
    private float shots;
    public float numberOfShots;

    public GameObject projectile;
    public float force;

    public float rayLength;

    public string nameTag;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwShot = 0f;
        shots = numberOfShots;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray enemyCheck = new Ray(this.transform.position, this.transform.forward);

        Debug.DrawRay(this.transform.position, this.transform.forward * rayLength, Color.green);

        if (Physics.Raycast(enemyCheck, out hit, rayLength)) //Draw raycast
        {
            //Debug.Log(hit.transform.name);
            if (hit.collider.tag == nameTag) // If it hits an object with tag "Wall"
            {
                SpawnProjectile();
                //Debug.Log("Ray Hit!");
            }
        }
    }

    public void SpawnProjectile()
    {
        //Instantiate(projectile, transform.position, Quaternion.identity);

        if (timeBtwShot <= 0)
        {
            //Vector3 projectileSpawn = gameObject.transform.position + gameObject.transform.forward;
            //InvokeRepeating("SpawnProjectile", 3, 0);

            if(shots > 0)
            {
                GameObject Spawn;
                Spawn = Instantiate(projectile, transform.position, transform.rotation) as GameObject;

                Rigidbody tempRigidbody;
                tempRigidbody = Spawn.GetComponent<Rigidbody>();

                tempRigidbody.AddForce(transform.forward * force); //May need to get rid of Time.DeltaTime
                Destroy(Spawn, 10.0f);

                shots -= 1f;
            }
            else
            {
                shots = numberOfShots;
            }

            timeBtwShot = startTimeBtwShots;
        }
        else
        {
            timeBtwShot -= Time.deltaTime;
        }
    }
}
