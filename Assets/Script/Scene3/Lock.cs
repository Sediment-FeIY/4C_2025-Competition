using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    private GameObject lockButton;
    private Button lockBt;

    private GameObject lockPanel;
    private bool lockActive = false;


    private Text one;
    private Text two;
    private Text three;
    private Text four;

    private GameObject Button1;
    private GameObject Button2;
    private GameObject Button3;
    private GameObject Button4;

    private Button B1;
    private Button B2;
    private Button B3;
    private Button B4;

    private int index1=0, index2=0, index3 = 0, index4=0;
    private string[] numbers;

    void Start()
    {
        lockButton = GameObject.Find("Lock");
        lockBt = lockButton.GetComponent<Button>();
        lockBt.onClick.AddListener(() => Debug.Log("锁定按钮被点击了"));

        one = GameObject.Find("第一位").GetComponent<Text>();
        two = GameObject.Find("第二位").GetComponent<Text>();
        three = GameObject.Find("第三位").GetComponent<Text>();
        four = GameObject.Find("第四位").GetComponent<Text>();

        Button1 = GameObject.Find("Button1");
        Button2 = GameObject.Find("Button2");
        Button3 = GameObject.Find("Button3");
        Button4 = GameObject.Find("Button4");

        B1 = Button1.GetComponent<Button>();
        B2 = Button2.GetComponent<Button>();
        B3 = Button3.GetComponent<Button>();
        B4 = Button4.GetComponent<Button>();
        B1.onClick.AddListener(() => NumberPlus(1));
        B2.onClick.AddListener(() => NumberPlus(2));
        B3.onClick.AddListener(() => NumberPlus(3));
        B4.onClick.AddListener(() => NumberPlus(4));

        numbers = new string[] { "一","二","三","四","五","六","七","八","九"};

        one.text = numbers[index1];
        two.text = numbers[index2];
        three.text = numbers[index3];
        four.text = numbers[index4];
    }

    private void NumberPlus(int index)
    {
       if(index==1)
        {
            index1++;
            if(index1>8)
            {
                index1 = 0;
            }
            one.text = numbers[index1];
        }
        if (index == 2)
        {
            index2++;
            if (index2 > 8)
            {
                index2 = 0;
            }
            two.text = numbers[index2];
        }
        if (index == 3)
        {
            index3++;
            if (index3 > 8)
            {
                index3 = 0;
            }
            three.text = numbers[index3];
        }
        if (index == 4)
        {
            index4++;
            if (index4 > 8)
            {
                index4 = 0;
            }
            four.text = numbers[index4];
        }
    }

    private void OnLockClicked()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
