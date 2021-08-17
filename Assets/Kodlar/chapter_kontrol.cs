using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chapter_kontrol : MonoBehaviour
{
    AudioSource muzik;
    public AudioSource ses_ates;
    public AudioSource ses_patlama;
    public Text para_text;
    public Text can_text;
    public int toplam_para;
    GameObject karakter_can;
    public Text chapter_isim;
    public int olen_sayisi;
    GameObject x;
    GameObject y;
    
    void Start()
    {
        if (PlayerPrefs.GetInt("can") == 0)
        {
            PlayerPrefs.SetInt("can", 1);
        }
        
        PlayerPrefs.SetInt("chapter", SceneManager.GetActiveScene().buildIndex);
        karakter_can = GameObject.FindGameObjectWithTag("taban");
        muzik = GetComponent<AudioSource>();
        toplam_para = PlayerPrefs.GetInt("toplam_para");

        chapter_isim.text = "CHAPTER "+ SceneManager.GetActiveScene().buildIndex;

        x = GameObject.FindGameObjectWithTag("rastgele_dusman_ust");
        y = GameObject.FindGameObjectWithTag("rastgele_dusman_alt");
        olen_sayisi= y.GetComponent<rastgele_dusman>().dusman + x.GetComponent<rastgele_dusman>().dusman;

        if (PlayerPrefs.GetInt("muzik") == 0)
        {
            muzik.volume = 0.5f;
            
        }
        else
        {
            muzik.volume = 0f;
        }
        if (PlayerPrefs.GetInt("ses") == 0)
        {
            ses_ates.volume = 1f;
            ses_patlama.volume = 1f;
        }
        else
        {
            ses_ates.volume = 0f;
            ses_patlama.volume = 0f;
        }
    }

    void Update()
    {
        para_text.text = toplam_para.ToString();
        can_text.text = karakter_can.GetComponent<can>().karakter_can.ToString();
    }
    public void para(int gelen_para)
    {
        olen_sayisi--;
        if (olen_sayisi == 0)
            StartCoroutine(chapter_gecis());
        toplam_para += gelen_para;
        PlayerPrefs.SetInt("toplam_para", toplam_para);
    }
    IEnumerator chapter_gecis()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
