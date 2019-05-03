using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public Animator anim;
    private int sceneToLoad;
    public float time = 3.0f;
    //private string tag;
    // Start is called before the first frame update
    void Start()
    {
        //tag = gameObject.GetComponent<ShootDetectSphereTest>().nameTag;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetMouseButton(0))
        {
            FadeToNextScene();
        }*/
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ship Hitted me");
        Invoke("FadeToNextScene", time);
    }

    public void FadeToNextScene()
    {
        FadeToScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToScene (int sceneIndex)
    {
        sceneToLoad = sceneIndex;
        anim.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
