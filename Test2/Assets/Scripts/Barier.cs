using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barier : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter (Collider other) {
        PlayerModifaer _playerModifaer = other.attachedRigidbody.GetComponent<PlayerModifaer>();
        if (_playerModifaer){
            _playerModifaer.HitBarier();
            Destroy(gameObject);
        }
        
    }
}
