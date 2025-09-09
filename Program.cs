namespace Akutmottagningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Goals of program:           
                     When all answers are collected, decide if red, yellow or green
                     Red IF: diff breathing OR chest pain | major bleeding | temp above 40c AND age <1 or >75
                     Yellow IF: not red, but: temp >=38.5 | pain >= 7
                     Green IF: not red or yellow

                    Print out to the console:
                    - Name of patient
                    - Choosen priority
                    - Short motivation, i.e. YELLOW: fever 38.7 and pain level 7
            */

            // Greets user, asks for compliance for the following data inputs
            Console.WriteLine("\n\t\tHello user! Welcome to Ambulaid.");
            Console.WriteLine("\t\tPlease enter the following. . .");
            

            // Asks for patient name, age, temperature, saves user input in variables. Age and temperature in double if user enter with decimal.
            Console.Write("\n\t\tName of patient: ");
            string patientName = Console.ReadLine();

            Console.Write("\t\tAge of patient (enter in numerals, i.e. 12): ");
            double patientAge = double.Parse(Console.ReadLine());

            Console.Write("\t\tCurrent temperature of patient (enter in celcius): ");
            double patientTemp = double.Parse(Console.ReadLine());
            Console.Clear();


            // Ask for current symptoms. Save answers in strings.
            Console.Write("\n\t\tIs the patient currently suffering from chest pains? [y/n]: ");
            string chestPain = Console.ReadLine();
            Console.Clear();

            Console.Write("\n\t\tIs the patient currently suffering from a major bleeding? [y/n]: ");
            string majorBleeding = Console.ReadLine();
            Console.Clear();

            Console.Write("\n\t\tIs the patient currently having trouble breathing? [y/n]: ");
            string breathingDiff = Console.ReadLine();
            Console.Clear();

            Console.Write("\n\t\tWhat is the current pain level of the patient? Ask them rate 1-10: ");
            int painLevel = int.Parse(Console.ReadLine());
            Console.Clear();

            // Declare string variable for later color storing, and another for alarm message.
            string alarmColor = "";
            string alarmMessage = "";


            if ((chestPain == "y" || breathingDiff == "y") || majorBleeding == "y" || patientTemp > 40 && (patientAge < 1 || patientAge > 75))
            {
                alarmColor = "RED";
            }
            else if (patientTemp >= 38.5 || painLevel >= 7) 
            {
                alarmColor = "YELLOW";
            }
            else
            {
                alarmColor = "GREEN";
            }

            if (chestPain == "y") alarmMessage += "chestpains. ";
            if (breathingDiff == "y") alarmMessage += "Difficulty breathing. ";
            if (majorBleeding == "y") alarmMessage += "A major bleeding. ";
            if (patientTemp > 40 && (patientAge < 1 || patientAge > 75)) alarmMessage += $"Patient current temperature: {patientTemp}, age {patientAge}";
            if (patientTemp >= 38.5 || painLevel >= 7) alarmMessage += $"Patient current temperature: {patientTemp}. Current pain: {painLevel}.";
            if (alarmMessage == "") alarmMessage = "No major symptoms.";


            Console.WriteLine($"\n\t\tPatient name: {patientName}");
            Console.WriteLine($"\t\tPriority: {alarmColor}");
            Console.WriteLine($"\t\tMotivation: {alarmMessage}");

        }
    }
}
