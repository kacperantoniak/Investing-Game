using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXPData
{
    public static int ex_xp_helper;
    public int external_xp;
    //
    public static int ex_max_xp_helper;
    public int external_max_xp;
    //
    public static int ex_xplvl_helper;
    public int external_xplvl;
    public void update_Data()
    {
        external_xp = ex_xp_helper;
        external_max_xp = ex_max_xp_helper;
        external_xplvl = ex_xplvl_helper;
    }
}
