using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



namespace ContainerFountain.ContainerInput
{
    partial class DSContainerFountain
    {

    }
}

namespace ContainerFountain.ContainerInput.DSContainerFountainTableAdapters
{
    partial class tcontainerTableAdapter
    {
        public int FillByWhere(DSContainerFountain.tcontainerDataTable tbl, string sWhere)
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