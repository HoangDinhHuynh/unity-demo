using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int playerLocation = 19;
        int spawnLocation = 20;

        if (playerLocation == spawnLocation) this.Spawn();
        else this.notSpawn();
    }


    void Spawn()
    {
        Debug.Log("Spawn");
    }

   






    // Update is called once per frame
    void Update()
    {
        
    }
}
