using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] Pre2FinishBehavior _pre2FinishTrigger;
    [SerializeField] Animator _animator;
    void Start()
    {
        _playerMove.enabled = false;
        _pre2FinishTrigger.enabled = false;
    }

    // Update is called once per frame
    public void Play()
    {
        _playerMove.enabled = true;
        
    }

    public void StartPreFinishBehavior (){
        _playerMove.enabled = false;
        _pre2FinishTrigger.enabled = true;
    }
    public void StartFinishBehavior (){
        _pre2FinishTrigger.enabled = false;
        _animator.SetTrigger("Dance");
        ;
    }
}
