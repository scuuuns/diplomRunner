using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerModifaer : MonoBehaviour
{
    
    [SerializeField] int _widht;
    [SerializeField] int _height;
    float _widhtMultiplayer = 0.0005f;
    float _heightMulltiplayer = 0.01f;
     [SerializeField] Renderer _renderer;

     [SerializeField] Transform _topSpine;
     [SerializeField] Transform _bottomSpine;
     [SerializeField] Transform _colliderTransform;
    
    private void Start(){
      SetWidth(Progress.Instance.Width);
      SetHeight(Progress.Instance.Height);  
    }
    void Update()
    {
        float offsetY = _height * _heightMulltiplayer + 0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0,offsetY,0);
        _colliderTransform.localScale = new Vector3 (1,1.84f + _height * _heightMulltiplayer,1);
        if (Input.GetKeyDown(KeyCode.W)){
            AddWidth(20);
        }
        if (Input.GetKeyDown(KeyCode.H)){
            AddHeight(20);
        }
        
    }
    public void AddWidth (int value){
        _widht += value;
        UpdateWidth();
    }
    public void AddHeight (int value){
        _height += value;
        
    }

    public void SetWidth (int value){
        _widht = value;
        UpdateWidth();
    }

    public void SetHeight (int value){
        _height = value;
    }
    public void HitBarier(){
        if (_height > 0) {
            _height -= 30;
        } else if (_widht > 0) {
            _widht -= 30;
            UpdateWidth();
        } else {
            Die();
        }
    }

    void UpdateWidth (){
        _renderer.material.SetFloat("_PushValue", _widht * _widhtMultiplayer);
    }
   

    void Die (){
       
            FindObjectOfType<GameManager>().ShowReplayWindow();
        
        Destroy(gameObject);
    }
}
