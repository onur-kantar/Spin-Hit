using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class shop_kontrol : MonoBehaviour
{
    public Text para;

    int toplam_para;
    int deger;
    float gullesure;
    public Text deger_text;
    int almadi;
    public GameObject aldi_1;
    public GameObject aldi_2;
    public GameObject aldi_3;
    public GameObject aldi_4;
    public GameObject buton;
    public int baslangic_degeri;
    public int artis_degeri;

    int deger2;
    int can;
    public Text deger_text2;
    int almadi2;
    public GameObject aldi_12;
    public GameObject aldi_22;
    public GameObject aldi_32;
    public GameObject aldi_42;
    public GameObject buton2;
    public int baslangic_degeri2;
    public int artis_degeri2;
    void Start()
    {/*
        PlayerPrefs.DeleteKey("deger"); //Deger Silme Komutu
        PlayerPrefs.DeleteKey("gullesure"); //Deger Silme Komutu
        PlayerPrefs.DeleteKey("almadi_1"); //Deger Silme Komutu
        PlayerPrefs.DeleteKey("deger2"); //Deger Silme Komutu
        PlayerPrefs.DeleteKey("almadi_2"); //Deger Silme Komutu
        PlayerPrefs.DeleteKey("can"); //Deger Silme Komutu
     */

        if (PlayerPrefs.GetInt("deger") == 0)
        {
            PlayerPrefs.SetInt("deger", baslangic_degeri);
            PlayerPrefs.SetFloat("gullesure", 0.5f);
        }

        almadi = PlayerPrefs.GetInt("almadi_1");
        deger = PlayerPrefs.GetInt("deger");
        toplam_para = PlayerPrefs.GetInt("toplam_para");
        deger_text.text = deger.ToString();

        if (PlayerPrefs.GetInt("deger2") == 0)
        {
            PlayerPrefs.SetInt("deger2", baslangic_degeri2);
        }

        almadi2 = PlayerPrefs.GetInt("almadi_2");
        deger2 = PlayerPrefs.GetInt("deger2");
        toplam_para = PlayerPrefs.GetInt("toplam_para");

        deger_text2.text = deger2.ToString();

    }

    void Update()
    {
        para.text = PlayerPrefs.GetInt("toplam_para").ToString();
        aldi_kontrol(deger, almadi, aldi_1, aldi_2, aldi_3, aldi_4, buton, deger_text);
        aldi_kontrol(deger2, almadi2, aldi_12, aldi_22, aldi_32, aldi_42, buton2, deger_text2);
    }

    public void oyun_ekranı_gecis()
    {
        SceneManager.LoadScene(0);
    }

    public void gulle_cikis_hizi()
    {

        if (toplam_para >= deger)
        {
            deger = PlayerPrefs.GetInt("deger");
            toplam_para -= deger;

            gullesure = PlayerPrefs.GetFloat("gullesure");
            gullesure -= 0.075f;

            PlayerPrefs.SetFloat("gullesure", gullesure);
            PlayerPrefs.SetInt("toplam_para", toplam_para);

            deger += artis_degeri;
            PlayerPrefs.SetInt("deger", deger);
            deger_text.text = deger.ToString();

            almadi++;
            PlayerPrefs.SetInt("almadi_1", almadi);
        }

    }

    public void can_shop()
    {
        
        if (toplam_para >= deger2)
        {
            deger2 = PlayerPrefs.GetInt("deger2");
            toplam_para -= deger2;

            can = PlayerPrefs.GetInt("can");
            can += 1;
            PlayerPrefs.SetInt("can", can);
            PlayerPrefs.SetInt("toplam_para", toplam_para);

            deger2 += artis_degeri2;
            PlayerPrefs.SetInt("deger2", deger2);
            deger_text2.text = deger2.ToString();

            almadi2++;
            PlayerPrefs.SetInt("almadi_2", almadi2);
        }
        
    }

    void aldi_kontrol(int deger, int almadi,GameObject aldi_1, GameObject aldi_2, GameObject aldi_3, GameObject aldi_4
        ,GameObject buton, Text deger_text)
    {
        if (toplam_para < deger)
        {
            buton.GetComponent<Button>().interactable = false;
        }
        if (almadi == 4)
        {
            buton.GetComponent<Button>().interactable = false;
            deger_text.text = "-";
        }

        if (almadi == 1)
        {
            aldi_1.SetActive(true);
        }
        else if (almadi == 2)
        {
            aldi_1.SetActive(true);
            aldi_2.SetActive(true);
        }
        else if (almadi == 3)
        {
            aldi_1.SetActive(true);
            aldi_2.SetActive(true);
            aldi_3.SetActive(true);
        }
        else if (almadi == 4)
        {
            aldi_1.SetActive(true);
            aldi_2.SetActive(true);
            aldi_3.SetActive(true);
            aldi_4.SetActive(true);
        }
    }
}
