using System;
using System.Collections.Generic;

//By Group 6
//Created by Erik Kartzmark, Kent Moseley, Frank Vasquez, Austin Higgins

namespace Task_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] longestArray = {8, 13, 8};
            Header header = new Header();

            List<Task> taskList = new List<Task>();

            while (true)
            {
                int userinput=0;

                try
                {
                    Console.WriteLine("\nWould you like to (1)View Tasks, (2)View Completed Tasks, (3)Create New Task");
                    userinput = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please input a valid menu number");
                    continue;
                }
                
                switch (userinput)
                {
                        //View Tasks
                    case 1:
                        {   
                            //Determine the longest words in the task list
                            for (int i = 0; i < taskList.Count; i++)
                            {
                                if (!taskList[i].Complete)
                                {
                                    int[] t = taskList[i].GetLongest();
                                    for (int j = 0; j < 3; j++)
                                    {
                                        if (longestArray[j] < t[j])
                                            longestArray[j] = t[j];
                                    }
                                }
                            }

                            //Print header
                            header.GetHeader(longestArray);

                            //Search taskList for non-completed tasks and print them
                            for (int i = 0; i < taskList.Count; i++)
                            {
                                if (!taskList[i].Complete) taskList[i].ViewTask(longestArray);
                            }

                            while(true)
                            {
                                Console.WriteLine("\n Please enter the name of the Task you want to edit. (0) To go back.");
                                string userinput2="";
                                try
                                {
                                     userinput2= Console.ReadLine();
                                }

                                catch
                                {
                                    Console.WriteLine("Please input a proper task name");
                                    continue;
                                }

                                if (userinput2 == "0")
                                    break;

                                //Search taskList for a task with a taskname matching userinput, then execute editTask
                                for (int i = 0; i < taskList.Count; i++)
                                {
                                    if (taskList[i].taskName.ToLower() == userinput2.ToLower())
                                    {
                                        taskList[i].EditTask();
                                        break;
                                    }
                                }
                               
                            }
                            break;
                        }
                        //View Completed Tasks
                    case 2:
                        {
                            //Determine the longest words in the task list
                            for (int i = 0; i < taskList.Count; i++)
                            {
                                if (taskList[i].Complete)
                                {
                                    int[] t = taskList[i].GetLongest();
                                    for (int j = 0; j < 3; j++)
                                    {
                                        if (longestArray[j] < t[j])
                                            longestArray[j] = t[j];
                                    }
                                }
                            }

                            //Print Header
                            header.GetCompletedHeader(longestArray);

                            //Search taskList for completed tasks and print them
                            for (int i = 0; i < taskList.Count; i++)
                            {
                                if (taskList[i].Complete) taskList[i].ViewTask(longestArray);
                            }

                         
                          
                            while (true)
                            {
                                Console.WriteLine("\n Please enter the name of the Task you want to edit. (0) To go back.");
                                string userinput2 = "";
                                try
                                {
                                    userinput2 = Console.ReadLine();
                                }

                                catch
                                {
                                    Console.WriteLine("Please input a proper task name");
                                    continue;
                                }
                                if (userinput2 == "0")
                                    break;

                                //Search taskList for a task with a taskname matching userinput, then execute editTask
                                for (int i = 0; i < taskList.Count; i++)
                                {
                                    if (taskList[i].taskName.ToLower() == userinput2.ToLower())
                                    {
                                        taskList[i].EditTask();
                                        break;
                                    }
                                    
                                }
                               
                            }
                            break;
                        }
                        //Add New Task
                    case 3:
                        {
                            taskList.Add(new Task());
                            taskList[taskList.Count-1].GenTask();
                            break;
                        }


                    default:
                        Console.WriteLine("Please input a valid menu number");
                        break;
                }
            }



        }

    }
}
