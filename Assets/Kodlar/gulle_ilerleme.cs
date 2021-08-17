using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gulle_ilerleme : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        fizik.velocity = transform.right * hiz;
    }
}
