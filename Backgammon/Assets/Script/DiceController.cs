using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceController : MonoBehaviour
{
    [SerializeField]
    GameObject Dice1;
    [SerializeField]
    GameObject Dice2;
    [SerializeField]
    GameObject CPUDice1;
    [SerializeField]
    GameObject CPUDice2;

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
       
        
        int Dice2Number = Random.Range(1, 7);
        Debug.Log(Dice2Number);
    }
}
