using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public GameObject UpgradeButton;
    public GameObject NextButton;
    public GameObject Houselvl1;
    public GameObject Houselvl2;
    public GameObject Houselvl3;
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
    public void UpgradeHousing () 
    {
        GlobalCash.Cash -= UpgradePrice^(OwnedBuildings.housinglvl*2);
        OwnedBuildings.housinglvl = OwnedBuildings.housinglvl+1;
        Debug.Log("upgraded housing lvl:"+OwnedBuildings.housinglvl);
        //save
        money.update_Data();
        xp.update_Data();
        housing.Update_Housing_Data();
        vehicle.update_Data();
        key.update_Data();
        time.updateData();
        SaveSys.SaveData(housing, money, xp, vehicle, key, time);
    }

    // Update is called once per frame
    void Update()
    {
        switch(OwnedBuildings.housinglvl)
        {
            case 1:
                Houselvl1.SetActive(true);
                Houselvl2.SetActive(false);
                Houselvl3.SetActive(false);
                break;
            case 2:
                Houselvl1.SetActive(false);
                Houselvl2.SetActive(true);
                Houselvl3.SetActive(false);
                break;
            case 3:
                Houselvl1.SetActive(false);
                Houselvl2.SetActive(false);
                Houselvl3.SetActive(true);
                UpgradeButton.SetActive(false);
                NextButton.SetActive(false);
                break;
        }
    }
}
