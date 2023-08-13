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
        public static void SetCV2(int c)
        {
            cV2 = c;
        }
        public static int GetCV2()
        {
            return cV2;
        }
        public static void SetCardholderName(string c)
        {
            cardholderName = c;
        }
        public static string GetCardholderName()
        {
            return cardholderName;
        }
        public static void SetStartDate(string s)
        {
            startDate = s;
        }
        public static string GetStartDate()
        {
            return startDate;
        }
        public static void SetEndDate(string e)
        {
            endDate = e;
        }
        public static string GetEndDate()
        {
            return endDate;
        }
        public static void SetCardType(string c)
        {
            cardType = c;
        }
        public static string GetCardType()
        {
            return cardType;
        }
        public static void SetCardNumber(long c)
        {
            cardNumber = c;
        }
        public static long GetCardNumber()
        {
            return cardNumber;
        }
        public static void SetCurrency(string c)
        {
            currency = c;
        }
        public static string GetCurrency()
        {
            return currency;
        }
        public static void SetChildCount(int c)
        {
            childCount = c;
        }
        public static int GetChildCount()
        {
            return childCount;
        }
        public static void SetCurrentTotal(double c)
        {
            currentTotal = c;
        }
        public static double GetCurrentTotal()
        {
            return currentTotal;
        }
        public static void SetCurrentSubTotal(double c)
        {
            currentSubTotal = c;
        }
        public static double GetCurrentSubTotal()
        {
            return currentSubTotal;
        }
        public static double GetUSDExchange()
        {
            return usdExchange;
        }
        public static double GetEuroExchange()
        {
            return euroExchange;
        }
        public static double GetAUSDExchange()
        {
            return ausdExchange;
        }
    }
}