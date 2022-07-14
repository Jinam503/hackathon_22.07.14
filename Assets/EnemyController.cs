using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float maxShootDelay;
    public float curShoorDelay;

    public GameObject targetPos;

    public int curHp = 10;
    public int maxHp;
    Vector3 vel = Vector3.zero;
    private Vector3 vec;

    public GameObject bullet;

    private bool isAlive;
    private void Start()
    {
        isAlive = true;
        vec = transform.position;
        curHp = maxHp;
        maxShootDelay = 0;
    }
    private void Update()
    {
        if (isAlive == false)
        {
            transform.position = vec;
            curHp = maxHp;
            isAlive = true;
        }
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPos.transform.position, ref vel, 0.4f);

        if (Mathf.Round(targetPos.transform.position.y) == Mathf.Round(transform.position.y))
        {
            Shoot();
            R();
        }
    }

    void R()
    {
        curShoorDelay += Time.deltaTime;
    }
    void Shoot()
    {
        if (curShoorDelay < maxShootDelay)
        {
            return;
        }
        Instantiate(bullet, transform.position, transform.rotation);
        curShoorDelay = 0;
        maxShootDelay = Random.Range(1.0f, 3.0f);

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
                
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z +5);
            }
        }
    }
}
