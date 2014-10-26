using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/// <summary>
/// Required designer variable.
/// author: john yin
/// version: version: V0.1
/// create date: 5/5/2014
/// last update data: 5/5/2014
/// </summary>
/// 
namespace Rockshop
{
    class dacRoyaltyOwner
    {
        DataTable dt;
        dacMySQLConn dacMySql;
        //DataRow dataRow;

        public dacRoyaltyOwner()
        {
            dacMySql = new dacMySQLConn();
        }

        public List<RoyaltyOwner> GetRoyaltyOwners()
        {

            String ssql = "SELECT RoyaltyNo, RoyaltyName, PostalAddress "
                        + "FROM royaltyowners r ";

            dt = dacMySql.ExecuteQuery(ssql);

            List<RoyaltyOwner> RoyaltyOwners = new List<RoyaltyOwner>(dt.Rows.Count);

            foreach (DataRow dr in dt.Rows)
            {
                RoyaltyOwners.Add(new RoyaltyOwner
                {
                    royaltyNo = Convert.ToInt32(dr["RoyaltyNo"]),
                    royaltyName = Convert.ToString(dr["RoyaltyName"]),
                    royaltyAddress = Convert.ToString(dr["PostalAddress"])
                });
            }

            return RoyaltyOwners;
        }
    }

}
