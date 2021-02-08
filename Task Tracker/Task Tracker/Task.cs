using System;

public class Task
{
	string date; string dateCompleted;
	string description; string location;


	public string taskName { get; set; }
	public bool Complete { get; set; }


	public void ViewTask(int[] longestArray)
	{
		Console.Write(taskName);
		this.PrintSpacing(this.taskName.Length, longestArray[0]);

		if (!this.Complete) 
		{
			

			Console.Write(date);
			this.PrintSpacing(this.date.Length, longestArray[1]);
		}
		else
        {
			Console.Write(dateCompleted);
			this.PrintSpacing(this.dateCompleted.Length, longestArray[1]);
		}


		Console.Write(location);
		this.PrintSpacing(this.location.Length, longestArray[2]);

		Console.Write(description);
		Console.WriteLine();

	}

	public void GenTask()
	{
		Console.WriteLine("Please enter the name of your task: ");
		while (true)
		{
			try
			{
				taskName = Console.ReadLine();
			}

			catch
			{
				Console.WriteLine("Please enter a proper name:");
				continue;
			}            
				break;
            
		}
		Console.WriteLine("Please enter the complete by date: (MM/DD/YYYY)");

		while (true)
		{
			try
			{
				date = Console.ReadLine();
			}
			catch
			{
				Console.WriteLine("Please enter a proper date format:");
				continue;
			}
			break;
		}

		Console.WriteLine("Please enter a location for the task: ");
		while (true)
		{
			try
			{
				location = Console.ReadLine();
			}
			catch
			{
				Console.WriteLine("Please enter a proper location name:");
				continue;
			}
			break;
		}
		Console.WriteLine("Please enter a description of the task: ");
		while (true)
		{
			try
			{
				description = Console.ReadLine();
			}
			catch
			{
				Console.WriteLine("Please enter a proper description:");
				continue;
			}
			break;
		}

		Complete = false;
	}

	public void EditTask()
	{
		string userinput3 = "";
		do
		{
			if (!this.Complete) Console.WriteLine("Do you want to edit (1)TaskName, (2)Date, (3)Location, (4)Description, (5)Complete the task, or (0)Back");
			else Console.WriteLine("Do you want to edit (1)TaskName, (2)Date, (3)Location, (4)Description, (0)Back");

			try
			{
				switch (Convert.ToInt32(Console.ReadLine()))
				{
					case 1:
						Console.WriteLine("Please enter the new name of your task: ");
						try
						{
							taskName = Console.ReadLine();
						}
                        catch
                        {
							Console.WriteLine("Please enter a valid name:");
							continue;
                        }
						break;
					case 2:
						Console.WriteLine("Please enter the new complete by date: (MM/DD/YYYY)");
						
						try
						{
							date = Console.ReadLine();
						}
						catch
						{
							Console.WriteLine("Please enter a valid date format:");
							continue;
						}
						break;
					case 3:
						Console.WriteLine("Please enter a new location for the task: ");
						
						try
						{
							location = Console.ReadLine();
						}
						catch
						{
							Console.WriteLine("Please enter a valid location:");
							continue;
						}
						break;
					case 4:
						Console.WriteLine("Please enter a new description of the task: ");
						
						try
						{
							description = Console.ReadLine();
						}
						catch
						{
							Console.WriteLine("Please enter a valid description:");
							continue;
						}
						break;

					case 5:
						Complete = true;
						DateTime dateNow = new DateTime();
						dateNow = DateTime.Now;
						dateCompleted = dateNow.ToString("MM/dd/yyyy"); ;
						break;

					default:
						break;
				}

				Console.WriteLine("Would you like to edit something else? (Yes/No)");
			}
			catch
            {
				Console.WriteLine("Please enter a proper menu option");
				continue;
            }
			try
            {
				userinput3 = (Console.ReadLine());
            }
			catch
            {
				Console.WriteLine("Please enter Yes/No");
				continue;
            }
		}
		while (userinput3.ToLower() == "yes" || userinput3.ToLower() == "y");

	}
	public void PrintSpacing(int current, int longest)
	{
		for (int i = current; i < longest + 3; i++)
			Console.Write(" ");
	}

	public int[] GetLongest()
	{
		int[] i = { taskName.Length, date.Length, location.Length };
		if (this.Complete)
			i[1] = dateCompleted.Length;
		return i;
	}
}
