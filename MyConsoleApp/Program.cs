// See https://aka.ms/new-console-template for more information

string getFormattedTimeDate()
{
    string time = System.DateTime.Now.ToLongTimeString();
    string date = System.DateTime.Now.ToLongDateString();
    string dateTime = date + " " + time;
    string border = new('*', dateTime.Length + 4);
    string formattedTimeDate = border + "\n| " + dateTime + " | \n" + border;
    return formattedTimeDate;
}

var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(1));

while (await periodicTimer.WaitForNextTickAsync())
{
    string output = getFormattedTimeDate();
    int l = output.Length;
    int i = 0;
    Console.Clear();
    while (i <= output.Length - 1)
    {
        Console.Write("{0}", output[i]);
        i++;
        System.Threading.Thread.Sleep(50);
    }
}
