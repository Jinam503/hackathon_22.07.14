using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRecord : MonoBehaviour
{
    public GameManager gameManager;
    public Text text;
    public Text text2;
    // Update is called once per frame
    void Update()
    {
        text.text = gameManager.scoreMeter + "M";
        text2.text = gameManager.scoreMeter + "M";
    }
}
