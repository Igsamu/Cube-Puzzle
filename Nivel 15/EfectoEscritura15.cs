using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EfectoEscritura15 : MonoBehaviour
{
    public float delay = 0.1f;
    public string textToType = "Game Designer  Ignacio Sanz";
    private TMP_Text subtitleTextMesh;

    private void Awake()
    {
        subtitleTextMesh = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        StartCoroutine(TypeTextCO());
    }

    IEnumerator TypeTextCO()
    {
        yield return new WaitForSeconds(2);
        subtitleTextMesh.text = string.Empty;

        for (int i = 0; i < textToType.Length; i++)
        {
            subtitleTextMesh.text += textToType[i];
            yield return new WaitForSeconds(delay);
        }
        yield return null;
    }
}
