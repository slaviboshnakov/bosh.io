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

    public Vector3 myFoodPos;

    public Rigidbody2D foodClone;

    void Start()
    {
        InvokeRepeating("spawnFood",5f,0.5f);
    }

    

    public void spawnFood()
    {
        myFoodPos = new Vector3(Random.Range(minX,maxX),Random.Range(minY,maxY),0); 

        var foodClone = Instantiate(foodSpawnPrefab, myFoodPos, transform.rotation);

    }

}
