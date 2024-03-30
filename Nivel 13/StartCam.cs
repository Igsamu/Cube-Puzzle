using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCam : MonoBehaviour
{
    public InicioMovimiento13 IM;
    public CameraController CC;
    public DesactivarCam DC;

    private void Start()
    {
        IM = FindObjectOfType<InicioMovimiento13>();
        CC = FindObjectOfType<CameraController>();
        DC = FindObjectOfType<DesactivarCam>();
    }

    private void Update()
    {
        if (IM.cam == true)
        {
            CC.enabled = true;
        }

        if (DC.DesCam == true)
        {
            CC.enabled = false;
        }
    }
}
