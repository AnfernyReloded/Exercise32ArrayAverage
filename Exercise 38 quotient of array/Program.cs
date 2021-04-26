using System;

namespace Exercise_38_quotient_of_array
{
    class Program
    {
        
        
            static void Main(string[] args)
            {
                while (true)
                {
                    string user_choice;

                    double[] user_arr = new double[5];
                    double sum = 0;
                    double answer;

                    for (int i = 0; i < user_arr.Length; i++)
                    {
                        Console.Write("Enter a number: <<");
                        user_arr[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    for (int i = 0; i < user_arr.Length; i++)
                    {
                        sum += user_arr[i];
                    }

                    answer = sum / 5; //I know that there's a way to divide by the indexes of the array

                    Console.WriteLine("( " + user_arr[0] + " + " + user_arr[1] + " + " + user_arr[2] + " + " + user_arr[3] + " + " + user_arr[4] + " ) " + "/5 = " + answer);

                    Console.WriteLine("Would you like to continue? y/n");
                    user_choice = Console.ReadLine().ToLower();

                    if (user_choice != "y")
                    {
                        Console.WriteLine("Goodbye!!");
                        break;
                    }
                }
            }
        }
    }
    


                


            
        
    

