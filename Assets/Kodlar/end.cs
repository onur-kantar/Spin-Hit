using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class end : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(bekleme());
    }

    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }

}
