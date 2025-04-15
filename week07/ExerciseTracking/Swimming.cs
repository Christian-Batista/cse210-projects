public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
         _laps = laps;
    }

    public override double GetDistance()
    {
        double distanceInKm = _laps * 50.0 / 1000; // each lap is 50 meters
        return Program.UseKilometers ? distanceInKm : distanceInKm * 0.62;
    }

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}