using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  
    public float MoveSpeed;
    void Start()
    {

        MoveSpeed = 0.05f;
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D)) 
            transform.Translate(Vector3.right * MoveSpeed);
        if(Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * MoveSpeed);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * MoveSpeed);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * MoveSpeed);
    }
    void Update()
    {
        
    }
}
