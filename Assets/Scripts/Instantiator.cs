using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{

    public GameObject objectToClone;

    public void defede()
    {
        int counter = 0;
        while (counter < 3)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }

    //// Start is called before the first frame update
    //void Start()
    //{
    //    int counter = 0;
    //    while (counter<3) {
    //        Instantiate(objectToClone);
    //        counter++;
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
