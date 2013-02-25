using System;
using System.Collections.Generic;
using System.Text;
class GSM
{
    private string model;
    private string manufacturer;
    private string owner;
    private int? price;
    private Display display;
    private Battery battery;
    private List<Call> callHistory = new List<Call>();

    static private Battery iPhone4SBattery = new Battery("Built-in rechargable", 7, 300, Battery.BatteryType.LiIon);
    static private Display iPhone4SDisplay = new Display(3.5, 1000000);
    static private GSM iPhone4S = new GSM("Iphone 4S", "Apple", iPhone4SBattery, iPhone4SDisplay);

    static public GSM IPhone4S
    {
        get 
        {
            return iPhone4S;
        }
    }

    public GSM(string model, string manufacturer, int price, string owner, Battery myBattery, Display myDisplay)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        if (price > 0)
        {
            this.price = price;
        }
        else
        {
            throw new ArgumentException("Price must be positive");
        }
        this.owner = owner;
        this.battery = myBattery;
        this.display = myDisplay;
    }
    public GSM(string model, string manufacturer, int price, Battery myBattery, Display myDisplay)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        if (price > 0)
        {
            this.price = price;
        }
        else
        {
            throw new ArgumentException("Price must be positive");
        }
        this.owner = null;
        this.battery = myBattery;
        this.display = myDisplay;
    }
    public GSM(string model, string manufacturer, string owner, Battery myBattery, Display myDisplay)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = null;
        this.owner = owner;
        this.battery = myBattery;
        this.display = myDisplay;
    }
    public GSM(string model, string manufacturer, Battery myBattery, Display myDisplay)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = null;
        this.owner = null;
        this.battery = myBattery;
        this.display = myDisplay;
    }

    public string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.Append('*', 20);
        info.AppendFormat("\nGSM Information:\n");
        info.AppendFormat("Model: {0} {1}\n", manufacturer, model);
        if (price != null)
        {
            info.AppendFormat("Price: {0}\n", price);
        }
        if (owner != null)
        {
            info.AppendFormat("Current owner: {0}\n", owner);
        }
        info.Append('-', 20);
        info.AppendFormat("\nCurrent Battery Info:\n");
        info.AppendFormat("Battery: {0} {1}\n", battery.Type, battery.Model);
        info.AppendFormat("Hours Idle: {0} hours\n", battery.HoursIdle);
        info.AppendFormat("Hours Talk: {0} hours\n", battery.HoursTalk);
        info.Append('-', 20);
        info.AppendFormat("\nCurrent Display Info:\n");
        info.AppendFormat("Size: {0} inches\n", display.Size);
        info.AppendFormat("Colors: {0} \n", display.Colors);
        info.Append('*', 20);
        info.Append("\n");
        return info.ToString();
    }

    public List<Call> CallHistory
    {

        get
        {
            return callHistory;
        }    
    }

    public void AddCall(Call call)
    {
        callHistory.Add(call);
    }
    public void RemoveCall(Call call)
    {
        callHistory.Remove(call);
    }
    public double TotalPrice(double pricePerMinute)
    {
        double total=0;
        foreach (Call call in callHistory)
        {
            total += call.CallDuration;
        }
        return total / 60 * pricePerMinute;
    }
    public void ClearCallHistory()
    {
        callHistory.Clear();
    }
}