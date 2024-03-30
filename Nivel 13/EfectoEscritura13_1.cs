using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EfectoEscritura13_1 : MonoBehaviour
{
    public GameObject imag;
    public GameObject imag2;
    public float delay = 0.1f;
    public string textToType = "And... If we put a dragon? or a donkey riding a rocket?";
    private TMP_Text subtitleTextMesh;

    private void Awake()
    {
        subtitleTextMesh = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        StartCoroutine(TypeTextCO());
        StartCoroutine(Drago());
        StartCoroutine(Donkey());
    }

    private void Update()
    {

    }


    IEnumerator TypeTextCO()
    {
        subtitleTextMesh.text = string.Empty;

        for (int i = 0; i < textToType.Length; i++)
        {
            subtitleTextMesh.text += textToType[i];
            yield return new WaitForSeconds(delay);
        }
        yield return null;
        StartCoroutine(Borrado());
    }

    IEnumerator Drago()
    {
        yield return new WaitForSeconds(3);
        imag.SetActive(true);
    }

    IEnumerator Donkey()
    {
        yield return new WaitForSeconds(6);
        imag2.SetActive(true);
    }


    IEnumerator Borrado()
    {
        yield return new WaitForSeconds(4);
        Destroy(subtitleTextMesh);
        Destroy(imag);
        Destroy(imag2);
    }
}
