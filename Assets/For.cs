using UnityEngine;

public class For : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int maxMinion = 7;
        for (int i = 0; i < maxMinion; i++)
        {
            this.Spawn(i);
        }
    }
    void Spawn(int i)
    {
        Debug.Log("Spawn : "+ i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
