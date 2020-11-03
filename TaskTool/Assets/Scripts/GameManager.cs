using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startButton, stopButton;
    public GameObject timeListPanel;
    public GameObject meishouPanel;
    public GameObject clearPanel;
    public GameObject keisokuchuuText;

    public Text resultTime;

    // 作業時間一覧の時間表示
    public Text timeA, timeB, timeC, timeD, timeE, timeF, timeG, timeH, timeI, timeJ;

    Color yellow = new Color(1f, 0.92f, 0.016f, 1f);
    Color white = new Color(1f, 1f, 1f, 1f);

    Image color1;
    Image color2;
    Image color3;
    Image color4;
    Image color5;
    Image color6;
    Image color7;
    Image color8;
    Image color9;
    Image color10;


    public bool startFlag = false;
    public bool timeListFlag = false;
    public bool meishouFlag = false;
    public bool clearFlag = false;
    public bool keisokuchuuFlag = false;
    public bool stopFlag = false;

    public int taskNo;

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        taskNo = 1;

        color1 = GameObject.FindGameObjectWithTag("TaskButton1").GetComponent<Image>();
        color2 = GameObject.FindGameObjectWithTag("TaskButton2").GetComponent<Image>();
        color3 = GameObject.FindGameObjectWithTag("TaskButton3").GetComponent<Image>();
        color4 = GameObject.FindGameObjectWithTag("TaskButton4").GetComponent<Image>();
        color5 = GameObject.FindGameObjectWithTag("TaskButton5").GetComponent<Image>();
        color6 = GameObject.FindGameObjectWithTag("TaskButton6").GetComponent<Image>();
        color7 = GameObject.FindGameObjectWithTag("TaskButton7").GetComponent<Image>();
        color8 = GameObject.FindGameObjectWithTag("TaskButton8").GetComponent<Image>();
        color9 = GameObject.FindGameObjectWithTag("TaskButton9").GetComponent<Image>();
        color10 = GameObject.FindGameObjectWithTag("TaskButton10").GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {
        if (!startFlag)
        {
            startButton.SetActive(true);
            stopButton.SetActive(false);
        }
        else
        {
            startButton.SetActive(false);
            stopButton.SetActive(true);
        }

        if (timeListFlag)
        {
            timeListPanel.SetActive(true);
        }
        else
        {
            timeListPanel.SetActive(false);
        }

        if (meishouFlag)
        {
            meishouPanel.SetActive(true);
        }
        else
        {
            meishouPanel.SetActive(false);
        }

        if (clearFlag)
        {
            clearPanel.SetActive(true);
        }
        else
        {
            clearPanel.SetActive(false);
        }

        if (keisokuchuuFlag)
        {
            keisokuchuuText.SetActive(true);
        }
        else
        {
            keisokuchuuText.SetActive(false);
        }

        // 選択しているタスクのボタンに色を付ける
        if (taskNo == 1) color1.color = yellow; else color1.color = white;
        if (taskNo == 2) color2.color = yellow; else color2.color = white;
        if (taskNo == 3) color3.color = yellow; else color3.color = white;
        if (taskNo == 4) color4.color = yellow; else color4.color = white;
        if (taskNo == 5) color5.color = yellow; else color5.color = white;
        if (taskNo == 6) color6.color = yellow; else color6.color = white;
        if (taskNo == 7) color7.color = yellow; else color7.color = white;
        if (taskNo == 8) color8.color = yellow; else color8.color = white;
        if (taskNo == 9) color9.color = yellow; else color9.color = white;
        if (taskNo == 10) color10.color = yellow; else color10.color = white;

    }
}
