using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPursue : SteeringBehaviour
{
    public Boid[] targets;
    Boid target;
    Vector3 targetPos;

    public void Start()
    {
        targets = GameObject.FindObjectsOfType<Boid>();

        target = targets[Random.Range(0, targets.Length)];
    }


    public void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, targetPos);
        }
    }

    public override Vector3 Calculate()
    {
        float dist = Vector3.Distance(target.transform.position, transform.position);
        float time = dist / boid.maxSpeed;

        if(target.tag == "Enemy")
        {
            targetPos = target.transform.position + (target.velocity * time);

        }
        //else if (target = null)
        //{
        //    target = targets[Random.Range(0, targets.Length)];
        //    targetPos = target.transform.position + (target.velocity * time);
        //}
        else
        {
            target = targets[Random.Range(0, targets.Length)];
            targetPos = target.transform.position + (target.velocity * time);
        }

        return boid.SeekForce(targetPos);
    }
}
