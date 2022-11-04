using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject == NewPlayer.Instance.gameObject && NewPlayer.Instance.grounded)
        {
            NewPlayer.Instance.speedMultiplier = 4;
                
        }
    }
}
