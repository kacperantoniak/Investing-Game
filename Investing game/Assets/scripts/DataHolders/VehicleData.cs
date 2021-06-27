public class VehicleData
{
    public static bool[] ex_vehicle_helper = new bool[13];
    public bool[] external_vehicle = new bool[13];

    public void update_Data()
    {
        external_vehicle = ex_vehicle_helper;
    }
}
