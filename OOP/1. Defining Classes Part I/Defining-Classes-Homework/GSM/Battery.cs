using System;
class Battery
{
    private string model;
    private double hoursTalk;
    private double hoursIdle;
    private BatteryType batteryType;
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }
    public string Model
    {
        get
        {
            return model;
        }
    }
    public double HoursTalk
    {
        get 
        {
            return hoursTalk;
        }
    }
    public double HoursIdle
    {
        get
        {
            return hoursIdle;
        }
    }
    public BatteryType Type
    {
        get
        {
            return batteryType;
        }
    }

    public Battery(string model,  double hoursIdle, double hoursTalk, BatteryType type)
    {
        this.model = model;
        if (hoursTalk > 0 && hoursIdle>0)
        {
            this.hoursTalk = hoursTalk;
            this.hoursIdle = hoursIdle;
        }
        else 
        {
            throw new ArgumentOutOfRangeException("Hours should be positive number!");
        }
        this.batteryType = type;
    }
}