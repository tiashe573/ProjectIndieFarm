using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;

    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;

        rb.velocity = moveDirection * moveSpeed;


    }
}
