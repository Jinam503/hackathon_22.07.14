using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float moveX;
    public float maxShootDelay;
    public float curShoorDelay;

    public int curHp ;
    public int maxHp = 3;

    [SerializeField]
    [Range(1f, 30f)]
    float moveSpeed;

    public GameObject bullet;

    void Start()
    {
        curHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Shoot();
        R();
    }
    void R()
    {
        curShoorDelay += Time.deltaTime;
    }
    int a = 2;
    void Shoot()
    {
        if(curShoorDelay < maxShootDelay)
        {
            return;
        }
        switch(a)
        {
            case 1:
                Instantiate(bullet, transform.position, transform.rotation);
                break;
            case 2:
                Vector3 vec1 = new Vector3(transform.position.x - 0.12f, transform.position.y, transform.position.z);
                Vector3 vec2 = new Vector3(transform.position.x + 0.12f, transform.position.y, transform.position.z);
                Instantiate(bullet, vec1, transform.rotation);
                Instantiate(bullet, vec2 , transform.rotation);
                break;
            case 3:
                break;
            case 4:
                break;
        }
        
        curShoorDelay = 0;

    }
    void Move()
    {
        moveX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        Vector2 vex = new Vector2(transform.position.x + moveX, -3.2f);
        transform.position = Clamp(vex);
    }
    public Vector2 Clamp(Vector2 pos)
    {
        return new Vector2(Mathf.Clamp(pos.x, -2.3f, 2.3f), -3.2f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            GameManager.instance.isAlive = false;
            GameManager.instance.EndGame.SetActive(true);
        }
        
    }
    

}
