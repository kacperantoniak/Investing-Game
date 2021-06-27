using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFXP : MonoBehaviour
{
    public static int xp =0;
    public int internal_xp;
    //
    public static int max_xp = 1000;
    public int internal_max_xp;
    //
    public static int xplvl = 1;
    public int internal_xplvl;
    //save system schenanigans
    HousingData housing = new HousingData();
    CashData money = new CashData();
    FXPData savexp = new FXPData();
    VehicleData vehicle = new VehicleData();
    FlatKeyData key = new FlatKeyData();
    TimeData time = new TimeData();

    public FXPBarScript xpBar;
    public GameObject lvl_Display;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        internal_xp = xp;
        FXPData.ex_xp_helper = internal_xp;
        
        internal_max_xp = max_xp;
        FXPData.ex_max_xp_helper = internal_max_xp;
        
        internal_xplvl = xplvl;
        FXPData.ex_xplvl_helper = internal_xplvl;

        string lvl_display = ""+internal_xplvl;

        xpBar.SetXP(xp);
        
        if(xp >= max_xp)
        {
            xplvl = xplvl +1;
            xp = xp - max_xp;
            switch(xplvl)
            {
                case 2:
                    max_xp = 5000;
                break;
                case 3:
                    max_xp = 10000;
                break;
                case 4:
                    max_xp = 15000;
                break;
                case 5:
                    max_xp = 20000;
                break;
                case 6:
                    max_xp = 25000;
                break;
                case 7:
                    max_xp = 30000;
                break;
                case 8:
                    max_xp = 35000;
                break;
                case 9:
                    max_xp = 40000;
                break;
                case 10:
                    max_xp = 45000;
                break;
                case 11:
                    max_xp = 50000;
                break;
                case 12:
                    max_xp = 55000;
                break;
                case 13:
                    max_xp = 60000;
                break;
                case 14:
                    max_xp = 65000;
                break;
                case 15:
                    max_xp = 70000;
                break;
                case 16:
                    max_xp = 75000;
                break;
                case 17:
                    max_xp = 85000;
                break;
                case 18:
                    max_xp = 90000;
                break;
                case 19:
                    max_xp = 95000;
                break;
                case 20:
                    max_xp = 100000;
                break;
                case 21:
                    max_xp = 105000;
                break;
                case 22:
                    max_xp = 110000;
                break;
                case 23:
                    max_xp = 115000;
                break;
                case 24:
                    max_xp = 120000;
                break;
                case 25:
                    max_xp = 125000;
                break;
            }
            xpBar.setMaxXP(max_xp);
            //xp = 0; should be fine
            Debug.Log("LVL UP! current lvl:"+xplvl);
            //save
            money.update_Data();
            savexp.update_Data();
            housing.Update_Housing_Data();
            vehicle.update_Data();
            key.update_Data();
            time.updateData();
            SaveSys.SaveData(housing, money, savexp, vehicle, key, time);
        }
        lvl_Display.GetComponent<Text>().text = lvl_display;
    }
    /*public void AddXP() //TEMP for the button
    {
        Debug.Log("xp b4 addition:"+xp);

        xp = xp+10;

        Debug.Log("xp after:"+xp);
    }*/
}
