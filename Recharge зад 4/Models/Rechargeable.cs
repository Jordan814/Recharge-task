using Recharge_зад_4.Models.Contracts;

namespace Recharge_зад_4.Models;

public class Rechargeable
{
    public void Recharge(IRechargeable rechargeable)
    {
        rechargeable.Recharge();
    }
}