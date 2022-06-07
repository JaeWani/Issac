using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Default_Tears : MonoBehaviour
{
    Rigidbody2D RB;
    public GameObject PlayerTear;
    public Transform TearLocation;
    public float ShootSpeed;
    [S]
    GameObject TearObj;
    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        TearShoot();
    }
    public void TearSpawn()
    {  
        Instantiate(PlayerTear, TearLocation.position, TearLocation.rotation);
    }
    void TearShoot() 
    {

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            RB.AddForce(Vector2.right * ShootSpeed, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RB.AddForce(Vector2.left * ShootSpeed, ForceMode2D.Impulse);
        }

    }

}
