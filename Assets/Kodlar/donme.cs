using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donme : MonoBehaviour
{
    public float hiz;
    int yon=1;
    bool kontrol;
    Transform tr_donme;
    void Start()
    {
        tr_donme = transform;
    }
    void Update()
    {
        if(kontrol)
        tr_donme.Rotate(0, 0, yon * hiz * Time.deltaTime);
    }
    public void yon_sag()
    {
        kontrol = true;
        yon = -1;
    }
    public void yon_sol()
    {
        kontrol = true;
        yon = 1;
    }
    public void dur()
    {
        kontrol = false;
    }
}
