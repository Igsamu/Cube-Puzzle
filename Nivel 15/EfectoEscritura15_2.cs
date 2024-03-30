using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EfectoEscritura15_2 : MonoBehaviour
{
    public float delay = 0.1f;
    public string textToType = "Esc to exit";
    private TMP_Text subtitleTextMesh;

    private void Awake()
    {
        subtitleTextMesh = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        StartCoroutine(TypeTextCO());
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    IEnumerator TypeTextCO()
    {
        yield return new WaitForSeconds(10);
        subtitleTextMesh.text = string.Empty;

        for (int i = 0; i < textToType.Length; i++)
        {
            subtitleTextMesh.text += textToType[i];
            yield return new WaitForSeconds(delay);
        }
        yield return null;
    }
}
