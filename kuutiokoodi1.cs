using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kuutiokoodi1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Py�ritet��n kuutiota y-akselin ymp�ri
        this.GetComponent<Transform>().Rotate(0f, 0.1f, 0.3f);
    }
}
