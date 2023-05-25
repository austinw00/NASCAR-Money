namespace NASCAR_Money.Models
{
    public class DriverData
    {
        public int Nascar_Driver_ID { get; set; }
        public int Driver_ID { get; set; }
        public string Driver_Series { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Full_Name { get; set; }
        public string Series_Logo { get; set; }
        public string Short_Name { get; set; }
        public string Description { get; set; }
        public object DOB { get; set; }
        public DateTime DOD { get; set; }
        public string Hometown_City { get; set; }
        public string Crew_Chief { get; set; }
        public string Hometown_State { get; set; }
        public string Hometown_Country { get; set; }
        public int Rookie_Year_Series_1 { get; set; }
        public int Rookie_Year_Series_2 { get; set; }
        public int Rookie_Year_Series_3 { get; set; }
        public string Hobbies { get; set; }
        public string Children { get; set; }
        public string Twitter_Handle { get; set; }
        public string Residing_City { get; set; }
        public string Residing_State { get; set; }
        public string Residing_Country { get; set; }
        public string Badge { get; set; }
        public string Badge_Image { get; set; }
        public string Manufacturer { get; set; }
        public string Manufacturer_Small { get; set; }
        public string Team { get; set; }
        public string Image { get; set; }
        public string Image_Small { get; set; }
        public string Image_Transparent { get; set; }
        public string SecondaryImage { get; set; }
        public string Firesuit_Image { get; set; }
        public string Firesuit_Image_Small { get; set; }
        public string Career_Stats { get; set; }
        public string Driver_Page { get; set; }
        public int Age { get; set; }
        public string Rank { get; set; }
        public string Points { get; set; }
        public int Points_Behind { get; set; }
        public string No_Wins { get; set; }
        public string Poles { get; set; }
        public string Top5 { get; set; }
        public string Top10 { get; set; }
        public string Laps_Led { get; set; }
        public string Stage_Wins { get; set; }
        public string Playoff_Points { get; set; }
        public string Playoff_Rank { get; set; }
        public string Integrated_Sponsor_Name { get; set; }
        public string Integrated_Sponsor { get; set; }
        public string Integrated_Sponsor_URL { get; set; }
        public string Silly_Season_Change { get; set; }
        public string Silly_Season_Change_Description { get; set; }
    }

    public class Drivers
    {
        public int status { get; set; }
        public string message { get; set; }
        public List<DriverData> response { get; set; }
    }
}
