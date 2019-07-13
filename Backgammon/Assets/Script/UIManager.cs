using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Image MyGauge;
    [SerializeField]
    private Image NPCGauge;

    private float ClearPiece = 0;

    void Start()
    {

    }

    void Update()
    {

    }

    public void GaugeChange()
    {
        MyGauge.fillAmount = ClearPiece / 16;
    }

}
