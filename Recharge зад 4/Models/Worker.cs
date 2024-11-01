using Recharge_зад_4.Models.Contracts;

namespace Recharge_зад_4.Models;

public abstract class Worker 
{
    
    private string id;
    private int workingHours;

    public Worker(string id)
    {
        this.id = id;
    }

    public void WorkingHours(int h)
    {
        this.workingHours = workingHours + h;
    }
    

}