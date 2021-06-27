using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autosavefile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    HousingData housing = new HousingData();
    CashData money = new CashData();
    FXPData xp = new FXPData();
    VehicleData vehicle = new VehicleData();
    FlatKeyData key = new FlatKeyData();
    TimeData time = new TimeData();
    public float repeatRate = 10f;
    private float timer = 0;
    
    // Update is called once per frame
    void Update()
    {
        if (timer < 0)//makes it do something every repeatRate value! <seconds>
        {
            money.update_Data();
            xp.update_Data();
            housing.Update_Housing_Data();
            vehicle.update_Data();
            key.update_Data();
            time.updateData();
            SaveSys.SaveData(housing, money, xp, vehicle, key, time);
            timer = repeatRate;
        }
    timer -= Time.deltaTime;
    }
}
