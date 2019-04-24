using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creates a cached object pool for reduced memory thrashing.
public class GenericObjectPool : MonoBehaviour
{
    public int count;
    public GameObject[] prefabs;

    private int lastSelected = 0;
    private GameObject[] instances;

	// Use this for initialization
    void Start () {
        instances = new GameObject[count];
	    for (int i = 0; i < count; ++i)
	    {
	        var instance = Instantiate(prefabs[Random.Range(0, prefabs.Length)]);
            instance.SetActive(true);
	        instance.transform.parent = this.transform.parent;
	        instances[i] = instance;
	    }
    }

    public GameObject Instantiate(Vector3 position, Quaternion rotation)
    {
        for (int i = 0; i < instances.Length; i++)
        {
            int index = (lastSelected + 1 + i) % instances.Length;
            if (!instances[index].activeSelf)
            {
                lastSelected = index;
                instances[index].SetActive(true);
                instances[index].transform.position = position;
                instances[index].transform.rotation = rotation;
                return instances[index];
            }
        }
        return null;
    }

    public void Destroy(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}