using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EfectoEscritura12 : MonoBehaviour
{
    public float delay = 0.1f;
    public string textToType = "Do you know what? I've been thinking that maybe I'm better at something simpler... Perhaps 2D. Yes, let's try a level in 2 dimensions.";
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
        StartCoroutine(CambioNivel());
    }

    IEnumerator CambioNivel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Nivel13");
    }
}
