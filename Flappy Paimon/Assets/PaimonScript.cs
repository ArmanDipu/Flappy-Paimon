using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaimonScript : MonoBehaviour
{
    public Rigidbody2D paimonRigidBody2D;
    public float flapStrength = 7.5f;
    public LogicScript logicScript;
    private bool isPaimonAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isPaimonAlive){
            paimonRigidBody2D.velocity = Vector2.up * flapStrength;
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Collision Happened");
        logicScript.gameOver();
        isPaimonAlive = false;
    }
}
