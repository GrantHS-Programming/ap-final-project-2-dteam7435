using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckpoint : MonoBehaviour
{
    public Transform newCheckpoint;
    public GameObject checkpoint;

        void OnTriggerEnter(Collider other)
    {
        checkpoint.transform.position = newCheckpoint.transform.position;
    }
}
