using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSensor : MonoBehaviour
{
    CharacterBase character;

    private void Awake()
    {
        character = GetComponentInParent<CharacterBase>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        character.Attack();
    }
}
