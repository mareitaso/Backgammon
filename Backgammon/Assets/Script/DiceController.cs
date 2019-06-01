using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    [SerializeField]
    private Text Dice1, Dice2, CPUDice1, CPUDice2;

    [HideInInspector]
    public int Dice1Number, Dice2Number, NPCDice1Number, NPCDice2Number;

    [HideInInspector]
    public bool EvenNumber = false;
    [HideInInspector]
    public bool NPCEvenNumber = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickDiceButton()
    {
        Dice1Number = Random.Range(1, 7);
        Debug.Log(Dice1Number);
        Dice1.text = Dice1Number.ToString();

        Dice2Number = Random.Range(1, 7);
        Debug.Log(Dice2Number);
        Dice2.text = Dice2Number.ToString();

        //ぞろ目の時は2倍進める
        if (Dice1Number == Dice2Number)
        {
            EvenNumber = true;
            Debug.Log("プレイヤーはぞろ目なので2倍進めます");
        }

        NPCDice1Number = Random.Range(1, 7);
        Debug.Log(NPCDice1Number);
        CPUDice1.text = NPCDice1Number.ToString();

        NPCDice2Number = Random.Range(1, 7);
        Debug.Log(NPCDice2Number);
        CPUDice2.text = NPCDice2Number.ToString();

        //ぞろ目の時は2倍進める
        if (NPCDice1Number == NPCDice2Number)
        {
            NPCEvenNumber = true;
            Debug.Log("敵はぞろ目なので2倍進めます");
        }

        Debug.Log("");

    }
}
