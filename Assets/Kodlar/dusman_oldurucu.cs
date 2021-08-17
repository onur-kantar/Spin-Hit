using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_oldurucu : MonoBehaviour
{
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "dusman")
        {
            Destroy(collision.gameObject);
        }
    }


}
