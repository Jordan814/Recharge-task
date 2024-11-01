using Recharge_зад_4.Models.Contracts;

namespace Recharge_зад_4.Models;

public abstract class HumanWorker : Worker, ISleeper
{
    public HumanWorker(string id) : base(id)
    {
    }

    public abstract void Sleep();
}