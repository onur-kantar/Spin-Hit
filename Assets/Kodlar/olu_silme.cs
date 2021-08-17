using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olu_silme : MonoBehaviour
{
    AudioSource patlama_ses;
    void Start()
    {
        patlama_ses = GetComponent<AudioSource>();
        StartCoroutine(silme());
    }
    IEnumerator silme()
    {
        patlama_ses.Play();
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

}
