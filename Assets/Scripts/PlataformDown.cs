using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformDown : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
        StartCoroutine(plataform(5));
        }
    }

    IEnumerator plataform(float waitTime){
        yield return new WaitForSeconds(waitTime);
        rb.constraints = RigidbodyConstraints2D.None;
        StartCoroutine(destroyThis(15));
    }

    IEnumerator destroyThis(float waitTime){
        yield return new WaitForSeconds(waitTime);
        Destroy(this.gameObject);
    }

}
