using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnedBuildings :MonoBehaviour
{
    //mieszkanie
    public static int housinglvl = 1;
    public int internal_housinglvl;
    //studio
    public static int studiolvl= 1;
    public int internal_studiolvl;
    //shop
    public static int shoplvl=1;
    public int internal_shoplvl;
    //clotches
    public static int clotcheslvl=1;
    public int internal_clotcheslvl;

    void Update()
    {
        //mieszkanie
        internal_housinglvl = housinglvl;
        HousingData.ex_housing_helper = internal_housinglvl;
        //studio
        internal_studiolvl = studiolvl;
        HousingData.ex_studio_helper = internal_studiolvl;
        //shop
        internal_shoplvl = shoplvl;
        HousingData.ex_shop_helper = internal_shoplvl;
        //clotches
        internal_clotcheslvl = clotcheslvl;
        HousingData.ex_clotches_helper = internal_clotcheslvl;
    }
}