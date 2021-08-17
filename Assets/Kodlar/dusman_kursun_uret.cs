using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_kursun_uret : MonoBehaviour
{
    public int kursun_arasi;
    float zaman = 0;
    public GameObject kursun;
    public GameObject uret;
    void Start()
    {
       
    }
    void Update()
    {
        if (Time.time > zaman)
        {
            zaman = Time.time + kursun_arasi;
            Instantiate(kursun, uret.transform.position, uret.transform.rotation);
        }
    }
}
