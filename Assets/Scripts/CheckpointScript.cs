using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{

    public Transform Checkpoint;
    public GameObject Player;
    
    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = Checkpoint.transform.position;
    }


}
