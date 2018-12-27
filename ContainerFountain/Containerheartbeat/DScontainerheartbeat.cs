using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerFountain.Containerheartbeat
{
    partial class DScontainerheartbeat
    {
    }
}

namespace ContainerFountain.Containerheartbeat.DScontainerheartbeatTableAdapters
{
    partial class tcontainer_statusTableAdapter
    {
        public int FillByWhere(DScontainerheartbeat.tcontainer_statusDataTable tbl, string sWhere)
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

    partial class vcontainerStatusTableAdapter
    {
        public int FillByWhere(DScontainerheartbeat.vcontainerStatusDataTable tbl, string sWhere)
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