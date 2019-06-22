using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PieceController : MonoBehaviour
{
    private int CountNumber;

    [SerializeField]
    private GameObject Dice1Button, Dice2Button, PieceButton;

    private int MoveNumber = 0;

    [SerializeField]
    DiceController DiceController;

    [HideInInspector]
    public bool MoveDice1 = true;
    [HideInInspector]
    public bool MoveDice2 = true;

    void Start()
    {

    }

    void Update()
    {

    }

    public void PieceClick()
    {
        if (Dice1Button.GetComponent<Button>().interactable == false && MoveDice1 == true)
        {
            MoveDice1 = false;
            //NumberButton1();

            //ここでボタンを押されたときに数を取得して、その数をMoveNumberに代入
            MoveNumber = DiceController.Dice1Number;

            //数字を取得して進む関数
            PieceButton.GetComponent<RectTransform>().localPosition += new Vector3(MoveNumber * -50, 0, 0);
        }

        if (Dice2Button.GetComponent<Button>().interactable == false && MoveDice2 == true)
        {
            MoveDice2 = false;
            //1NumberButton2();

            //ここでボタンを押されたときに数を取得して、その数をMoveNumberに代入
            MoveNumber = DiceController.Dice2Number;

            //数字を取得して進む関数
            PieceButton.GetComponent<RectTransform>().localPosition += new Vector3(MoveNumber * -50, 0, 0);
        }
    }


    //左の数字を押したとき
    public void NumberButton1()
    {
        if (MoveDice1 == true)
        {
            Dice1Button.GetComponent<Button>().interactable = false;
            Dice2Button.GetComponent<Button>().interactable = true;
        }
        else
        if (MoveDice1 == false)
        {
            Dice2Button.GetComponent<Button>().interactable = false;
            Dice1Button.GetComponent<Button>().interactable = false;
        }
    }

    //右の数字を押したとき
    public void NumberButton2()
    {
        if (MoveDice2 == true)
        {
            Dice1Button.GetComponent<Button>().interactable = true;
            Dice2Button.GetComponent<Button>().interactable = false;
        }
        else if (MoveDice2 == false)
        {
            Dice1Button.GetComponent<Button>().interactable = false;
            Dice2Button.GetComponent<Button>().interactable = false;
        }


    }

    //ボタンを元に戻す
    public void DiceButtonTrue()
    {
        Dice1Button.GetComponent<Button>().interactable = true;
        Dice2Button.GetComponent<Button>().interactable = true;

        MoveDice1 = true;
        MoveDice2 = true;
    }

}
