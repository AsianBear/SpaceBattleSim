using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDmg : MonoBehaviour
{

    public float health = 30f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Debug.Log("Dead");
            if(this.gameObject.name == "VillianFrigate")
            {
                Debug.Log("SceneChangeActive");
                //GetComponent<SceneChanger>().Invoke("FadeToNextScene", 0.1f);
                FindObjectOfType<SceneChanger>().FadeToNextScene();
                //Death();
            }
            Death();
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
