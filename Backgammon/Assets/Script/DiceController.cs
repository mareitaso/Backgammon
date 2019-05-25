using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    [SerializeField]
    private Text Dice1;
    [SerializeField]
    private Text Dice2;
    [SerializeField]
    private Text CPUDice1;
    [SerializeField]
    private Text CPUDice2;

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
        int Dice1Number = Random.Range(1, 7);
        Debug.Log(Dice1Number);
        Dice1.text = Dice1Number.ToString();

        int Dice2Number = Random.Range(1, 7);
        Debug.Log(Dice2Number);
        Dice2.text = Dice2Number.ToString();

        int NPCDice1Number = Random.Range(1, 7);
        Debug.Log(NPCDice1Number);
        CPUDice1.text = NPCDice1Number.ToString();

        int NPCDice2Number = Random.Range(1, 7);
        Debug.Log(NPCDice2Number);
        CPUDice2.text = NPCDice2Number.ToString();

        Debug.Log("");
    }
}
