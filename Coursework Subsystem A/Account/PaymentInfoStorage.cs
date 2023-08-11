using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursework_Subsystem_A.Account
{
    public class PaymentInfoStorage
    {
        public static bool usd = false, euro = false, ausd = false, gbp = false;
        private static string cardholderName, startDate, endDate, cardType, currency;
        private static int cV2, childCount;
        private static long cardNumber;
        private static double currentTotal, currentSubTotal, usdExchange = 1.3, ausdExchange = 1.7, euroExchange = 1.2;
        public static void setCV2(int c)
        {
            cV2 = c;
        }
        public static int getCV2()
        {
            return cV2;
        }
        public static void setCardholderName(string c)
        {
            cardholderName = c;
        }
        public static string getCardholderName()
        {
            return cardholderName;
        }
        public static void setStartDate(string s)
        {
            startDate = s;
        }
        public static string getStartDate()
        {
            return startDate;
        }
        public static void setEndDate(string e)
        {
            endDate = e;
        }
        public static string getEndDate()
        {
            return endDate;
        }
        public static void setCardType(string c)
        {
            cardType = c;
        }
        public static string getCardType()
        {
            return cardType;
        }
        public static void setCardNumber(long c)
        {
            cardNumber = c;
        }
        public static long getCardNumber()
        {
            return cardNumber;
        }
        public static void setCurrency(string c)
        {
            currency = c;
        }
        public static string getCurrency()
        {
            return currency;
        }
        public static void setChildCount(int c)
        {
            childCount = c;
        }
        public static int getChildCount()
        {
            return childCount;
        }
        public static void setCurrentTotal(double c)
        {
            currentTotal = c;
        }
        public static double getCurrentTotal()
        {
            return currentTotal;
        }
        public static void setCurrentSubTotal(double c)
        {
            currentSubTotal = c;
        }
        public static double getCurrentSubTotal()
        {
            return currentSubTotal;
        }
        public static double getUSDExchange()
        {
            return usdExchange;
        }
        public static double getEuroExchange()
        {
            return euroExchange;
        }
        public static double getAUSDExchange()
        {
            return ausdExchange;
        }
    }
}