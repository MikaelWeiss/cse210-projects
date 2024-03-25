class Recurrence
{
    private DateTime StartDate { get; set; }
    private DateTime EndDate { get; set; }
    private int Frequency { get; set; }
    private string FrequencyType { get; set; }
    public Recurrence(DateTime startDate, DateTime endDate, int frequency, string frequencyType)
    {
        StartDate = startDate;
        EndDate = endDate;
        Frequency = frequency;
        FrequencyType = frequencyType;
        GenerateDates();
    }
    public List<DateTime> GenerateDates()
    {
        DateTime currentDate = StartDate;

        List<DateTime> dates = new List<DateTime>();

        while (currentDate <= EndDate)
        {
            dates.Add(currentDate);
            switch (FrequencyType)
            {
                case "day":
                    currentDate = currentDate.AddDays(Frequency);
                    break;
                case "week":
                    currentDate = currentDate.AddDays(Frequency * 7);
                    break;
                case "month":
                    currentDate = currentDate.AddMonths(Frequency);
                    break;
                case "year":
                    currentDate = currentDate.AddYears(Frequency);
                    break;
            }
        }

        return dates;
    }
}