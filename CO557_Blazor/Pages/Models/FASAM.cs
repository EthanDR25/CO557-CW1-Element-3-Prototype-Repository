namespace CO557_Blazor.Pages.Models
{
    public class FASAM
    {
        public static bool IsFire { get; set; }

        public static string StateOfLiftDoors = "Open";
        
        public static string DoorsLocked { get; set; }

        public static bool PeopleInside { get; set; }

        public static string EmergencySerivces { get; set; }

        public static string SprinklerSystem { get; set; }

        public static string Alarm { get; set; }

        public static void Run()
        {
            DoorsLocked = "Unlocked";
            PeopleInside = true;
            EmergencySerivces = "Not contacted";
            SprinklerSystem = "Off";
        }
        //public void ActivateAlarm()
        //{
        //    IsFire = true;

        //}

        public static void LockDoors()
        {
            DoorsLocked = "Locked";
        }

        //public void DetectFire()
        //{

        //}

        // Type 'T' to terminate

        //public void Terminate()
        //{

        //}

        // Type 'Zone Required' 

        //public void ZoneRequired()
        //{

        //}

        // Type 'P' to Print
        //public void Print()
        //{

        //}
        
        // Type 'F' to confirm fire

        //public void ConfirmFire()
        //{
        //    IsFire = false;
        //}

        public static void ActivateSprinklerSystem()
        {
            SprinklerSystem = "On";
        }

        public static void ContactES()
        {
            EmergencySerivces = "Contacted";
        }

        public static void ActivateAlarm()
        {
            Alarm = "On";
        }
    }
}
