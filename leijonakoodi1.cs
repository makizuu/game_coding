using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leijonakoodi1 : MonoBehaviour
{
    //Leijonan nopeuden säätö
    private float nopeus = 4f;

    //1 menee oikealle ja 2 menee vasemmalle
    private int suunta = 1;

    void Start()
    {
        
    }

    void Update()
    {
        //Leijona juoksee
        this.GetComponent<Transform>().Translate(this.nopeus * Time.deltaTime, 0f, 0f);

        //Käännetään leijona nuolinäppäimillä
        if (Input.GetKeyDown(KeyCode.RightArrow) && (this.suunta != 1))
        {
            //Käännetään leijona ja päivitetään suunta
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
            this.suunta = 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && (this.suunta != 2))
        {
            //Käännetään leijona ja päivitetään suunta
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
            this.suunta = 2;
        }

        //Käännetään kummassakin päädyssä leijona vastakkaiseen suuntaan
        if ((this.GetComponent<Transform>().position.x < -15f) ||
            (this.GetComponent<Transform>().position.x > 15f))
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }

    }
}
