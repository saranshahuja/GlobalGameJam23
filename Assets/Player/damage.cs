using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public int lives = 5;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            lives--;
            GetComponent<Animator>().SetTrigger("Damage");

            if (lives <= 0)
            {
                // Game Over
            }
        }
    }
