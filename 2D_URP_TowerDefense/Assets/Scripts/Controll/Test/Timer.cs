using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;

    float remainTime;

    TextMeshProUGUI timerText;

    private void Awake()
    {
        remainTime = timer;
        timerText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        remainTime -= Time.deltaTime;
    }

    void TimeText()
    {
        timerText.text = remainTime.ToString();   
    }

}
