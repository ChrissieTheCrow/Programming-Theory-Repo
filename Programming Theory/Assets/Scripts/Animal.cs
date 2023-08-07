using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public float turnSpeed { get; private set; } //ENCAPSULATION
    private float horizontalInput;
   

    // Start is called before the first frame update
    void Start()
    {
        turnSpeed = 75.0f;
    }

    // Update is called once per frame
    void Update()
    {
        AnimalForward();
        AnimalTurn();
    }

    public virtual void AnimalForward() //ABSTRACTION
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 15);
    }

    public void AnimalTurn()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }


}
