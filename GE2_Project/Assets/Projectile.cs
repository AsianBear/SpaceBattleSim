using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage = 10f;
    public GameObject explosionFX;

    public void OnCollisionEnter(Collision other)
    {
        TakeDmg target = other.transform.GetComponent<TakeDmg>();

        if (target != null)
        {
            target.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        Invoke("playFX", 3f);
    }

    void playFX()
    {
        explosionFX.SetActive(true);
    }
}
