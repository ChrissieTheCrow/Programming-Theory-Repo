using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doe : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AnimalForward();
        AnimalTurn();
    }

    public override void AnimalForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }

}
