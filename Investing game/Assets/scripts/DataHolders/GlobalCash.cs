using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public GameObject CashDisplay;

    public static int Cash = 100000;
    public int InternalCash;

    // Update is called once per frame
    void Update()
    {
        InternalCash = Cash;
        CashData.ex_cash_helper = InternalCash;
        CashDisplay.GetComponent<Text>().text = InternalCash +"$";
    }
}
