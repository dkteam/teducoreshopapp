using System;
using System.Collections.Generic;
using System.Text;
using TeduCoreShopApp.Data.Enums;

namespace TeduCoreShopApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
