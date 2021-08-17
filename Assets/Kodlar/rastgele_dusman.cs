using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rastgele_dusman : MonoBehaviour
{
    public GameObject dusman_lvl1;
    public GameObject dusman_lvl2;
    public GameObject dusman_lvl3;
    public Vector2 dogum_noktası;
    public bool lvl1;
    public float baslama_zamani_lvl1;
    public float aralık_zamani_lvl1;
    public bool lvl2;
    public float baslama_zamani_lvl2;
    public float aralık_zamani_lvl2;
    public bool lvl3;
    public float baslama_zamani_lvl3;
    public float aralık_zamani_lvl3;
    public int dusman;
    Transform tr_dusman;
    void Start()
    {
        if (lvl1)
            InvokeRepeating("dusman_lvl1_uretim", baslama_zamani_lvl1, aralık_zamani_lvl1);
        if (lvl2)
            InvokeRepeating("dusman_lvl2_uretim", baslama_zamani_lvl2, aralık_zamani_lvl2);
        if (lvl3)
            InvokeRepeating("dusman_lvl3_uretim", baslama_zamani_lvl3, aralık_zamani_lvl3);
        tr_dusman = transform;
    }
    void dusman_lvl1_uretim()
    {
        dogum_noktası.x = Random.Range(-4, 4);
        Instantiate(dusman_lvl1, new Vector2(dogum_noktası.x, tr_dusman.position.y), Quaternion.identity);
        dusman_azalma();
    }
    void dusman_lvl2_uretim()
    {
        dogum_noktası.x = Random.Range(-4, 4);
        Instantiate(dusman_lvl2, new Vector2(dogum_noktası.x, tr_dusman.position.y), Quaternion.identity);
        dusman_azalma();
    }
    void dusman_lvl3_uretim()
    {
        dogum_noktası.x = Random.Range(-4, 4);
        Instantiate(dusman_lvl3, new Vector2(dogum_noktası.x, tr_dusman.position.y), Quaternion.identity);
        dusman_azalma();
    }
    public void uretim_bitirme()
    {
        CancelInvoke("dusman_lvl1_uretim");
        CancelInvoke("dusman_lvl2_uretim");
        CancelInvoke("dusman_lvl3_uretim");
    }
    void dusman_azalma()
    {
        dusman--;
        if (dusman < 1)
        { 
            uretim_bitirme();
        }
    }
}
