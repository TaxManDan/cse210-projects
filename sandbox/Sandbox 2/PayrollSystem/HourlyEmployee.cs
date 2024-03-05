public class HourlyEmployee : Employee
{
    private float _hourlyRate;
    private float _hoursWorked;


    public HourlyEmployee(float hourlyRate, float hoursWorked){
        _hourlyRate = hourlyRate;
        _hoursWorked = hoursWorked;
    }
    public override float CalculatePay()
   {
     return _hourlyRate * _hoursWorked;
    }
}