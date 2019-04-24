using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject)
        {
            GameObject.Find("CorvetteMain").GetComponent<FollowPath>().enabled = false;
        }
    }
}
