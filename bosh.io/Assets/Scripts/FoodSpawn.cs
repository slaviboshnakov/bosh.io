using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{
    //public GameObject foodSpawnPrefab;
    public GameObject[] foodPrefabArray;

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    public Vector3 myFoodPos;

    public Rigidbody2D foodClone;

    void Start()
    {
        InvokeRepeating("spawnFood",5f,0.3f);
    }

    

    public void spawnFood()
    {
        var randFoodPrefab = Random.Range(0, foodPrefabArray.Length);
        myFoodPos = new Vector3(Random.Range(minX,maxX),Random.Range(minY,maxY),0); 


        var foodClone = Instantiate(foodPrefabArray[randFoodPrefab], myFoodPos, transform.rotation);

    }

}
