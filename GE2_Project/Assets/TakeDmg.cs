using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDmg : MonoBehaviour
{

    public float health = 30f;
    public GameObject explosion;
    public GameObject sparks;
    public AudioSource exploSource;
    public AudioClip exploClip;
    public AudioSource sparkSource;
    public AudioClip sparkClip;

    public void TakeDamage(float amount)
    {
        health -= amount;
        sparks.SetActive(true);
        sparkSource.Play();
        if(health <= 0)
        {
            explosion.SetActive(true);
            exploSource.Play();
            Debug.Log("Dead");
            if(this.gameObject.name == "VillianFrigate")
            {
                Debug.Log("SceneChangeActive");
                //GetComponent<SceneChanger>().Invoke("FadeToNextScene", 0.1f);
                FindObjectOfType<SceneChanger>().FadeToNextScene();
                //Death();
            }
            Invoke("Death", 1f);
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        exploSource.clip = exploClip;
        sparkSource.clip = sparkClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
