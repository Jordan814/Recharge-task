using Recharge_зад_4.Models.Contracts;

namespace Recharge_зад_4.Models;

public abstract class RobotWorker : Worker, IRechargeable
{
    public RobotWorker(string id) : base(id)
    {
    }

    public abstract void Recharge();

}