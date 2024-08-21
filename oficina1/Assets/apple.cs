using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;
    
    public GameObject collected;
    public int Score;


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponet<SpriteRenderer>();
        circle = GetComponet<CircleCollider2D>();
        
    }
    // Update is called once per frame
    void onTriggerEnter2D(Collider2d collider)
    {
        if(collider.GameObject.tag== "Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            Destroy(gameObject, 0.25f);
        
        }
        
    }
}
