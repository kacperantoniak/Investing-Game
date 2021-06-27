using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeStudio : MonoBehaviour
{
    public GameObject UpgradeButton;
    public GameObject NextButton;
    public GameObject Studiolvl1;
    public GameObject Studiolvl2;
    public GameObject Studiolvl3;
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
    public void upgrade_Studio () 
    {
        GlobalCash.Cash -= UpgradePrice^(OwnedBuildings.studiolvl*2);
        OwnedBuildings.studiolvl = OwnedBuildings.studiolvl+1;
        Debug.Log("upgraded studio lvl:"+OwnedBuildings.studiolvl);
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
        switch(OwnedBuildings.studiolvl)
        {
            case 1:
                Studiolvl1.SetActive(true);
                Studiolvl2.SetActive(false);
                Studiolvl3.SetActive(false);
                break;
            case 2:
                Studiolvl1.SetActive(false);
                Studiolvl2.SetActive(true);
                Studiolvl3.SetActive(false);
                break;
            case 3:
                Studiolvl1.SetActive(false);
                Studiolvl2.SetActive(false);
                Studiolvl3.SetActive(true);
                UpgradeButton.SetActive(false);
                NextButton.SetActive(false);
                break;
        }
    }
}
