using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeShop : MonoBehaviour
{
    public GameObject UpgradeButton;
    public GameObject NextButton;
    public GameObject Shoplvl1;
    public GameObject Shoplvl2;
    public GameObject Shoplvl3;
    //save system
    HousingData housing = new HousingData();
    CashData money = new CashData();
    FXPData xp = new FXPData();
    VehicleData vehicle = new VehicleData();
    FlatKeyData key = new FlatKeyData();
    TimeData time = new TimeData();
    // Start is called before the first frame update
    void Start()
    {
    }
    public int UpgradePrice = 10;
    public void upgrade_Shop () 
    {
        GlobalCash.Cash -= UpgradePrice^(OwnedBuildings.shoplvl*2);
        OwnedBuildings.shoplvl = OwnedBuildings.shoplvl+1;
        Debug.Log("upgraded shop lvl:"+OwnedBuildings.shoplvl);
        //save
        money.update_Data();
        xp.update_Data();
        housing.Update_Housing_Data();
        vehicle.update_Data();
        key.update_Data();
        SaveSys.SaveData(housing, money, xp, vehicle, key, time);
    }

    // Update is called once per frame
    void Update()
    {
        switch(OwnedBuildings.shoplvl)
        {
            case 1:
                Shoplvl1.SetActive(true);
                Shoplvl2.SetActive(false);
                Shoplvl3.SetActive(false);
                break;
            case 2:
                Shoplvl1.SetActive(false);
                Shoplvl2.SetActive(true);
                Shoplvl3.SetActive(false);
                break;
            case 3:
                Shoplvl1.SetActive(false);
                Shoplvl2.SetActive(false);
                Shoplvl3.SetActive(true);
                UpgradeButton.SetActive(false);
                NextButton.SetActive(false);
                break;
        }
    }
}
