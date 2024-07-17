using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtAttractor : MonoBehaviour
{
     void Update()
    {
        // Выйти из приложения
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        transform.LookAt(Attractor.POS);       
    }
}
