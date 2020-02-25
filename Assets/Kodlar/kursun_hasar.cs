using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursun_hasar : MonoBehaviour
{
    can taban_can;
    Animator taban_ani;
    public int hasar;
    public GameObject patlama;
    private void Start()
    {
        taban_can = GameObject.FindGameObjectWithTag("taban").GetComponent<can>();
        taban_ani = GameObject.FindGameObjectWithTag("taban").GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "taban")
        {
            taban_can.karakter_can -= hasar;
            taban_ani.Play("hasar2");
            Destroy(gameObject);
        }
        if(collision.tag == "gulle")
        {
            Instantiate(patlama, transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
