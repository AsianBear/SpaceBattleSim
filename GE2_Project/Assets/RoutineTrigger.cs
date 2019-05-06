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

    public AudioSource chargeSource;
    public AudioClip chargeClip;
    public AudioSource fireSource;
    public AudioClip fireClip;
    public AudioSource portalSource;
    public AudioClip portalClip;
    public AudioSource explosionSource;
    public AudioClip explosionClip;

    void Start()
    {
        StartCoroutine(TriggerSequence());
        chargeSource.clip = chargeClip;
        portalSource.clip = portalClip;
        fireSource.clip = fireClip;
        explosionSource.clip = explosionClip;
    }

    private IEnumerator TriggerSequence()
    {
        yield return new WaitForSeconds(1f);
        portal.SetActive(true);
        portalSource.Play();
        yield return new WaitForSeconds(2f);
        ships.SetActive(true);
        yield return new WaitForSeconds(7f);
        portal.SetActive(false);
        portalSource.Stop();
        yield return new WaitForSeconds(.1f);
        chargeFX.SetActive(true);
        electricFX.SetActive(true);
        chargeSource.Play();
        yield return new WaitForSeconds(7.5f);
        chargeFX.SetActive(false);
        electricFX.SetActive(false);
        chargeFinished.SetActive(true);
        chargeSource.Stop();
        yield return new WaitForSeconds(3f);
        chargeFinished.SetActive(false);
        lazer.SetActive(true);
        fireSource.Play();
        yield return new WaitForSeconds(5f);
        FindObjectOfType<SceneChanger>().FadeToNextScene();
    }

    void DestroyThis()
    {
        explosionSource.Play();
        explosion.SetActive(true);
        Destroy(ships.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Projectile"))
        {
            Debug.Log("Laser Hit!");
            DestroyThis();
            smallExplosion.SetActive(true);
        }
        else
        {
            smallExplosion.SetActive(false);
        }
        
    }
}
