using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject EndGame;

    public int scoreMeter;
    public bool isAlive;

    //private static GameManager instance = null;
    //
    //void Awake()
    //{
    //    if (null == instance)
    //    {
    //        //�� Ŭ���� �ν��Ͻ��� ź������ �� �������� instance�� ���ӸŴ��� �ν��Ͻ��� ������� �ʴٸ�, �ڽ��� �־��ش�.
    //        instance = this;
    //
    //        //�� ��ȯ�� �Ǵ��� �ı����� �ʰ� �Ѵ�.
    //        //gameObject�����ε� �� ��ũ��Ʈ�� ������Ʈ�μ� �پ��ִ� Hierarchy���� ���ӿ�����Ʈ��� ��������, 
    //        //���� �򰥸� ������ ���� this�� �ٿ��ֱ⵵ �Ѵ�.
    //        DontDestroyOnLoad(this.gameObject);
    //    }
    //    else
    //    {
    //        //���� �� �̵��� �Ǿ��µ� �� ������ Hierarchy�� GameMgr�� ������ ���� �ִ�.
    //        //�׷� ��쿣 ���� ������ ����ϴ� �ν��Ͻ��� ��� ������ִ� ��찡 ���� �� ����.
    //        //�׷��� �̹� ���������� instance�� �ν��Ͻ��� �����Ѵٸ� �ڽ�(���ο� ���� GameMgr)�� �������ش�.
    //        Destroy(this.gameObject);
    //    }
    //}
    //
    ////���� �Ŵ��� �ν��Ͻ��� ������ �� �ִ� ������Ƽ. static�̹Ƿ� �ٸ� Ŭ�������� ���� ȣ���� �� �ִ�.
    //public static GameManager Instance
    //{
    //    get
    //    {
    //        if (null == instance)
    //        {
    //            return null;
    //        }
    //        return instance;
    //    }
    //}
    private void Awake()
    {
        scoreMeter = 0;
        isAlive = true;
        EndGame.SetActive(false);
    }


    private void Update()
    {
        if(isAlive)
        {
            scoreMeter++;
        }
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
