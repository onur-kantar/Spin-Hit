using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman_ilerleme : MonoBehaviour
{
    GameObject taban;
    public float hiz;
    bool kontrol = true;
    Transform tr_ilerleme;
    public bool ates_eden_dusman;
    void Start()
    {
        taban = GameObject.FindGameObjectWithTag("taban");
        tr_ilerleme = transform;
        if(ates_eden_dusman)
        GetComponent<dusman_kursun_uret>().enabled = false;

       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "taban" || (collision.tag == "dusman_tutucu" && ates_eden_dusman))
        {
            kontrol = false;
            if (ates_eden_dusman)
                GetComponent<dusman_kursun_uret>().enabled = true;
           
        }
    }
    void Update()
    {
        if(kontrol)
            tr_ilerleme.position = Vector3.MoveTowards(tr_ilerleme.position, taban.transform.position, Time.deltaTime * hiz);

        var dir = taban.transform.position - tr_ilerleme.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        tr_ilerleme.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
}
