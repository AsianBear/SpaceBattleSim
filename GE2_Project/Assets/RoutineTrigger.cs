using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutineTrigger : MonoBehaviour
{

    public GameObject portal;
    public GameObject ships;

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
    }
}
