using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("Player")){
            anim.SetBool("Trampolin_bool", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
            if(collision.gameObject.CompareTag("Player")){
            anim.SetBool("Trampolin_bool", true);
        }
    }
}
