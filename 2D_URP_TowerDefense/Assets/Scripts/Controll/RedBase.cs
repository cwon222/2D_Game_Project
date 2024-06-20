using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class RedBase : MonoBehaviour
{
    public int maxHealth = 100;
    int health;
    public int Health
    {
        get => health;
        set => health = Mathf.Clamp(value, 0, health);
    }
    public TMP_Text baseCountText;
    public GameObject gameOverScene;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        SetMaxHealth(health);
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

    public void SetMaxHealth(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GoodU1Weapon"))
        {
            health--;
            health = Mathf.Clamp(health, 0, 100);
            slider.value = Health;
            baseCountText.text = health.ToString();
        }
        if (collision.gameObject.CompareTag("GoodU2Weapon"))
        {
            health--;
            health = Mathf.Clamp(health, 0, 100);
            slider.value = Health;
            baseCountText.text = health.ToString();
        }
        if (collision.gameObject.CompareTag("GoodU3Weapon"))
        {
            health -= 3;
            health = Mathf.Clamp(health, 0, 100);
            slider.value = Health;
            baseCountText.text = health.ToString();
        }
    }
}