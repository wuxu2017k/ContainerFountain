using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerFountain.Datasets
{
}

namespace ContainerFountain.Datasets
{
}

namespace ContainerFountain.Datasets.DSedidTableAdapters
{
    partial class tygTableAdapter
    {
        /// <summary>
        /// <para>为tygTableAdapter的主SELECT语句增加WHERE条件</para>
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="aWhere">形如："WHERE intfld = 33 AND strfld LIKE 'abc%' ORDER BY xh"</param>
        /// <returns></returns>

        public int FillByWhere(DSedid.tygDataTable tbl, string aWhere)
        {
            string oldSelect = this.CommandCollection[0].CommandText;
            
            try
            {
                this.CommandCollection[0].CommandText += Environment.NewLine + aWhere;
                return this.Fill(tbl);
            }
            finally
            {
                this.CommandCollection[0].CommandText = oldSelect;
            }
        }
    }
}


namespace DLTVWG.Datasets
{


    partial class DSJckja
    {
    }
}
namespace ContainerFountain.Datasets
{


    public partial class DSedid
    {
    }
}
