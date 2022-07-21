using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public Text text;

    private void Awake()
    {
        text.text = "0";
        bulletLevel = 1;
    }
    public int bulletLevel;

    private void Update()
    {
        text.text = "" + bulletLevel;
    }
    public void BulletLevelUp()
    {
        if (bulletLevel <= 3)
        {
            bulletLevel++;
        }
    }
    public void BulletLevelDown()
    {
        if (bulletLevel > 1)
        {
            bulletLevel--;
        }
    }
    public void GameStart()
    {
        SceneManager.LoadScene("MainGame");
        GameManager.instance.isAlive = true;
    }
}
