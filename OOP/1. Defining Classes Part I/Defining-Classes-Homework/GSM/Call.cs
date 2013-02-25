using System;
using System.Linq;
class Call
{
    private DateTime dateAndTime;
    private string numberDialed;
    private int callDuration;
    public Call(DateTime time, string number, int durationInSeconds)
    {
        this.dateAndTime = time;
        this.numberDialed = number;
        this.callDuration = durationInSeconds;
    }
    public DateTime DateAndTime
    {
        get
        {
            return dateAndTime;
        }
    }
    public string NumberDialed
    {
        get 
        {
            return numberDialed;
        }
    }
    public int CallDuration
    {
        get
        {
            return callDuration;
        }
    }
}