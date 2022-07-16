using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;

    Rigidbody2D rigid;

    public int curHp = 10;
    public int maxHp;

    private void Start()
    {
        curHp = maxHp;
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        GoDown();
    }
    public void GoDown()
    {
        rigid.velocity = transform.up * speed * -1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            curHp--;
            if (curHp <= 0)
            {
                Destroy(gameObject);
            }
        }
        if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
