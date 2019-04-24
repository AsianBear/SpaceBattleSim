using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage = 10f;

    public void OnCollisionEnter(Collision other)
    {
        TakeDmg target = other.transform.GetComponent<TakeDmg>();

        if (target != null)
        {
            target.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

}
