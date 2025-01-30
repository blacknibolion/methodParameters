// //Declaring schedule
// int[] schedule = {800, 1200, 1600, 2000};
// DisplayTime(schedule, 6, -6);

// void DisplayTime(int [] time, int currentTime, int newTime)
// {
//     int diff = 0;
//     if(Math.Abs(newTime) > 12 || Math.Abs(currentTime)>12)
//     {
//         Console.WriteLine("Invalid Time");
//     }
//     else if(newTime <= 0 && currentTime <= 0 || newTime >= 0 && currentTime >= 0)
//     {
//         diff = 100 * (Math.Abs(newTime) - Math.Abs(currentTime));
//     }
//     else
//     {
//         diff = 100* (Math.Abs(newTime) + Math.Abs(currentTime));
//     }
//     for (int i = 0; i < time.Length; i++) 
// {
//     int NewTime = (time[i] + diff) % 2400;
//     Console.WriteLine($"{time[i]} -> {NewTime}");
// }
// }

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};
// //calling methods
// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert","Vanya"});

// void DisplayStudents(string[] students) 
// {
//     foreach (string student in students) 
//     {
//         Console.Write($"{student}, ");
//     }
//     Console.WriteLine();
// }
// PrintCircleArea(12);

// void PrintCircleArea(int radius)
// {
//     double pi = 3.14159;
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// int a = 3;
// int b = 4;
// int c = 0;
// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} x {c}");

// void Multiply(int a, int b, int c)
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} x {c}");
// }

// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }
string status = "Healthy";

Console.WriteLine($"He's looking: {status}");
StatusHealth(false);
Console.WriteLine($"He's kinda looking {status}?...:P");
void StatusHealth(bool isHealthy)
{

    status = (isHealthy ? "Healthy" : "UnHealthy");
    Console.WriteLine($"He's looking: {status}");
}
