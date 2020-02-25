using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class oyun_kontrol : MonoBehaviour
{
    Button play;
    Button shop;
    public Animator animasyon;
    public Animator animasyon2;
    public int toplam_para;
    public Text para_text;
    public Text can_text;
    AudioSource muzik;
    public Button muzik_buton;
    public Sprite muzik_kapalı;
    public Sprite muzik_acik;
    public Button ses_buton;
    public AudioSource ses_patlama;
    public Sprite ses_kapalı;
    public Sprite ses_acik;
    public Text chapter;
    public int bolum;

    public void Start()
    {
        if (PlayerPrefs.GetInt("can") == 0)
        {
            PlayerPrefs.SetInt("can", 1);

        }
        if (PlayerPrefs.GetInt("chapter") == 0)
        {
            PlayerPrefs.SetInt("chapter", 1);

        }
        muzik = GetComponent<AudioSource>();
        play = GameObject.FindGameObjectWithTag("play").GetComponent<Button>();
        shop = GameObject.FindGameObjectWithTag("shop").GetComponent<Button>();
        
        if (PlayerPrefs.GetInt("muzik") == 0)
        {
            muzik.volume = 0.5f;
            muzik_buton.image.sprite = muzik_acik;
        }
        else
        {
            muzik.volume = 0f;
            muzik_buton.image.sprite = muzik_kapalı;
        }
        if (PlayerPrefs.GetInt("ses") == 0)
        {
            ses_buton.image.sprite = ses_acik;
        }
        else
        {
            ses_buton.image.sprite = ses_kapalı;
        }
        para_text.text = PlayerPrefs.GetInt("toplam_para").ToString();
        can_text.text = PlayerPrefs.GetInt("can").ToString();
        chapter.text = "Chapter\n" + PlayerPrefs.GetInt("chapter").ToString()+" - "+ bolum ;
    }

    public void oyun_basladi()
    {
        play.enabled = false;
        shop.enabled = false;
        animasyon.Play("yukarı_kaydirma2");
        animasyon2.Play("asagı_kaydirma2");
        StartCoroutine(chapter_gecis());
    }
    IEnumerator chapter_gecis()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(PlayerPrefs.GetInt("chapter"));
    }
   
    public void shop_gecis()
    {
        SceneManager.LoadScene("Shop");
    }
    public void muzik_kontrol()
    {
        if (muzik.volume==0.5f)
        {
            muzik.volume=0f;
            muzik_buton.image.sprite = muzik_kapalı;
            PlayerPrefs.SetInt("muzik", 1);
        }
        else
        {
            muzik.volume = 0.5f;
            muzik_buton.image.sprite = muzik_acik;
            PlayerPrefs.SetInt("muzik", 0);
        }
    }
    public void ses_kontrol()
    {
        if (PlayerPrefs.GetInt("ses")==0)
        {
            ses_buton.image.sprite = ses_kapalı;
            PlayerPrefs.SetInt("ses", 1);

        }
        else
        {
            ses_buton.image.sprite = ses_acik;
            PlayerPrefs.SetInt("ses", 0);
        }
    }
}
