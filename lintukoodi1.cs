using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lintukoodi1 : MonoBehaviour
{
    //Linnun nopeuden s‰‰tˆ
    private float nopeus = 9f;
    void Start()
    {

    }

    void Update()
    {
        //Lintu lent‰‰ positiivisen x-akselin suuntaan
        this.GetComponent<Transform>().Translate(this.nopeus * Time.deltaTime, 0f, 0f);

        //K‰‰nnet‰‰n kummassakin p‰‰dyss‰ lintu vastakkaiseen suuntaan
        if ((this.GetComponent<Transform>().position.x < -15f) ||
            (this.GetComponent<Transform>().position.x > 15f))
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }
    }
}
