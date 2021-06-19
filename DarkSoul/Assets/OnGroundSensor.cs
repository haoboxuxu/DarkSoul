using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGroundSensor : MonoBehaviour
{

    public CapsuleCollider capcol;

    private Vector3 point1;
    private Vector3 point2;
    private float radius;

    private void Awake()
    {
        radius = capcol.radius;
        point1 = transform.position + transform.up * radius;
        point2 = transform.position + transform.up * capcol.height - transform.up * radius;
    }

    private void FixedUpdate()
    {
        point1 = transform.position + transform.up * radius;
        point2 = transform.position + transform.up * capcol.height - transform.up * radius;

        Collider[] outputColliders = Physics.OverlapCapsule(point1, point2, radius, LayerMask.GetMask("Ground"));
        if (outputColliders.Length != 0)
        {
            print("collision");
        }
    }
}
