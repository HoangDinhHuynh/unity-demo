using System.Collections.Generic;
using UnityEngine;

public class PlayerPosis : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float playerPosX;
    List<GameObject> minions;
    public GameObject minionPrefab;

    private void Start()
    {
        this.minions = new List<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {
        this.playerPosX = this.transform.position.x;

        int spawnLocation = 7;

        if (this.playerPosX >= spawnLocation) this.Spawn();
        else this.notSpawn();
    }
    void Spawn()
    {
        Debug.Log("Spawn");
        if (this.minions.Count >= 7) return;

        int index = this.minions.Count + 1;
        //GameObject minion = new GameObject("Minion #"+ index);
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "MinionPrefab #" + index;
        this.minions.Add(minion);
        //minion.AddComponent<If>();// HÀM THÊM SCRIPT CHO MỖI MINION REALTIME
        minion.transform.position = transform.position ;
    }

    void notSpawn()
    {
        Debug.Log("notSpawn");
    }
}
