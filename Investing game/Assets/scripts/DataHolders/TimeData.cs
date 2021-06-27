using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeData
{
    public static DateTime ex_endtime_helper = new DateTime();
    public DateTime external_endtime = new DateTime();
    public static bool ex_action_helper;
    public bool external_action;

    public void updateData()
    {
        external_action = ex_action_helper;
        external_endtime = ex_endtime_helper;
    }
}
