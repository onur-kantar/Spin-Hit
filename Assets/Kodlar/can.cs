using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class can : MonoBehaviour
{
    public int karakter_can;
    Animator animasyon;
    public GameObject dusman_oldurucu;
    void Start()
    {
        karakter_can = PlayerPrefs.GetInt("can");
        animasyon = GetComponent<Animator>();
    }
    private void Update()
    {
        if (karakter_can <= 0)
        {
            karakter_can = 0;
            StartCoroutine(olum_animasyon());
        }
    }
    public IEnumerator olum_animasyon()
    {
        dusman_oldurucu.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }

}
