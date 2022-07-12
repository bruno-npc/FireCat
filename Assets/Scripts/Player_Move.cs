using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    public float fire = 20;
    private float move;
    public float speed = 5;
    public float jumpForce = 5;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move, 0, 0) * Time.deltaTime * speed;

        if(!Mathf.Approximately(0, move)){
            transform.rotation = move > 0 ? Quaternion.Euler(0,180,0) : Quaternion.identity;
        }

        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.001f){
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }


    void ManagerCollision (GameObject coll)
    {
        if(coll.CompareTag("Trampolin")){
            rb.velocity = transform.up * 8f;
        }
        if(coll.CompareTag("Safe")){
            fire = fire + 3f;
        }
        if(coll.CompareTag("Safe_House")){
            fire = fire + 10f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        ManagerCollision(collision.gameObject);
    }

    private void OnCollisionExit2D(Collision2D collision) {
        ManagerCollision(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        ManagerCollision(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision) {
        
    }
}
