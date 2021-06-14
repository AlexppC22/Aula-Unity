using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public int moveSpd;

    void Update()
    {
        float movHorizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.D))
        {
            rigidBody2D.velocity = new Vector2(moveSpd, 0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rigidBody2D.velocity = new Vector2(-moveSpd, 0);
        }
    }
}
