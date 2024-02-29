public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing","This activity will help you relax by walking your way through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
          
    }
    public void StartBreathing(){
        Console.Clear();
        Console.WriteLine("Get ready...");
        base.DisplaySpinner(3);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());
        
        while (startTime < futureTime){
            Console.Write("\n\nBreathe in...");
            base.DisplayCountdown(4);
            Console.Write("\nNow breathe out...");
            base.DisplayCountdown(6);
            startTime = DateTime.Now;
        }
        Console.WriteLine("\n\nWell Done!!!");
        base.DisplaySpinner(3);
        
    }
   
}