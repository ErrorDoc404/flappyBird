using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlap : MonoBehaviour
{

    public Rigidbody2D bird;
    public float flap = 5;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
            bird.velocity = Vector2.up * flap;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
    }
}
