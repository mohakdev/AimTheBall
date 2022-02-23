using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleDeviser : MonoBehaviour
{
    [Header("Angle Settings")]
    public int MaxAngle;
    public int MinAngle;
    public float CurrentAngle;
    public float AngleChangePerFrame;
    public bool Incrementing;
    void Start()
    {
        CurrentAngle = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentAngle >= MaxAngle)
        {
            Incrementing = false;
        }
        else if (CurrentAngle <= MinAngle)
        {
            Incrementing = true;
        }
        if (Incrementing)
        {
            CurrentAngle += AngleChangePerFrame;
        }
        else
        {
            CurrentAngle -= AngleChangePerFrame;
        }
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, CurrentAngle));
    }
    public float GetAngle()
    {
        return CurrentAngle;
    }
}
