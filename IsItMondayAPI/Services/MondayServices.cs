namespace IsItMondayAPI.Services
{
    public class MondayServices
    {
        public bool IsItMonday() 
        {
            DateTime dt = DateTime.Now;
            return dt.DayOfWeek == DayOfWeek.Monday;
        }
    }
}
