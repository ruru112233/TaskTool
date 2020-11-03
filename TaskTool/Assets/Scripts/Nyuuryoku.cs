using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nyuuryoku : MonoBehaviour
{
    //オブジェクトと結びつける
    public InputField inputField;
    public Text text1, text2, text3, text4, text5, text6, text7, text8, text9, text10;

    void Start()
    {
        //Componentを扱えるようにする
        inputField = inputField.GetComponent<InputField>();
        text1 = text1.GetComponent<Text>();
        text2 = text2.GetComponent<Text>();
        text3 = text3.GetComponent<Text>();
        text4 = text4.GetComponent<Text>();
        text5 = text5.GetComponent<Text>();
        text6 = text6.GetComponent<Text>();
        text7 = text7.GetComponent<Text>();
        text8 = text8.GetComponent<Text>();
        text9 = text9.GetComponent<Text>();
        text10 = text10.GetComponent<Text>();

    }

    public void InputText()
    {
        //テキストにinputFieldの内容を反映
        if (GameManager.instance.taskNo == 1) text1.text = inputField.text;
        if (GameManager.instance.taskNo == 2) text2.text = inputField.text;
        if (GameManager.instance.taskNo == 3) text3.text = inputField.text;
        if (GameManager.instance.taskNo == 4) text4.text = inputField.text;
        if (GameManager.instance.taskNo == 5) text5.text = inputField.text;
        if (GameManager.instance.taskNo == 6) text6.text = inputField.text;
        if (GameManager.instance.taskNo == 7) text7.text = inputField.text;
        if (GameManager.instance.taskNo == 8) text8.text = inputField.text;
        if (GameManager.instance.taskNo == 9) text9.text = inputField.text;
        if (GameManager.instance.taskNo == 10) text10.text = inputField.text;
    }
}
