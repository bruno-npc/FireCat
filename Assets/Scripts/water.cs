using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    float upSpeed;

    private void Start() {
        upSpeed = -7f;
    }

    void Update()
    {
        upSpeed += 0.3f * Time.deltaTime; 
        gameObject.transform.position = new Vector2 (5.5f, upSpeed);
    }
}
