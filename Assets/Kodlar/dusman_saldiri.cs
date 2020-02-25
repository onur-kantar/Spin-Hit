using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_saldiri : MonoBehaviour
{
    can taban_can;
    Animator taban_ani;
    public int hasar;
    void Start()
    {
        taban_can = GameObject.FindGameObjectWithTag("taban").GetComponent<can>();
        taban_ani = GameObject.FindGameObjectWithTag("taban").GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "taban")
        {
            InvokeRepeating("can_azalma", 0, 1);
        }

    }
    void can_azalma()
    {
        taban_can.karakter_can-=hasar;
        taban_ani.Play("hasar2");
        if (taban_can.karakter_can < 0)
        {
            tekrar_iptal();
        }
    }
    public void tekrar_iptal()
    {
        CancelInvoke("can_azalma");
    }

}
