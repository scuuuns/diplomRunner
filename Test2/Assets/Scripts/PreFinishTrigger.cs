using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehavior playerBehavior = other.attachedRigidbody.GetComponent<PlayerBehavior>();
        if (playerBehavior) {
            playerBehavior.StartPreFinishBehavior();
        }
    }
}
