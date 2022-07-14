using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float speed;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(-15, 15));
    }
    private void Update()
    {
        rigid.velocity = transform.up * -1 * speed;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
