using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopetuskoodi : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //ESC-n�pp�in sulkee sovelluksen
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
