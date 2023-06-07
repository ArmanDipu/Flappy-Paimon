using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawnerScript : MonoBehaviour
{
    public GameObject zongliPillar;
    public int spawnRate = 3;
    private float timer = 0f;
    public float heightOffset = 3f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPillar();
    }

    // Update is called once per frame
    void Update()
    {   
        if(timer < spawnRate){
            timer += Time.deltaTime ;
        }
        else{
            spawnPillar();
            timer = 0f;
        }
    }

    void spawnPillar(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(zongliPillar, 
            new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)),  
            transform.rotation);
    }
}
