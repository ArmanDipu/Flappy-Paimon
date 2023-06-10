using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaimonScript : MonoBehaviour
{
    public Rigidbody2D paimonRigidBody2D;
    public float flapStrength = 7.5f;
    public LogicScript logicScript;
    public bool isPaimonAlive = true;
    public Animator animator;

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

        if(Math.Abs(transform.position.y) > 10 && isPaimonAlive){
            Debug.Log("Player Went Out of Playable Area");
            logicScript.gameOver();
            isPaimonAlive = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        animator.SetBool("IsPaimonDead", true);
        Debug.Log("Collision Happened");
        logicScript.gameOver();
        isPaimonAlive = false;
    }
}
