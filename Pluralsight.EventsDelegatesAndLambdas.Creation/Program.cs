using System;


namespace Pluralsight.EventsDelegatesAndLambdas.Creation
{
	public delegate void WorkPerformedHandler(int workHours, WorkType workType);

	public enum WorkType
	{
		GoToMeetings,
		Golf,
		GenerateReports
	}

	class Program
	{
		static void Main(string[] args)
		{
			var workDelegateOne = new WorkPerformedHandler(WorkPerformedOne);
			var workDelegateTwo = new WorkPerformedHandler(WorkPerformedTwo);
			var workDelegateThree = new WorkPerformedHandler(WorkPerformedThree);

			DoWork(workDelegateOne);

			// Multicast Delegate behind the scenes
			workDelegateOne += workDelegateTwo + workDelegateThree;

			Console.WriteLine();
			workDelegateOne(10, WorkType.GenerateReports);

			Console.WriteLine();
			DoWork(workDelegateOne);
		}

		static void DoWork(WorkPerformedHandler workDelegate)
		{
			workDelegate(5, WorkType.Golf);
		}

		static void WorkPerformedOne(int workHours, WorkType workType)
		{
			Console.WriteLine("WorkPerformedOne called: " + workHours + " hours");
		}

		static void WorkPerformedTwo(int workHours, WorkType workType)
		{
			Console.WriteLine("WorkPerformedTwo called: " + workHours + " hours");
		}

		private static void WorkPerformedThree(int workHours, WorkType workType)
		{
			Console.WriteLine("WorkPerformedThree called: " + workHours + " hours");
		}
	}
}
