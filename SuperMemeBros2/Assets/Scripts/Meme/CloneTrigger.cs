using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneTrigger : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D col)
    {
        if(NewPlayer.Instance.ticksSinceClone > 100) {
            GameObject spawner = GameObject.FindWithTag("Spawner");
            Vector2 clonePosition = new Vector2(spawner.transform.position.x, spawner.transform.position.y + 4);
            GameObject clone = Instantiate(NewPlayer.Instance.gameObject, clonePosition, NewPlayer.Instance.transform.rotation);
            NewPlayer.Instance.ticksSinceClone = 0;
        }
    }
}
