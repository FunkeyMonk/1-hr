using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool IsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsAlive == true)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (Input.GetKey(KeyCode.A))
                rb.AddForce(Vector3.left);
            if (Input.GetKey(KeyCode.D))
                rb.AddForce(Vector3.right);
            if (Input.GetKey(KeyCode.W))
                rb.AddForce(Vector3.up);
            if (Input.GetKey(KeyCode.S))
                rb.AddForce(Vector3.down);
        }

        if (IsAlive == false)
        {
            Debug.Log("Dead");
            
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        IsAlive = false;
    }
}
