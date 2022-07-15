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
        if (instance == null) //instance�� null. ��, �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this; //���ڽ��� instance�� �־��ݴϴ�.
            DontDestroyOnLoad(gameObject); //OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
        }
        else
        {
            if (instance != this) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
                Destroy(this.gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ����
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
