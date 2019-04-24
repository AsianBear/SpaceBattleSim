using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject playerObject;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerObject.transform.position + offset;
        //transform.rotation = Quaternion.Euler(20, playerObject.transform.rotation.y, playerObject.transform.rotation.z);
    }
}
