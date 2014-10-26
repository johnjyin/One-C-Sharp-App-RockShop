using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

/// <summary>
/// Required designer variable.
/// author: john yin
/// version: V0.3
/// create date: 5/5/2014
/// last update data: 23/5/2014
/// </summary>
/// 

namespace Rockshop
{
    class dacMedia
    {
        DataTable dt;
        dacMySQLConn dacMySql;
        //DataRow dataRow;

        public dacMedia()
        {
            dacMySql = new dacMySQLConn();
        }

        public int Insert(Media media)
        {
            String sql1 = "";               String sql2 = "";
            sql1 += "INSERT INTO Media (";  sql2 = "VALUES (";
            sql1 += "ProductName, ";        sql2 += " '" + media.productName + "', ";
            sql1 += "ProductType, ";        sql2 += media.productType.ToString() + ", ";
            sql1 += "FileType, ";           sql2 += " '" + media.fileType + "', ";
            sql1 += "URLSampler, ";         sql2 += " '" + media.urlSampler + "', ";
            sql1 += "URLMedia, ";           sql2 += " '" + media.urlMedia + "', ";
            sql1 += "UnitPrice, ";          sql2 += media.unitPrice.ToString() + ", ";
            sql1 += "RoyaltyNo, ";          sql2 += media.royaltyNo.ToString() + ", ";
            sql1 += "UnitRoyalty, ";        sql2 += media.unitRoyalty.ToString() + ", ";
            sql1 += "DateAdded) ";          sql2 += " '" + media.dateAdded.ToString("yyyy-MM-dd") + "')";
            String ssql = sql1 + sql2;
            int count = dacMySql.ExecuteNonQuery(ssql);
            return count;
        }

        public int LastUsedProductNo()
        {
            String ssql = "SELECT MAX(ProductNo) as max_no FROM media";

            dt = dacMySql.ExecuteQuery(ssql);

            if (dt.Rows.Count == 1)
            {
                if ( !(dt.Rows[0].IsNull("max_no")) ) {
                    return Convert.ToInt32(dt.Rows[0]["max_no"]);
                } else {
                    return 0;
                }
            } else
            {
                return 0;
            }
        }

        public List<Media> GetMedias()
        {

            /*String ssql = "SELECT ProductNo, ProductName, ProductType, "
                        + "FileType, URLSampler, URLMedia, UnitPrice, "
                        + "RoyaltyNo, UnitRoyalty, DateAdded "
                        + "FROM media";
            */
            String ssql = "SELECT * " 
                        + "FROM media m "
                        + "LEFT JOIN royaltyowners r "
                        + "ON m.RoyaltyNo = r.RoyaltyNo";
            dt = dacMySql.ExecuteQuery(ssql);

            List<Media> Medias = new List<Media>(dt.Rows.Count);

            foreach (DataRow dr in dt.Rows)
            {
                Medias.Add( new Media { 
                    productNo = Convert.ToInt32(dr["ProductNo"]),
                    productName = Convert.ToString(dr["ProductName"]),
                    productType = Convert.ToInt32(dr["ProductType"]),
                    fileType = Convert.ToString(dr["FileType"]),
                    urlSampler = Convert.ToString(dr["URLSampler"]),
                    urlMedia = Convert.ToString(dr["URLMedia"]),
                    unitPrice = Convert.ToDecimal(dr["UnitPrice"]),
                    royaltyNo = Convert.ToInt32(dr["RoyaltyNo"]),
                    royaltyOwner = Convert.ToString(dr["RoyaltyName"]),
                    royaltyAddress = Convert.ToString(dr["PostalAddress"]),
                    unitRoyalty = Convert.ToDecimal(dr["UnitRoyalty"]),
                    dateAdded = Convert.ToDateTime(dr["DateAdded"])
                });
            }

            return Medias;
        }

        public int Delete(Media media)
        {
            String ssql = "DELETE from media "
                        + "where ProductNo = " + media.productNo.ToString();
            int count = dacMySql.ExecuteNonQuery(ssql);
            return count;
        }

        public int Update(Media media)
        {
            String ssql = "";
            ssql += "UPDATE Media SET ";
            ssql += "ProductName = '"       + media.productName + "', ";
            ssql += "ProductType = "        + media.productType.ToString() + ", ";
            ssql += "FileType = '"          + media.fileType + "', ";
            ssql += "URLSampler = '"        + media.urlSampler + "', ";
            ssql += "URLMedia = '"          + media.urlMedia + "', ";
            ssql += "UnitPrice = "          + media.unitPrice.ToString() + ", ";
            ssql += "RoyaltyNo = "          + media.royaltyNo.ToString() + ", ";
            ssql += "UnitRoyalty = "        + media.unitRoyalty.ToString() + ", ";
            ssql += "DateAdded = '"         + media.dateAdded.ToString("yyyy-MM-dd") + "' ";
            ssql += "WHERE ProductNo = "    + media.productNo;
            int count = dacMySql.ExecuteNonQuery(ssql);
            return count;
        }

        public bool Search(Media media, ref List<Media> lst)
        {
            /*
             *      By default, in C#, value types (such as the int, decimal, and bool types)
             *      can't store null values.
             *      
             *      int : 0
             *      Datetime : default(DateTime)
             *      
             *      string : null
             *      
             *      However, C# allow us to define them as nullable types to store a null value
             * 
             *
             */
            String ssql = "";
            ssql += "SELECT * ";
            ssql += "FROM media m ";
            ssql += "LEFT JOIN royaltyowners r ";
            ssql += "ON m.RoyaltyNo = r.RoyaltyNo ";
            ssql += "WHERE  ";
            ssql += "m.ProductName like '%"       + ( media.productName != null ? media.productName.ToString() : "" ) + "%' AND ";
            ssql += "m.ProductType like '%"       + ( media.productType != 0 ? media.productType.ToString() : "" ) + "%' AND ";
            ssql += "m.FileType like '%" + ( media.fileType != null ? media.fileType.ToString() : "" ) + "%' AND ";
            ssql += "m.URLSampler like '%" + ( media.urlSampler != null ? media.urlSampler.ToString() : "" ) + "%' AND ";
            ssql += "m.URLMedia like '%" + ( media.urlMedia != null ? media.urlMedia.ToString() : "" )  +"%' AND ";
            ssql += "m.UnitPrice like '%" + ( media.unitPrice != 0 ? media.unitPrice.ToString() : "" ) + "%' AND ";
            ssql += "m.RoyaltyNo like '%" + ( media.royaltyNo != 0 ? media.royaltyNo.ToString() : "" )  +"%' AND ";
            ssql += "m.UnitRoyalty like '%" + ( media.unitRoyalty != 0 ? media.unitRoyalty.ToString() : "" ) + "%' AND ";
            ssql += "m.DateAdded like '%" + (media.dateAdded != default(DateTime) ? media.dateAdded.ToString("yyyy-MM-dd") : "") + "%' ";

            dt = dacMySql.ExecuteQuery(ssql);

            if (dt.Rows.Count >= 1)
            {
                lst.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    lst.Add(new Media
                    {
                        productNo   = Convert.ToInt32(dr["ProductNo"]),
                        productName = Convert.ToString(dr["ProductName"]),
                        productType = Convert.ToInt32(dr["ProductType"]),
                        fileType    = Convert.ToString(dr["FileType"]),
                        urlSampler  = Convert.ToString(dr["URLSampler"]),
                        urlMedia    = Convert.ToString(dr["URLMedia"]),
                        unitPrice   = Convert.ToDecimal(dr["UnitPrice"]),
                        royaltyNo   = Convert.ToInt32(dr["RoyaltyNo"]),
                        royaltyOwner = Convert.ToString(dr["RoyaltyName"]),
                        royaltyAddress = Convert.ToString(dr["PostalAddress"]),
                        unitRoyalty = Convert.ToDecimal(dr["UnitRoyalty"]),
                        dateAdded   = Convert.ToDateTime(dr["DateAdded"])
                    });
                }

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
