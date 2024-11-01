using Recharge_зад_4.Models.Contracts;

namespace Recharge_зад_4.Models;

public class Employee : HumanWorker
{
    public Employee(string id) : base(id)
    {
    }

    public override void Sleep()
    {
        var theWorkerIsSleeping = "The worker is sleeping";
        
    }

}