// using System.Reflection.Metadata.Ecma335;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    public GameObject collected;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }


    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            Destroy(gameObject,0.25f);
        }
    }
}
