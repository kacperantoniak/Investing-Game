using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashData
{
    public static int ex_cash_helper;
    public int external_cash;
    public void update_Data()
    {
        external_cash = ex_cash_helper;
    }
}
