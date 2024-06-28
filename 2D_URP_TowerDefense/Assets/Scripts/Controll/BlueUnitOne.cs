using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueUnitOne : MonoBehaviour
{
    public int health;
    public float moveSpeed;
    public Animator unitAnim;
    public int shootDist;
    public LayerMask hittableLayer;
    public Transform firePoint;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.right, shootDist, hittableLayer);

        if(hit.collider != null)
        {
            if(hit == GameObject.FindGameObjectWithTag("RedUnit"))
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
            health--;
        }
        if (collision.gameObject.CompareTag("EnemyU2Weapon"))
        {
            health--;
        }
        if (collision.gameObject.CompareTag("EnemyU3Weapon"))
        {
            health -= 3;
        }
    }
}
