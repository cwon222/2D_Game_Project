using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RedBase : MonoBehaviour
{
    public int health;
    public TMP_Text baseCountText;
    public GameObject gameOverScene;
    

    // Start is called before the first frame update
    void Start()
    {
        health = 1;
        baseCountText.text = health.ToString();
        gameOverScene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        baseCountText.text = health.ToString();
        if (health <= 0)
        {
            gameOverScene.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GoodU1Weapon"))
        {
            health--;
            health = Mathf.Clamp(health, 0, 100);
            baseCountText.text = health.ToString();
        }
        if (collision.gameObject.CompareTag("GoodU2Weapon"))
        {
            health--;
            health = Mathf.Clamp(health, 0, 100);
            baseCountText.text = health.ToString();
        }
        if (collision.gameObject.CompareTag("GoodU3Weapon"))
        {
            health -= 3;
            health = Mathf.Clamp(health, 0, 100);
            baseCountText.text = health.ToString();
        }
    }
}