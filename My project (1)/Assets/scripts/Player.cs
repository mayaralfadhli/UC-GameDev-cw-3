using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * speed,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
