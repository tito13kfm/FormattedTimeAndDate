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
    Console.Clear();
    Console.WriteLine(getFormattedTimeDate());
}
