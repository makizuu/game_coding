using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poistu1 : MonoBehaviour
{
    
    void Update()
    {
        //ESC-n�pp�in sulkee sovelluksen
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
