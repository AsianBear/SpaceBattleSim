using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInRadius : MonoBehaviour
{

    public GameObject explosion;
    public float radius;

    public List<GameObject> prefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        Instantiate(explosion, Random.insideUnitSphere * radius + transform.position, Random.rotation);
    }

    void AddToList()
    {
        prefabs.Add(explosion);
    }
}
