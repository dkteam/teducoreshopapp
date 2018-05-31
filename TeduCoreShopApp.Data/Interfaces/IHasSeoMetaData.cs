using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreShopApp.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { get; set; }
        string SeoKeywords { set; get; }
        string SeoDescription { set; get; }
    }
}
