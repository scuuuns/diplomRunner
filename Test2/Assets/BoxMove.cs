using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //gameObject.name = "My super Cube";
      //gameObject.SetActive(false); 
      //transform.position = new Vector3(0,2,0);
      //transform.eulerAngles = new Vector3(0,45,30);
      //transform.localScale = new Vector3(1,2,4);
    
    }

    // Update is called once per frame
    void Update()
    {
      
      if (Input.GetKey(KeyCode.W))  {
        transform.position += new Vector3(0,0.03f,0);
      }
       if (Input.GetKey(KeyCode.S))
      {
         transform.position -= new Vector3(0,0.03f,0);
      }
      if (Input.GetMouseButtonDown(0))
      {
        transform.localScale *=1.2f;
      }
      if (Input.GetMouseButtonDown(1))
      {
        transform.localScale *=0.2f;
      }
      transform.localEulerAngles = new Vector3 (0,Input.mousePosition.x,0);
      
    }
}
