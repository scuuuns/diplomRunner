using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float _height;
    [SerializeField] private int _numberOfCoins;
    [SerializeField] private string _name;
    [SerializeField] private Color _bodyColor;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private bool _isAlive;
    [SerializeField] private Light _sun;
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _ball;

    // Start is called before the first frame update
    void Start()
    {
       transform.localScale = new Vector3(1,_height,1);
       gameObject.name = _name;
       gameObject.GetComponent<Renderer>().material.color = _bodyColor;
       transform.position = _startPosition;
       gameObject.SetActive(_isAlive);

       _sun.intensity =2;
      // _sun.color = Color.red;
       _sun.color = _bodyColor;
       _camera.fieldOfView = 40;
    }

    // Update is called once per frame
    void Update()
    {
        _ball.position = transform.position = new Vector3(0,3,0);
    }
}
