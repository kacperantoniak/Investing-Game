using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadSave : MonoBehaviour
{
    void Awake()
    {   
        Load();
    }
    public void Load()
    {
        PlayerData data = SaveSys.LoadData();

        GlobalCash.Cash = data.cashData;
        GlobalFXP.xp = data.xpData;
        GlobalFXP.max_xp = data.maxxpData;
        GlobalFXP.xplvl = data.xplvlData;
        OwnedBuildings.housinglvl = data.housingData;//mieszkanie
        OwnedBuildings.studiolvl = data.studioData;//studio
        OwnedBuildings.shoplvl = data.shopData;//shop
        OwnedBuildings.clotcheslvl = data.clotchesData;//clotches
        GlobalVehicle.vehicle_data = data.vehicleData;
        GlobalFlatKey.flat_key = data.keyData;
        TimeManager.EndTime = data.endtimeData;
        TimeManager.ActionActive = data.activeData;

        Debug.Log("Save sucessfully loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
