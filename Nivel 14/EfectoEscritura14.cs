using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EfectoEscritura14 : MonoBehaviour
{
    public float delay = 0.1f;
    public string textToType = "I think we're going to leave it here, maybe the next one will think about it a little more... I'm going to play LoL";
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
        StartCoroutine(CambioEscena());
    }

    IEnumerator CambioEscena()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Nivel15");
    }
}
