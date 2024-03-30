using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EfectoEscritura : MonoBehaviour
{
    public float delay = 0.1f;
    public string textToType = "Hello! Welcome to my first game. It's four silly things, but I hope you like it.";
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
        subtitleTextMesh.text = string.Empty;

        for (int i = 0; i < textToType.Length; i++)
        {
            subtitleTextMesh.text += textToType[i];
            yield return new WaitForSeconds(delay);
        }
        yield return null;
    }
}
