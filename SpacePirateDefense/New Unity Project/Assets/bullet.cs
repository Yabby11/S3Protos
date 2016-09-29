using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour
{

    public Rigidbody2D rb;
    void Start()

    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(transform.up * 10000);
    }
}
  
