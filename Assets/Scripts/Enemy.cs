using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 0.2f;
    private Rigidbody2D rb;
    private Vector2 movement;


    private void Awake()
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) *Mathf.Rad2Deg;
        //rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        changeSpeed();
    }

    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    void changeSpeed()
    {
        if (Player.isNight)
        {
            moveSpeed = 5f;
        }
    }



}
