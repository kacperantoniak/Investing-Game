using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class PlayerData
{
    public int housingData;//mieszkanie
    public int studioData;//studio
    public int shopData;//shop
    public int clotchesData;//clotches
    public int cashData;
    public int xpData;
    public int maxxpData;
    public int xplvlData;
    public bool[] vehicleData = new bool[13];
    public int keyData;
    public bool activeData;
    public DateTime endtimeData = new DateTime();
  
    public PlayerData (HousingData housing, CashData money, FXPData xp, VehicleData vehicle, FlatKeyData key, TimeData time)
    {
        //Debug.Log("PlayerData used...housinglvl:"+OwnedBuildings.housinglvl);
        housingData = housing.ex_housing;
        studioData = housing.ex_studio;
        shopData = housing.ex_shop;
        clotchesData = housing.ex_clotches;
        cashData = money.external_cash;
        xpData = xp.external_xp;
        maxxpData = xp.external_max_xp;
        xplvlData = xp.external_xplvl;
        vehicleData = vehicle.external_vehicle;
        keyData = key.external_key;
        activeData = time.external_action;
        endtimeData = time.external_endtime;
    }
}
