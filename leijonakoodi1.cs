using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leijonakoodi1 : MonoBehaviour
{
    //Leijonan nopeuden s‰‰tˆ
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

        //K‰‰nnet‰‰n leijona nuolin‰pp‰imill‰
        if (Input.GetKeyDown(KeyCode.RightArrow) && (this.suunta != 1))
        {
            //K‰‰nnet‰‰n leijona ja p‰ivitet‰‰n suunta
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
            this.suunta = 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && (this.suunta != 2))
        {
            //K‰‰nnet‰‰n leijona ja p‰ivitet‰‰n suunta
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
            this.suunta = 2;
        }

        //K‰‰nnet‰‰n kummassakin p‰‰dyss‰ leijona vastakkaiseen suuntaan
        if ((this.GetComponent<Transform>().position.x < -15f) ||
            (this.GetComponent<Transform>().position.x > 15f))
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }

    }
}
