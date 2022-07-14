using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float speed;
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(177, 183));
    }
    private void Update()
    {
        rigid.velocity = transform.up * speed * -1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
