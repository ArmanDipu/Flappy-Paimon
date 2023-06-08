using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePillarScript : MonoBehaviour
{
    public LogicScript logicScript ;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.layer==3){
            logicScript.addScore(1);
        }
    }
}
