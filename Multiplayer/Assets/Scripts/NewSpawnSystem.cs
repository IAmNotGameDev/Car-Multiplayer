using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawnSystem : MonoBehaviour
{
    public static NewSpawnSystem instance;

    public Transform[] spawnpoints;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
