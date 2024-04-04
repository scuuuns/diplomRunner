using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]  float _speed;
    float _oldMousePosition;
    float _eulerY;
    [SerializeField] Animator _animator;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            _oldMousePosition = Input.mousePosition.x;
            _animator.SetBool("Run2", true);
        }

        if(Input.GetMouseButton(0)){

            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            transform.position = newPosition;
            
        float deltaX = Input.mousePosition.x - _oldMousePosition;
        _oldMousePosition = Input.mousePosition.x;

        _eulerY += deltaX;
        _eulerY = Mathf.Clamp(_eulerY,-70,70);
        transform.eulerAngles = new Vector3(0,_eulerY,0);
        }

        if (Input.GetMouseButtonUp(0)){
            _animator.SetBool("Run2", false);
        }
        
    }
}
