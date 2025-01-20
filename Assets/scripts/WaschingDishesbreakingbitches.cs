using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaschingDishesbreakingbitches : MonoBehaviour
{
    public Transform BackWash;
    public Transform FrontWash;
    public Transform Door;
    public Transform BackWall;

    public Vector3 BackwashOffset;
    public Vector3 FrontwashOffset;
    public float snapDistance = 0.05f;
    public float kugelDurchmesser = 1f;

    void Start()
    {
    }

    void Update()
    {
        float distance1 = Vector3.Distance(Door.position, FrontWash.position);
        Debug.Log($"dsqwe {distance1}");
        if (distance1 <= snapDistance)
        {

             Door.position = FrontWash.position + FrontwashOffset;

            Door.rotation = FrontWash.rotation;
        }

        float distance2 = Vector3.Distance(BackWall.position, BackWash.position);

        if (distance2 <= snapDistance)
        {
            float targetDistance2 = kugelDurchmesser;

            if (distance2 <= targetDistance2)
            {
                BackWall.position = BackWash.position + BackwashOffset;
            }           

            BackWall.rotation = BackWash.rotation;

        }
    }
}
