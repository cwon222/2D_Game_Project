using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Info : MonoBehaviour
{
    TextMeshProUGUI money;
    TextMeshProUGUI time;
    TextMeshProUGUI score;

    private void Awake()
    {
        money = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        time = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        score = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
    }

    
}
