using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeClotches : MonoBehaviour
{
    public GameObject UpgradeButton;
    public GameObject NextButton;
    public GameObject Clotcheslvl1;
    public GameObject Clotcheslvl2;
    public GameObject Clotcheslvl3;
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
    public void upgrade_Clotches () 
    {
        GlobalCash.Cash -= UpgradePrice^(OwnedBuildings.clotcheslvl*2);
        OwnedBuildings.clotcheslvl = OwnedBuildings.clotcheslvl+1;
        Debug.Log("upgraded studio lvl:"+OwnedBuildings.clotcheslvl);
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
        switch(OwnedBuildings.clotcheslvl)
        {
            case 1:
                Clotcheslvl1.SetActive(true);
                Clotcheslvl2.SetActive(false);
                Clotcheslvl3.SetActive(false);
                break;
            case 2:
                Clotcheslvl1.SetActive(false);
                Clotcheslvl2.SetActive(true);
                Clotcheslvl3.SetActive(false);
                break;
            case 3:
                Clotcheslvl1.SetActive(false);
                Clotcheslvl2.SetActive(false);
                Clotcheslvl3.SetActive(true);
                UpgradeButton.SetActive(false);
                NextButton.SetActive(false);
                break;
        }
    }
}
