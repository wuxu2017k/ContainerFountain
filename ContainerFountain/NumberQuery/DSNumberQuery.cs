using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerFountain.NumberQuery
{
    partial class DSNumberQuery
    {
    }
}

namespace ContainerFountain.NumberQuery.DSNumberQueryTableAdapters
{
    partial class vNumberQueryTableAdapter
    {
        public int FillByWhere(DSNumberQuery.vNumberQueryDataTable tbl, string sWhere)
        {
            string oldCommandText = this.CommandCollection[0].CommandText;
            try
            {
                this.CommandCollection[0].CommandText += Environment.NewLine + sWhere;
                return this.Fill(tbl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CommandCollection[0].CommandText = oldCommandText;
            }
        }
    }

}
