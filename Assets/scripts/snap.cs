using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snap : MonoBehaviour
{
    public Transform Kugel1;
    public Transform Kugel2;

    public float snapDistance = 2f;
    public float kugelDurchmesser = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Kugel1.position, Kugel2.position);

        if (distance < snapDistance)
        {
             Vector3 direction = (Kugel2.position - Kugel1.position).normalized;
            float targetDistance = kugelDurchmesser;

            if (distance < targetDistance)
            {
                Kugel1.position = Kugel2.position - direction * targetDistance;
            }
            else
            {
                Kugel1.position = Kugel2.position - direction * targetDistance;
            }

            Kugel1.rotation = Kugel2.rotation;
        }
    }
}
