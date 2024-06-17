using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHP = 100.0f;

    float hp;
    public float HP
    {
        get => hp;
        set
        {
            hp = value;
            if(hp != value)
            {
                hp = value;
                onHPChange?.Invoke(hp);
            }
        }
    }

    public int score = 20;
    public int Score
    {
        get => score;
        set
        {
            score = value;
            onScoreChange?.Invoke(score);
        }
    }

    public int money = 10;

    public int Money
    {
        get => money;
        set
        {
            money = value;
            onMoneyChange?.Invoke(money);
        }
    }

    public Action<float> onHPChange;
    public Action<int> onMoneyChange;
    public Action<int> onScoreChange;

    private void Awake()
    {
        HP = maxHP;
    }
}
