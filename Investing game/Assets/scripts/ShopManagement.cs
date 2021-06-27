using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManagement : MonoBehaviour
{
    public GameObject TheShop;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject locked2;
    public GameObject locked3;
    public GameObject full;

    public GameObject Vehicle1;
    public GameObject Vehicle2;
    public GameObject Vehicle3;
    public GameObject Vehicle4;
    public GameObject Vehicle5;
    public GameObject Vehicle6;
    public GameObject Vehicle7;
    public GameObject Vehicle8;
    public GameObject Vehicle9;
    public GameObject Vehicle10;
    public GameObject Vehicle11;
    public GameObject Vehicle12;
    public GameObject Current;

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;
    public Image image10;
    public Image image11;
    public Image image12;

    public static int scene;

    public static int item1_value = 80000;
    public static int item1_xp_value = 5000;
    public static int item2_value = 250000;
    public static int item2_xp_value = 10000;
    public static int item3_value = 500000;
    public static int item3_xp_value = 20000;

    public static int vehicle1_value = 5000;
    public static int vehicle1_xp_value = 500;
    public static int vehicle2_value = 50000;
    public static int vehicle2_xp_value = 1000;
    public static int vehicle3_value = 250000;
    public static int vehicle3_xp_value = 2000;
    public static int vehicle4_value = 700000;
    public static int vehicle4_xp_value = 7000;
    public static int vehicle5_value = 100000;
    public static int vehicle5_xp_value = 1000;
    public static int vehicle6_value = 200000;
    public static int vehicle6_xp_value = 2000;
    public static int vehicle7_value = 400000;
    public static int vehicle7_xp_value = 4000;
    public static int vehicle8_value = 800000;
    public static int vehicle8_xp_value = 8000;
    public static int vehicle9_value = 100000;
    public static int vehicle9_xp_value = 1000;
    public static int vehicle10_value = 200000;
    public static int vehicle10_xp_value = 2000;
    public static int vehicle11_value = 400000;
    public static int vehicle11_xp_value = 4000;
    public static int vehicle12_value = 800000;
    public static int vehicle12_xp_value = 8000;

    void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        if(scene == 15)
        {
            if(GlobalFlatKey.flat_key == 3)
            {
                full.SetActive(true);
                Item1.SetActive(false);
                Item2.SetActive(false);
                Item3.SetActive(false);
                locked2.SetActive(false);
                locked3.SetActive(false);
            }
            switch(GlobalFlatKey.flat_key)
            {
                case 1:
                    locked2.SetActive(false);
                    Item1.SetActive(false);
                break;

                case 2:
                    locked3.SetActive(false);
                    locked2.SetActive(false);
                    Item1.SetActive(false);
                    Item2.SetActive(false);
                break;
            }
        }

        if(scene == 16)
        {
            if(GlobalVehicle.vehicle_data[1] == true)
            {
                Vehicle1.GetComponent<Button>().interactable = false;
                image1 = Vehicle1.GetComponentsInChildren<Image>()[1];
                image1.color = new Color(255,255,255,255);
                Vehicle1.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[2] == true)
            {
                Vehicle2.GetComponent<Button>().interactable = false;
                image2 = Vehicle2.GetComponentsInChildren<Image>()[1];
                image2.color = new Color(255,255,255,255);
                Vehicle2.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[3] == true)
            {
                Vehicle3.GetComponent<Button>().interactable = false;
                image3 = Vehicle3.GetComponentsInChildren<Image>()[1];
                image3.color = new Color(255,255,255,255);
                Vehicle3.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[4] == true)
            {
                Vehicle4.GetComponent<Button>().interactable = false;
                image4 = Vehicle4.GetComponentsInChildren<Image>()[1];
                image4.color = new Color(255,255,255,255);
                Vehicle4.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[5] == true)
            {
                Vehicle5.GetComponent<Button>().interactable = false;
                image5 = Vehicle5.GetComponentsInChildren<Image>()[1];
                image5.color = new Color(255,255,255,255);
                Vehicle5.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[6] == true)
            {
                Vehicle6.GetComponent<Button>().interactable = false;
                image6 = Vehicle6.GetComponentsInChildren<Image>()[1];
                image6.color = new Color(255,255,255,255);
                Vehicle6.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[7] == true)
            {
                Vehicle7.GetComponent<Button>().interactable = false;
                image7 = Vehicle7.GetComponentsInChildren<Image>()[1];
                image7.color = new Color(255,255,255,255);
                Vehicle7.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[8] == true)
            {
                Vehicle8.GetComponent<Button>().interactable = false;
                image8 = Vehicle8.GetComponentsInChildren<Image>()[1];
                image8.color = new Color(255,255,255,255);
                Vehicle8.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[9] == true)
            {
                Vehicle9.GetComponent<Button>().interactable = false;
                image9 = Vehicle9.GetComponentsInChildren<Image>()[1];
                image9.color = new Color(255,255,255,255);
                Vehicle9.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[10] == true)
            {
                Vehicle10.GetComponent<Button>().interactable = false;
                image10 = Vehicle10.GetComponentsInChildren<Image>()[1];
                image10.color = new Color(255,255,255,255);
                Vehicle10.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[11] == true)
            {
                Vehicle11.GetComponent<Button>().interactable = false;
                image11 = Vehicle11.GetComponentsInChildren<Image>()[1];
                image11.color = new Color(255,255,255,255);
                Vehicle11.GetComponentsInChildren<Text>()[0].text = "";
            }
            if(GlobalVehicle.vehicle_data[12] == true)
            {
                Vehicle12.GetComponent<Button>().interactable = false;
                image12 = Vehicle12.GetComponentsInChildren<Image>()[1];
                image12.color = new Color(255,255,255,255);
                Vehicle12.GetComponentsInChildren<Text>()[0].text = "";
            }
        }
    }

    public void TheShopEntrance()
    {
        Debug.Log("entrance");

        TheShop.SetActive(true);
    }

    public void TheShopExit()
    {
        TheShop.SetActive(false);
    }
    
    public void BuyItem1()
    {
        if(GlobalCash.Cash >= item1_value)
        {
            Debug.Log("Bought item1");
            GlobalCash.Cash -= item1_value; 
            GlobalFXP.xp += item1_xp_value;
            GlobalFlatKey.flat_key = 1;
            Item1.SetActive(false);
        }
        else{Debug.Log("insufficient amount of money");}
    }

    public void BuyItem2()
    {
        if(GlobalCash.Cash >= item2_value)
        {
            Debug.Log("Bought item2");
            GlobalCash.Cash -= item2_value; 
            GlobalFXP.xp += item2_xp_value;
            GlobalFlatKey.flat_key = 2;
            Item2.SetActive(false);
        }
        else{Debug.Log("insufficient amount of money");}
    }

    public void BuyItem3()
    {
        if(GlobalCash.Cash >= item3_value)
        {
            Debug.Log("Bought item3");
            GlobalCash.Cash -= item3_value; 
            GlobalFXP.xp += item3_xp_value;
            GlobalFlatKey.flat_key = 3;
            Item3.SetActive(false);
        }
        else{Debug.Log("insufficient amount of money");}
    }

    public void Detect()
    {
        switch(swipe_controller.selected)
        {
            case 1:
                Current = Vehicle1;
                BuyVehicle(Current, vehicle1_value, vehicle1_xp_value, image1);
            break;
            
            case 2:
                Current = Vehicle2;
                BuyVehicle(Current, vehicle2_value, vehicle2_xp_value, image2);
            break;
            
            case 3:
                Current = Vehicle3;
                BuyVehicle(Current, vehicle3_value, vehicle3_xp_value, image3);
            break;
            
            case 4:
                Current = Vehicle4;
                BuyVehicle(Current, vehicle4_value, vehicle4_xp_value, image4);
            break;
            
            case 5:
                Current = Vehicle5;
                BuyVehicle(Current, vehicle5_value, vehicle5_xp_value, image5);
            break;
            
            case 6:
                Current = Vehicle6;
                BuyVehicle(Current, vehicle6_value, vehicle6_xp_value, image6);
            break;
            
            case 7:
                Current = Vehicle7;
                BuyVehicle(Current, vehicle7_value, vehicle7_xp_value, image7);
            break;
            
            case 8:
                Current = Vehicle8;
                BuyVehicle(Current, vehicle8_value, vehicle8_xp_value, image8);
            break;
            
            case 9:
                Current = Vehicle9;
                BuyVehicle(Current, vehicle9_value, vehicle9_xp_value, image9);
            break;
            
            case 10:
                Current = Vehicle10;
                BuyVehicle(Current, vehicle10_value, vehicle10_xp_value, image10);
            break;
            
            case 11:
                Current = Vehicle11;
                BuyVehicle(Current, vehicle11_value, vehicle11_xp_value, image11);
            break;
            
            case 12:
                Current = Vehicle12;
                BuyVehicle(Current, vehicle12_value, vehicle12_xp_value, image12);
            break;
            
        }
    }
   public void BuyVehicle(GameObject gameObject, int price, int xp, Image checkmark)
    {
        if(GlobalCash.Cash >= price)
        {
            gameObject.GetComponent<Button>().interactable = false;
            gameObject.GetComponentsInChildren<Text>()[0].text = "";

            GlobalVehicle.vehicle_data[swipe_controller.selected] = true;

            Debug.Log(GlobalVehicle.vehicle_data[swipe_controller.selected]);

            checkmark = gameObject.GetComponentsInChildren<Image>()[1];
            checkmark.color = new Color(255,255,255,255);

            GlobalCash.Cash -= price;
            GlobalFXP.xp +=xp;

            Debug.Log("vehicle "+swipe_controller.selected+" has been bought");
        }
        else{Debug.Log("insufficient amount of money");}
    }

}


