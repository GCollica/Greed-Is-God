﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    private int health = 50;

    public GameObject playerScreen;
    public GameObject winScreen;
    public bool isDead;

    private void Start()
    {
        isDead = false;
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            isDead = true;
            Debug.Log("Congrats");
        }

        if (isDead == true)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            health--;
        }
    }
}
