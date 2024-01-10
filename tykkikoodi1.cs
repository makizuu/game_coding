using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tykkikoodi1 : MonoBehaviour
{

    //Raahataan kuula
    public GameObject kuula = null;

    //Haetaan tähtäin
    private GameObject tahtain = null;
    //Tykin kulma
    private float kulma = 0f;

    //Ampumavoima
    private float kuulavoima = 6500f;

    void Start()
    {
        this.tahtain = GameObject.Find("tahtain");
    }

    void Update()
    {
        //Otetaan tykin piipun kulma talteen
        this.kulma = this.GetComponent<Transform>().rotation.eulerAngles.z;

        if (Input.GetKey(KeyCode.UpArrow) && (this.kulma < 84f)) 
        {
            this.GetComponent<Transform>().Rotate(0f, 0f, 12f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) && (this.kulma > 5f))
        {
            this.GetComponent<Transform>().Rotate(0f, 0f, -12f * Time.deltaTime);
        }

        //Ammutaan vasemmalla CTRL-näppäimellä
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Luodaan kuula tähtäimelle
            GameObject apu = Instantiate(this.kuula, this.tahtain.GetComponent<Transform>().position, this.tahtain.GetComponent<Transform>().rotation);

            //Lasketaan kulmaa vastaava x- ja y-suuntainen kerroin (0-1)
            float radkulma = this.kulma * Mathf.Deg2Rad;
            float x1 = Mathf.Cos(radkulma);
            float y1 = Mathf.Sin(radkulma);

            //Kerrotaan kulmakertoimet halutulla voimalla
            apu.GetComponent<Rigidbody2D>().AddForce(new Vector2(x1, y1) * this.kuulavoima);
            Destroy(apu.gameObject, 10f);
        }
    }
}
