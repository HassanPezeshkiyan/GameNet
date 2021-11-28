using System;
using System.Globalization;

namespace GameNet.App.infra
{
    public static class MyDateExtension
    {
        public static string ToPersianDateString(this DateTime dateTime)
        {
            if (dateTime < DateTime.Now.AddYears(-100))
            {
                return "";
            }

            PersianCalendar pc = new PersianCalendar();

            int year = pc.GetYear(dateTime);
            int month = pc.GetMonth(dateTime);
            int day = pc.GetDayOfMonth(dateTime);

            string ret = string.Format("{0:d4}/{1:d2}/{2:d2}", year, month, day);
            return ret;
        }

        public static string ToPersianDateString(this DateTime? dateTime)
        {
            if (dateTime == null)
            {
                return "";
            }

            if (dateTime < DateTime.Now.AddYears(-100))
            {
                return "";
            }

            PersianCalendar pc = new PersianCalendar();

            int year = pc.GetYear(dateTime.Value);
            int month = pc.GetMonth(dateTime.Value);
            int day = pc.GetDayOfMonth(dateTime.Value);

            string ret = string.Format("{0:d4}/{1:d2}/{2:d2}", year, month, day);
            return ret;
        }

        public static string ToPersianDateTimeString(this DateTime dateTime)
        {
            if (dateTime < DateTime.Now.AddYears(-100))
            {
                return "";
            }

            PersianCalendar pc = new PersianCalendar();

            int year = pc.GetYear(dateTime);
            int month = pc.GetMonth(dateTime);
            int day = pc.GetDayOfMonth(dateTime);

            string ret = string.Format("{0:d4}/{1:d2}/{2:d2} {3}", year, month, day, dateTime.TimeOfDay.ToString().Substring(0, 5));
            return ret;
        }

        public static string ToPersianDateTimeString(this DateTime? dateTime)
        {
            if (dateTime == null)
            {
                return "";
            }

            if (dateTime < DateTime.Now.AddYears(-100))
            {
                return "";
            }

            PersianCalendar pc = new PersianCalendar();

            int year = pc.GetYear(dateTime.Value);
            int month = pc.GetMonth(dateTime.Value);
            int day = pc.GetDayOfMonth(dateTime.Value);

            string ret = string.Format("{0:d4}/{1:d2}/{2:d2} {3}", year, month, day, dateTime.Value.TimeOfDay.ToString().Substring(0, 5));
            return ret;
        }

        public static DateTime ToEnglishDateTime(this string dateTime)
        {
            if (string.IsNullOrWhiteSpace(dateTime))
            {
                return DateTime.Now;
            }
            PersianCalendar pc = new PersianCalendar();
            int year = int.Parse(dateTime.Substring(0, 4));
            int month = int.Parse(dateTime.Substring(5, 2));
            int day = int.Parse(dateTime.Substring(8, 2));
            int hour = int.Parse(dateTime.Substring(11, 2));
            int min = int.Parse(dateTime.Substring(14, 2));
            return pc.ToDateTime(year, month, day, hour, min, 0, 0);
        }
        public static DateTime ToEnglishDate(this string date)
        {
            if (string.IsNullOrWhiteSpace(date))
            {
                return DateTime.Now;
            }
            PersianCalendar pc = new PersianCalendar();
            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(5, 2));
            int day = int.Parse(date.Substring(8, 2));
            return pc.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        public static DateTime? ToEnglishDateTimeNull(this string dateTime)
        {
            if (string.IsNullOrWhiteSpace(dateTime))
            {
                return null;
            }

            PersianCalendar pc = new PersianCalendar();
            int year = int.Parse(dateTime.Substring(0, 4));
            int month = int.Parse(dateTime.Substring(5, 2));
            int day = int.Parse(dateTime.Substring(8, 2));
            int hour = int.Parse(dateTime.Substring(11, 2));
            int min = int.Parse(dateTime.Substring(14, 2));
            return pc.ToDateTime(year, month, day, hour, min, 0, 0);
        }
        public static DateTime? ToEnglishDateNull(this string date)
        {
            if (string.IsNullOrWhiteSpace(date))
            {
                return null;
            }
            PersianCalendar pc = new PersianCalendar();
            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(5, 2));
            int day = int.Parse(date.Substring(8, 2));
            return pc.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
        public static string GetnameWeek(this DateTime dt)
        {
            string nameweek = "";
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    nameweek = "یک شنبه";
                    break;

                case DayOfWeek.Monday:
                    nameweek = "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    nameweek = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    nameweek = "چهار شنبه";
                    break;
                case DayOfWeek.Thursday:
                    nameweek = "پنج شنبه";
                    break;
                case DayOfWeek.Friday:
                    nameweek = "جمعه";
                    break;
                case DayOfWeek.Saturday:
                    nameweek = "شنبه";
                    break;

            }
            return nameweek;
        }
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" +
                   pc.GetDayOfMonth(value).ToString("00");
        }

        public static DateTime ToMiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }
    }
}
