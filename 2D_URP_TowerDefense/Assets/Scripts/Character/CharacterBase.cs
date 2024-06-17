using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType : byte
{
    Player = 0,
    Enemy
}
public class CharacterBase : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    public float damage = 10.0f;

    public float maxHP = 5.0f;

    float hp;

    public float HP
    {
        get => hp;
        set
        {
            hp = value;
        }
    }

    private void Awake()
    {
        
    }

    private void Move()
    {
        transform.position = Vector3.zero;
    }

    public void Attack()
    {

    }
}
