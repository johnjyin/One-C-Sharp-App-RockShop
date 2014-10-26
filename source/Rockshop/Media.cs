using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    class Media
    {
        private int iproductNo;
        private string sproductName;
        private int iproductType;
        private string sfileType;
        private string surlSampler;
        private string surlMedia;
        private decimal decunitPrice;
        private int iroyaltyNo;
        private string sroyaltyOwner;
        private string sroyaltyAddress;
        private decimal decunitRoyalty;
        private DateTime dtedateAdded;

        public int productNo
        {
            get
            {
                return iproductNo;
            }
            set
            {
                iproductNo = value;
            }
        }

        public string productName
        {
            get
            {
                return sproductName;
            }
            set
            {
                sproductName = value;
            }
        }

        public int productType
        {
            get
            {
                return iproductType;
            }
            set
            {
                iproductType = value;
            }
        }

        public string fileType
        {
            get
            {
                return sfileType;
            }
            set
            {
                sfileType = value;
            }
        }

        public string urlSampler
        {
            get
            {
                return surlSampler;
            }
            set
            {
                surlSampler = value;
            }
        }

        public string urlMedia
        {
            get
            {
                return surlMedia;
            }
            set
            {
                surlMedia = value;
            }
        }

        public decimal unitPrice
        {
            get
            {
                return decunitPrice;
            }
            set
            {
                decunitPrice = value;
            }
        }

        public int royaltyNo
        {
            get
            {
                return iroyaltyNo;
            }
            set
            {
                iroyaltyNo = value;
            }
        }

        public string royaltyOwner
        {
            get
            {
                return sroyaltyOwner;
            }
            set
            {
                sroyaltyOwner = value;
            }
        }

        public string royaltyAddress
        {
            get
            {
                return sroyaltyAddress;
            }
            set
            {
                sroyaltyAddress = value;
            }
        }

        public decimal unitRoyalty
        {
            get
            {
                return decunitRoyalty;
            }
            set
            {
                decunitRoyalty = value;
            }
        }

        public DateTime dateAdded
        {
            get
            {
                return dtedateAdded;
            }
            set
            {
                dtedateAdded = value;
            }
        }

        public void validateProductName(string sProductName, bool Req)
        {
            sProductName = sProductName.Trim();
            if (!string.IsNullOrEmpty(sProductName))
            {
                sproductName = sProductName;
            } else
            if (Req)
            {
                throw new Exception("Error : " + "Product Name is required field", null);
            }
        }

        public void validateProductType(string sProductType, bool Req)
        {
            sProductType = sProductType.Trim();
            if (!string.IsNullOrEmpty(sProductType))
            {
                try
                {
                    iproductType = Convert.ToInt32(sProductType);
                }
                catch
                {
                    throw new Exception("Error : " + "Product Type is one Int field, please correct", null);
                }
            }
            else
                if (Req)
                {
                    throw new Exception("Error : " + "Product Type is required field", null);
                }
        }

        public void validateFileType(string sFileType, bool Req)
        {
            sFileType = sFileType.Trim();
            if (!string.IsNullOrEmpty(sFileType) && sFileType.Length <= 3)
            {
                sfileType = sFileType;
            }
            else
            if (sFileType.Length > 3)
            {
                throw new Exception("Error : File Type is 3 characters only!", null);
            } else
                if (Req)
                {
                    throw new Exception("Error : " + "File Type is required field", null);
                }
        }

        public void validateUrlSampler(string sUrlSampler, bool Req)
        {
            sUrlSampler = sUrlSampler.Trim();
            if (!string.IsNullOrEmpty(sUrlSampler))
            {
                surlSampler = sUrlSampler;
            }
            else
                if (Req)
                {
                    throw new Exception("Error : " + "URL Sampler is required field", null);
                }
        }

        public void validateUrlMedia(string sUrlMedia, bool Req)
        {
            sUrlMedia = sUrlMedia.Trim();
            if (!string.IsNullOrEmpty(sUrlMedia))
            {
                surlMedia = sUrlMedia;
            }
            else
                if (Req)
                {
                    throw new Exception("Error : " + "URL Media is required field", null);
                }
        }

        public void validateUnitPrice(string sUnitPrice, bool Req)
        {
            sUnitPrice = sUnitPrice.Trim();
            if (!string.IsNullOrEmpty(sUnitPrice))
            {
                try
                {
                    decunitPrice = Convert.ToDecimal(sUnitPrice);
                }
                catch
                {
                    throw new Exception("Error : " + "Unit Price is one Decimal field, please correct", null);
                }
            }
            else
                if (Req)
                {
                    throw new Exception("Error : " + "Unit Price is required field", null);
                }
        }

        public void validateRoyaltyNo(string sRoyaltyNo, bool Req)
        {
            sRoyaltyNo = sRoyaltyNo.Trim();
            if (!string.IsNullOrEmpty(sRoyaltyNo))
            {
                try
                {
                    iroyaltyNo = Convert.ToInt32(sRoyaltyNo);
                }
                catch
                {
                    throw new Exception("Error : " + "Royalty No is one Int field, please correct", null);
                }
            }
            else
                if (Req)
                {
                    throw new Exception("Error : " + "Royalty No is required field", null);
                }
        }

        public void validateUnitRoyalty(string sUnitRoyalty, bool Req)
        {
            sUnitRoyalty = sUnitRoyalty.Trim();
            if (!string.IsNullOrEmpty(sUnitRoyalty))
            {
                try
                {
                    decunitRoyalty = Convert.ToDecimal(sUnitRoyalty);
                }
                catch
                {
                    throw new Exception("Error : " + "Unit Royalty is one Int field, please correct", null);
                }
            }
            else
                if (Req)
                {
                    throw new Exception("Error : " + "Unit Royalty is required field", null);
                }
        }

        public void validateDateAdded(string sDateAdded, bool Req)
        {
            sDateAdded = sDateAdded.Trim();
            if (!string.IsNullOrEmpty(sDateAdded))
            {
                try
                {

                    dtedateAdded = Convert.ToDateTime(sDateAdded);
                    Console.WriteLine(dtedateAdded.ToString("yyyy-MM-dd"));
                }
                catch
                {
                    throw new Exception("Error : " + "Date Added is one Datetime field, please correct", null);
                }
            }
            else
                if (Req)
                {
                    throw new Exception("Error : " + "Date Added is required field", null);
                }
        }


    }
}
