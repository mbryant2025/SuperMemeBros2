//Used as both DeathZone and for the end of the career meme

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCareerTrigger : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject == NewPlayer.Instance.gameObject)
        {
            NewPlayer.Instance.GetHurt(0, 100, NewPlayer.Instance.gameObject);   
        }
    }
}
