using Recharge_зад_4.Models.Contracts;

namespace Recharge_зад_4.Models;

public class Robot : RobotWorker
{
    private int capacity;

    private int currentPower;
    
    
    public Robot(string id, int capacity) : base(id)
    {
        this.capacity = capacity;
        
    }

    public int Capacity =>  this.capacity;

    public int CurrentPower
    {
        get
        {
            return this.currentPower;
        }
        set
        {
            this.currentPower = value;
        }
    }


    public void work(int h)
    {
        if (h > currentPower)
        {
            h = currentPower;
        }
        base.WorkingHours(h);
        this.currentPower = currentPower - h;
    }
    
    public override void Recharge()
    {
        this.currentPower = this.capacity;
    }
}