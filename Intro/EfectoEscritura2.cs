using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EfectoEscritura2 : MonoBehaviour
{
    public float delay = 0.1f;
    public string textToType = "Maybe you should... you know... hit a key to start... Oh right, the key, press I.";
    private TMP_Text subtitleTextMesh;

    private void Awake()
    {
        subtitleTextMesh = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        StartCoroutine(WaitingFor());
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
    }

    IEnumerator WaitingFor()
    {
        yield return new WaitForSeconds(15);
        StartCoroutine(TypeTextCO());
    }
}
