using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Info : MonoBehaviour
{
    TextMeshProUGUI money;
    TextMeshProUGUI time;
    TextMeshProUGUI score;

    float clock = 0.0f;

    Player player;

    private void Awake()
    {
        money = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        time = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        score = transform.GetChild(2).GetComponent<TextMeshProUGUI>();

        player = FindAnyObjectByType<Player>();
        player.onMoneyChange += Text_Money;
        player.onScoreChange += Text_Score;
    }


    private void Update()
    {
        clock += Time.deltaTime;
    }

    void Text_Money(int amount)
    {
        money.text = amount.ToString();
    }

    void Text_Time()
    {
        time.text = clock.ToString();
    }

    void Text_Score(int amount)
    {
        score.text = amount.ToString();
    }
}
