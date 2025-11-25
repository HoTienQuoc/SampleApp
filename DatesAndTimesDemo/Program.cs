DateTime meetingAppt = new(2024, 4, 9);
Console.WriteLine(meetingAppt.ToString());

DateTime meetingAppt1 = new(2024, 4, 9, 14, 30, 0);
Console.WriteLine(meetingAppt1.ToString());

Console.WriteLine(DateTime.Today.ToString());
Console.WriteLine(DateTime.Now.ToString());

// Method: Description 
// Add: Adds / Subtracts the value of the specified TimeSpan object instance.
// AddDays: Adds/Subtracts the specified number of days.
// AddHours: Adds/Subtracts the specified number of hours.
// AddMilliseconds: Adds/Subtracts the specified number of Milliseconds.
// AddMinutes: Adds/Subtracts the specified number of minutes.
// AddMonths: Adds/Subtracts the specified number of months.
// AddSeconds: Adds/Subtracts the specified number of seconds.
// Add Years: Adds/Subtracts the specified number of years.

DateTime meetingAppt2 = new(2024, 4, 9, 14, 30, 0);
DateTime newAppt = meetingAppt2.AddDays(5);
Console.WriteLine(newAppt.ToString());

DateTime meetingAppt3 = new(2024, 4, 9, 14, 30, 0);
DateTime newAppt1 = meetingAppt3.AddMonths(-10);
Console.WriteLine(newAppt1.ToString());

// Retrieving parts of a date and time
DateTime meetingAppt4 = new(2024, 4, 9, 14, 30, 0);
Console.WriteLine(meetingAppt4.Day);
Console.WriteLine(meetingAppt4.Month);
Console.WriteLine(meetingAppt4.Year);
Console.WriteLine(meetingAppt4.Hour);
Console.WriteLine(meetingAppt4.Minute);
Console.WriteLine(meetingAppt4.Second);
Console.WriteLine(meetingAppt4.Millisecond);

