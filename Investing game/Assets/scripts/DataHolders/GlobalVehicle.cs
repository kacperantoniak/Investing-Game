using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVehicle : MonoBehaviour
{
    public static bool[] vehicle_data = new bool[13];
    public bool[] internal_vehicle = new bool[13];

    void Update()
    {
        internal_vehicle = vehicle_data;
        VehicleData.ex_vehicle_helper = internal_vehicle;
    }
}
