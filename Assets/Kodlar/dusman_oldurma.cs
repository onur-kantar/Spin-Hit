using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_oldurma : MonoBehaviour
{
    public GameObject dusman_olu;
    public int dusman_degeri;
    public int can;
    Animator animasyon;
    dusman_saldiri dusman_Saldiri;
    chapter_kontrol chapter_Kontrol;
    void Start()
    {
        chapter_Kontrol = GameObject.FindGameObjectWithTag("chapter_kontrol").GetComponent<chapter_kontrol>();
        animasyon=GetComponent<Animator>();
        dusman_Saldiri = GetComponent<dusman_saldiri>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "gulle")
        {
            can--;
            animasyon.Play("dusman_hasar");
            Destroy(collision.gameObject);
            if (can == 0)
            {
                dusman_Saldiri.tekrar_iptal();
                Instantiate(dusman_olu, transform.position, transform.rotation);
                Destroy(gameObject);
                chapter_Kontrol.para(dusman_degeri);
            }
        }
    }
}
