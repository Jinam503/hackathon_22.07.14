using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private void Awake()
    {
        EndGame.SetActive(false);
        if (instance == null) //instance가 null. 즉, 시스템상에 존재하고 있지 않을때
        {
            instance = this; //내자신을 instance로 넣어줍니다.
            DontDestroyOnLoad(gameObject); //OnLoad(씬이 로드 되었을때) 자신을 파괴하지 않고 유지
        }
        else
        {
            if (instance != this) //instance가 내가 아니라면 이미 instance가 하나 존재하고 있다는 의미
                Destroy(this.gameObject); //둘 이상 존재하면 안되는 객체이니 방금 AWake된 자신을 삭제
        }
    }

    public  int score;
    public  int Hp;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject EndGame;
    private void Update()
    {
        switch(Hp)
        {
            case 2:
                obj3.SetActive(false);
                break;
                
            case 1:
                obj2.SetActive(false);
                break;
            case 0:
                obj1.SetActive(false);
                EndGame.SetActive(true);
                break;
        }
    }
}
