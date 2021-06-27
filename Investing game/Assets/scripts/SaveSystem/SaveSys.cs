using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSys
{
    public static void SaveData(HousingData housing, CashData money, FXPData xp, VehicleData vehicle, FlatKeyData key, TimeData time)//(OwnedBuildings housing, GlobalCash money)
    {
        //Debug.Log("Housing:"+housing.ex_housing+"Cash:"+money.external_cash+"XP:"+xp.external_xp);
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/investinggamesave.save"; 
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(housing, money, xp, vehicle, key, time);//(housing,money)

        formatter.Serialize(stream, data);
        stream.Close();
        //Debug.Log("saved");
    }

    public static PlayerData LoadData()
    {
        HousingData housing = new HousingData();
        CashData money = new CashData();
        FXPData xp = new FXPData();
        VehicleData vehicle = new VehicleData();
        FlatKeyData key = new FlatKeyData();
        TimeData time = new TimeData();
        
        string path = Application.persistentDataPath + "/investinggamesave.save"; //ZMIENIC TO
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Couldn't find save file at "+path+"\n Making new...");
            SaveData(housing , money, xp, vehicle, key, time);
            return null;
        }
    }
}
