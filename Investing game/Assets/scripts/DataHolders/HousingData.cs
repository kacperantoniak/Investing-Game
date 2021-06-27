using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HousingData
{
//mieszkanie
    public static int ex_housing_helper;
    public int ex_housing;
//studio
    public static int ex_studio_helper;
    public int ex_studio;
//shop
    public static int ex_shop_helper;
    public int ex_shop;
//clotches
    public static int ex_clotches_helper;
    public int ex_clotches;
    public void Update_Housing_Data()
    {
        ex_housing = ex_housing_helper;
        ex_studio = ex_studio_helper;
        ex_shop = ex_shop_helper;
        ex_clotches = ex_clotches_helper;
    }

}
