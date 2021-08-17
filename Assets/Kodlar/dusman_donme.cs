using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_donme : MonoBehaviour
{
    public float hiz;
    void Start()
    {
            
    }
    void Update()
    {
        transform.Rotate(0, 0, hiz * Time.deltaTime);
    }
}
