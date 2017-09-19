
namespace LEARNING_STATIC_CONSTRUCTOR
{
    public class Bus
    {
        // Static variable used by all Bus instances.
        // Represents the time the first bus of the day starts its route.
        protected static readonly System.DateTime globalStartTime;

        // Property for the number of each bus.
        protected int RouteNumber { get; set; }

        // Static constructor to initialize the static variable.
        // It is invoked before the first instance constructor is run.
        static Bus()
        {
            globalStartTime = System.DateTime.Now;

            // The following statement produces the first line of output, 
            // and the line occurs only once.
            System.Console.WriteLine("Static constructor sets global start time to {0}",
                globalStartTime.ToLongTimeString());
        }

        // Instance constructor.
        public Bus(int routeNum)
        {
            RouteNumber = routeNum;
            System.Console.WriteLine("Bus #{0} is created.", RouteNumber);
        }

        // Instance method.
        public void Drive()
        {
            System.TimeSpan elapsedTime = System.DateTime.Now - globalStartTime;

            // For demonstration purposes we treat milliseconds as minutes to simulate
            // actual bus times. Do not do this in your actual bus schedule program!
            System.Console.WriteLine("{0} is starting its route {1:N2} minutes after global start time {2}.",
                                    this.RouteNumber,
                                    elapsedTime.TotalMilliseconds,
                                    globalStartTime.ToShortTimeString());
        }
    }

}
