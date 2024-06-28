using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBase : MonoBehaviour
{
    protected int maxHP = 10;

    protected int hp;

    public int HP
    {
        get => hp;
        set
        {
            hp = value;
            onHealthchange?.Invoke(hp);
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    protected float moveSpeed;

    public Action<int> onHealthchange;

    protected int shootDist;

    protected Animator unitAnim;
    protected LayerMask hittableLayer;
    protected Transform firePoint;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    protected void Move()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.right, shootDist, hittableLayer);

        if (hit.collider != null)
        {
            if (hit == GameObject.FindGameObjectWithTag("RedUnit"))
            {
                unitAnim.Play("BlueUnitOneAttack");
                moveSpeed = 0;
            }
        }
        else
        {
            unitAnim.Play("BlueUnitOneStil");
            moveSpeed = 0.25f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("EnemyU1Weapon"))
        {
            hp--;
        }
        if (collision.gameObject.CompareTag("EnemyU2Weapon"))
        {
            hp--;
        }
        if (collision.gameObject.CompareTag("EnemyU3Weapon"))
        {
            hp -= 3;
        }
    }
}
