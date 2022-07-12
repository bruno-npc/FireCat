using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamTest : MonoBehaviour
{

    Rigidbody2D rb;
    float speed = 10;
    float direction;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer (){
        direction = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
    }
}
