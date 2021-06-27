using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FXPBarScript : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        setMaxXP(GlobalFXP.max_xp);
    }
    public void setMaxXP(int max_xp)
    {
        slider.maxValue = max_xp;

        slider.value = 0;
    }

    public void SetXP(int xp)
    {
        slider.value = xp;
    }
}
