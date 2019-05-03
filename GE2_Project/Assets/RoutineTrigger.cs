using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutineTrigger : MonoBehaviour
{

    public GameObject portal;
    public GameObject ships;
    public GameObject lazer;
    public GameObject chargeFX;
    public GameObject electricFX;
    public GameObject chargeFinished;
    public GameObject explosion;
    public GameObject smallExplosion;

    void Start()
    {
        StartCoroutine(TriggerSequence());
    }

    private IEnumerator TriggerSequence()
    {
        yield return new WaitForSeconds(1f);
        portal.SetActive(true);
        yield return new WaitForSeconds(2f);
        ships.SetActive(true);
        yield return new WaitForSeconds(5f);
        portal.SetActive(false);
        yield return new WaitForSeconds(2.1f);
        chargeFX.SetActive(true);
        electricFX.SetActive(true);
        yield return new WaitForSeconds(7.5f);
        chargeFX.SetActive(false);
        electricFX.SetActive(false);
        chargeFinished.SetActive(true);
        yield return new WaitForSeconds(2f);
        chargeFinished.SetActive(false);
        lazer.SetActive(true);
    }

    void DestroyThis()
    {
        explosion.SetActive(true);
        Destroy(ships.gameObject);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Projectile"))
        {
            DestroyThis();
            smallExplosion.SetActive(true);
        }
        else
        {
            smallExplosion.SetActive(false);
        }
        
    }
}
