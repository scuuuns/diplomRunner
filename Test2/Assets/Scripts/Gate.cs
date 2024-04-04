using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField]  GateAppiarance _gateAppiarance;
    private void OnValidate (){
        _gateAppiarance.UpdateVisual(_deformationType, _value);
    }

    private void OnTriggerEnter (Collider other){
        PlayerModifaer playerModifaer = other.attachedRigidbody.GetComponent<PlayerModifaer>();
        if (playerModifaer){
            if (_deformationType == DeformationType.Whidth)
            playerModifaer.AddWidth(_value);

        } else if (_deformationType == DeformationType.Height){
             playerModifaer.AddHeight(_value);

        }
        Destroy(gameObject);
    }
}
