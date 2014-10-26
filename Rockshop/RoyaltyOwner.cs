using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    class RoyaltyOwner
    {
        private int iroyaltyNo;
        private string sroyaltyName;
        private string spostalAddress;
        private decimal decminimumRoyalties;
        private int icurrentPeriodSales;
        private decimal deccurrentPeriodRoyalties;
        private decimal iyearToDateRoyalties;
        private int itotalSales;
        private decimal dectotalRoyalties;
        private DateTime dtelastPaymentDate;
    
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

        public string royaltyName
        {
            get
            {
                return sroyaltyName;
            }
            set
            {
                sroyaltyName = value;
            }
        }

        public string royaltyAddress
        {
            get
            {
                return spostalAddress;
            }
            set
            {
                spostalAddress = value;
            }
        }

        public decimal minimumRoyalties
        {
            get
            {
                return decminimumRoyalties;
            }
            set
            {
                decminimumRoyalties = value;
            }
        }

        public int currentPeriodSales
        {
            get
            {
                return icurrentPeriodSales;
            }
            set
            {
                icurrentPeriodSales = value;
            }
        }

        public decimal currentPeriodRoyalties
        {
            get
            {
                return deccurrentPeriodRoyalties;
            }
            set
            {
                deccurrentPeriodRoyalties = value;
            }
        }


        public int totalSales
        {
            get
            {
                return itotalSales;

            }
            set
            {
                itotalSales = value;
            }
        }

        public decimal totalToyalties
        {
            get
            {
                return dectotalRoyalties;
            }
            set
            {
                dectotalRoyalties = value;
            }
        }

        public DateTime lastPaymentDate
        {
            get
            {
                return dtelastPaymentDate;
            }
            set
            {
                dtelastPaymentDate = value;
            }
        }
    }
}
