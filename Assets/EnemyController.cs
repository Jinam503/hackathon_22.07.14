using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform spawnPoint;

    public float speed;

    Rigidbody2D rigid;

    public int curHp = 10;
    public int maxHp;

    private bool isAlive;
    private void Start()
    {
        isAlive = true;
        curHp = maxHp;
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (isAlive == false)
        {
            transform.position = spawnPoint.position;
            curHp = maxHp;
            isAlive = true;
        }
        rigid.velocity = transform.up * speed * -1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            curHp--;
            GameManager.instance.score += 100;
            if (curHp <= 0)
            {
                GameManager.instance.score += 3000;
                isAlive = false;

                
            }
        }
        if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Player")
        {
            isAlive = false;
        }
    }
}
