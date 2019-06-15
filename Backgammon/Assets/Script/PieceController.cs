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
    DiceController GameManager;

    bool MoveDice1 = true;
    bool MoveDice2 = true;

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

            //ここでボタンを押されたときに数を取得して、その数をMoveNumberに代入
            MoveNumber = GameManager.Dice1Number;

            //数字を取得して進む関数
            PieceButton.GetComponent<RectTransform>().localPosition += new Vector3(MoveNumber * -50, 0, 0);
            
            //すべてのボタンをオンにする関数
            DiceButtonTrue();
        }

        if (Dice2Button.GetComponent<Button>().interactable == false && MoveDice2 == true)
        {
            MoveDice2 = false;

            //ここでボタンを押されたときに数を取得して、その数をMoveNumberに代入
            MoveNumber = GameManager.Dice2Number;

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
    }

    //右の数字を押したとき
    public void NumberButton2()
    {
        Dice1Button.GetComponent<Button>().interactable = true;
        Dice2Button.GetComponent<Button>().interactable = false;
    }

    //ボタンを元に戻す
    private void DiceButtonTrue()
    {
        Dice1Button.GetComponent<Button>().interactable = true;
        Dice2Button.GetComponent<Button>().interactable = true;
    }

}
