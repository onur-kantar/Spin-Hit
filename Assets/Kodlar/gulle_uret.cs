using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gulle_uret : MonoBehaviour
{
    public GameObject gulle;
    float zamantutucu = -1;
    public float gullesure;
    AudioSource gulle_ses;
    public Animator animasyon;
    bool kontrol;
    Transform tr_uret;
    void Start()
    {
        gulle_ses=GetComponent<AudioSource>();
        if(PlayerPrefs.GetFloat("gullesure") ==0f)
        {
            PlayerPrefs.SetFloat("gullesure", 0.5f);
        }
        gullesure = PlayerPrefs.GetFloat("gullesure");
        tr_uret = transform;
    }
    void Update()
    {
        if (Time.time > zamantutucu&&kontrol)
        {
            animasyon.Play("gulle_uretim");
            gulle_ses.Play();
            zamantutucu = Time.time + gullesure;
            Instantiate(gulle, tr_uret.position, tr_uret.rotation);
        }
    }
    public void ates()
    {
        kontrol = true;
    }
    public void dur()
    {
        kontrol = false;
    }
}
