using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    public GameObject foodSpawnPrefab;
    public int minX;
    public int minY;
    public int maxX;
    public int maxY;

    public RigidBody2D foodClone;

    void Start()
    {
        InvokeRepeating("spawnFood",5f,0.5f);
    }

    

    public void spawnFood()
    {
        var foodClone = Instantiate(foodSpawnPrefab, transform.position, transform.rotation);

    }

}
