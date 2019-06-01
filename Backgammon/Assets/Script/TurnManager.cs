using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    [SerializeField]
    private Text TurnDice1,TurnDice2,CPUTurnDice1,CPUTurnDice2,FirstMessage;


    [SerializeField]
    private GameObject FirstButto;
    [SerializeField]
    private GameObject BB;


    private int PlayerNumber = 0;
    private int NPCNumber = 0;

    [HideInInspector]
    public bool before = true ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnClickChoiceTurnButton()
    {
        int Dice1Number = Random.Range(1, 7);
        Debug.Log(Dice1Number);
        TurnDice1.text = Dice1Number.ToString();

        int Dice2Number = Random.Range(1, 7);
        Debug.Log(Dice2Number);
        TurnDice2.text = Dice2Number.ToString();

        int NPCDice1Number = Random.Range(1, 7);
        Debug.Log(NPCDice1Number);
        CPUTurnDice1.text = NPCDice1Number.ToString();

        int NPCDice2Number = Random.Range(1, 7);
        Debug.Log(NPCDice2Number);
        CPUTurnDice2.text = NPCDice2Number.ToString();

        PlayerNumber = Dice1Number + Dice2Number;
        NPCNumber = NPCDice1Number + NPCDice2Number;

        if (PlayerNumber == NPCNumber)
        {
            FirstMessage.text = "もう一度\nやり直してください。";
            Debug.Log("ダイスの振り直し");
        }
        else if (PlayerNumber > NPCNumber)
        {
            //プレイヤーが先行
            FirstMessage.text = "プレイヤーが先行です。";
            //ボタンを押せなくする
            FirstButto.GetComponent<Button>().interactable = false;
            Debug.Log("プレイヤーが先行");
            before = true;
            Invoke("Destroy", 2.5f);
        }
        else
        {
            //NPCが先行
            FirstMessage.text = "NPCが先行です。";
            //ボタンを押せなくする
            FirstButto.GetComponent<Button>().interactable = false;
            Debug.Log("NPCが先行");
            before = false;
            Invoke("Destroy", 2.5f);
        }

        Debug.Log("");

    }

    private void Destroy()
    {
        Destroy(BB);
    }
}
