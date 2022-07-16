using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float speed;
    public int damage;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rigid.velocity = transform.up * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            EnemyController ec =  collision.gameObject.GetComponent<EnemyController>();
            ec.GetDamage(damage);
            
        }
        if(collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
