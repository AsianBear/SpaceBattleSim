using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    public GameObject portal;
    public GameObject[] ships;
    public AudioSource portalSource;
    public AudioClip portalClip;
    // Start is called before the first frame update
    void Start()
    {
        portalSource.clip = portalClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        portal.SetActive(true);
        portalSource.Play();
        StartCoroutine(TriggerSequence());
    }

    void DestroyList()
    {
        for(int i = 0; i < ships.Length; i++)
        {
            Destroy(ships[i].gameObject);
        }
    }

    private IEnumerator TriggerSequence()
    {
        yield return new WaitForSeconds(5f);
        DestroyList();
        yield return new WaitForSeconds(1.5f);
        portal.SetActive(false);
        portalSource.Stop();
        yield return new WaitForSeconds(.5f);
        FindObjectOfType<SceneChanger>().FadeToNextScene();

    }
}
