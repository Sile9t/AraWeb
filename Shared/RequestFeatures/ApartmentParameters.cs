namespace Shared.RequestFeatures
{
    public class ApartmentParameters : RequestParameters
    {
        public ApartmentParameters() => OrderBy = "rate, reviewsCount";

        public DateTime OccupDate { get; set; } = DateTime.Now;
        public DateTime EvicDate { get; set; } = DateTime.Now.AddDays(1);

        public bool ValidDates => (EvicDate - OccupDate).TotalDays > 0;

        public double TotalDays => (OccupDate - EvicDate).TotalDays;

        public double MinSquare { get; set; }
        public double MaxSquare { get; set; } = uint.MaxValue;

        public bool ValidSquareRange => MaxSquare > MinSquare;

        public uint MinGuestsCount {  get; set; }
        public uint MaxGuestsCount { get; set; } = uint.MaxValue;

        public bool ValidGuestsRange => MaxGuestsCount > MinGuestsCount;

        public uint MinBedsCount { get; set; }
        public uint MaxBedsCount { get; set; } = uint.MaxValue;

        public bool ValidBedsRange => MaxBedsCount > MinBedsCount;

        public uint MinRoomsCount { get; set; }
        public uint MaxRoomsCount { get; set; } = uint.MaxValue;

        public bool ValidRoomsRange => MaxRoomsCount > MinRoomsCount;

        public double MinRate { get; set; }
        public double MaxRate { get; set; } = 10;

        public bool ValidRateRange => MaxRate > MinRate;

        public long MinReviewsCount { get; set; }
        public long MaxReviewsCount { get; set; } = long.MaxValue;

        public bool ValidReaviewsCountRange => MaxReviewsCount > MinReviewsCount;

        public string? SearchTerm { get; set; }
    }
}
