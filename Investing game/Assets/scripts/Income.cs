using UnityEngine;

public class Income : MonoBehaviour
{
    public int Total_income =  0;
    public static int income = 0;

    void Start()
    { 
        //check which buildings belong to player and calculate how much per second he gains?

        InvokeRepeating("Give", 0.5f, 1); //repeating ("<methodname>", <after>f<seconds>, <every>f<seconds>)
    }

    void Update()
    {
        switch(GlobalFlatKey.flat_key)
        {
            case 1:
                income = 10;
            break;

            case 2:
                income = 20;
            break;

            case 3:
                income = 30;
            break;
        }

        Total_income = income*GlobalFXP.xplvl;
    }
    
    void Give()
    {
        GlobalCash.Cash += Total_income;
    }
  
}
