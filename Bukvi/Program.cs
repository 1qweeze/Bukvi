using System;

class ArrayExample
{
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];

        // Iterate through the letters array
        for (int i = 0; i < letters.Length; i++)
        {
            // Append the current letter to the name string
            name += letters[i];

            // Assign a value to the corresponding element in the 'a' array
            a[i] = i + 1;

            // Call the SendMessage function with the current name and message
            SendMessage(name, a[i]);
        }

        // Keep the console window open until a key is pressed
        Console.ReadKey();
    }

    // Function to print a greeting message to the console
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}
