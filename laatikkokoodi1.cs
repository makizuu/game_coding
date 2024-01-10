using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laatikkokoodi1 : MonoBehaviour
{
    //t‰ss‰ yll‰pidet‰‰n laskuria
    private float laskuri = 0f;

    //t‰h‰n haetaan tekstielementti
    private GameObject teksti = null;

    //start is called before the first frame update
    void Start()
    {
        //haetaan tekstiobjekti
        this.teksti = GameObject.Find("teksti1");
    } //start

    //update is called once per frame
    void Update()
    {
        //kasvatetaan laskuria
        this.laskuri = this.laskuri + Time.deltaTime;

        if (this.laskuri < 15f)
        {
            //tulostetaan laskuri konsoliin
            Debug.Log("laskuri: " + this.laskuri);

            //tulostetaan laskuri tekstielementtiin
            this.teksti.GetComponent<TextMesh>().text = "LASKURI: " + this.laskuri;

            //pyˆritet‰‰n laatikkoa
            this.GetComponent<Transform>().Rotate(15f * Time.deltaTime, 25f * Time.deltaTime, 35f * Time.deltaTime);
        } else
        {
            //kytket‰‰n painovoima p‰‰lle
            this.GetComponent<Rigidbody>().isKinematic = false;
            Debug.Log("PUTOAA!!");

            //tulostetaan putoaa tekstielementtiin
            this.teksti.GetComponent<TextMesh>().color = Color.red;
            this.teksti.GetComponent<TextMesh>().text = "PUTOAA!!!";
        }
        
    } //update
} //class
