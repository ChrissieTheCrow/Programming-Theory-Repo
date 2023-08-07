using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSelect : MonoBehaviour
{
    public GameObject doe;
    public GameObject fox;
    public GameObject titleScreen;

    private float spawnPosX = -14.39f;
    private float spawnPosY = -2.08f;
    private float spawnPosZ = -12.34f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectDoe()
    {
       Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        titleScreen.gameObject.SetActive(false);
        Instantiate(doe, spawnPos, doe.transform.rotation);

    }

    public void SelectFox()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        titleScreen.gameObject.SetActive(false);
        Instantiate(fox, spawnPos, doe.transform.rotation);

    }

}
