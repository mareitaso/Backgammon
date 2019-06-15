using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PieceController : MonoBehaviour
{
    private int CountNumber;

    [SerializeField]
    private GameObject Dice1Button, Dice2Button, PieceButton;

    private int MoveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            MoveNumber = 1;
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            MoveNumber = 2;
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            MoveNumber = 3;
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            MoveNumber = 4;
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            MoveNumber = 5;
        }

        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            MoveNumber = 6;
        }
    }

    public void PieceClick()
    {
        if (Dice1Button.GetComponent<Button>().interactable == false)
        {
            //ここでボタンを押されたときに数を取得して、その数をMoveNumberに代入

            //数字を取得して進む関数
            PieceButton.GetComponent<RectTransform>().localPosition += new Vector3(MoveNumber * -50, 0, 0);
            //すべてのボタンをオンにする関数

            DiceButtonTrue();
        }
        if (Dice2Button.GetComponent<Button>().interactable == false)
        {
            //数字を取得して進む関数
            PieceButton.GetComponent<RectTransform>().localPosition += new Vector3(MoveNumber * -50, 0, 0);
            //すべてのボタンをオンにする関数

            DiceButtonTrue();
        }
    }


    //左の数字を押したとき
    public void NumberButton1()
    {
        Dice1Button.GetComponent<Button>().interactable = false;
        Dice2Button.GetComponent<Button>().interactable = true;

        /*
        if (Dice1Button.GetComponent<Button>().interactable == false && PieceButton.GetComponent<Button>().interactable == false)
        {
            //数字を取得して進む関数
            PieceButton.GetComponent<RectTransform>().localPosition += new Vector3(-50, 0, 0);
            Debug.Log("移動");
            //すべてのボタンをオンにする関数

        }
        */
        //CountNumber = DiceController.

    }

    //右の数字を押したとき
    public void NumberButton2()
    {
        Dice1Button.GetComponent<Button>().interactable = true;
        Dice2Button.GetComponent<Button>().interactable = false;

        /*
        if (Dice2Button.GetComponent<Button>().interactable == false && PieceButton.GetComponent<Button>().interactable == false)
        {
            //数字を取得して進む関数
            PieceButton.GetComponent<RectTransform>().localPosition += new Vector3(-50, 0, 0);
            //すべてのボタンをオンにする関数

        }
        */
    }

    //ボタンを元に戻す
    private void DiceButtonTrue()
    {
        Dice1Button.GetComponent<Button>().interactable = true;
        Dice2Button.GetComponent<Button>().interactable = true;
    }

}
