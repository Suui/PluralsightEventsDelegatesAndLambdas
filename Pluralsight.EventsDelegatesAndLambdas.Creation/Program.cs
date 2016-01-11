﻿using System;


namespace Pluralsight.EventsDelegatesAndLambdas.Creation
{
	public enum WorkType
	{
		GoToMeetings,
		Golf,
		GenerateReports
	}

	class Program
	{
		private static void Main(string[] args)
		{
			var workDelegateOne = new WorkPerformedHandler(WorkPerformedOne);
			var workDelegateTwo = new WorkPerformedHandler(WorkPerformedTwo);
			var workDelegateThree = new WorkPerformedHandler(WorkPerformedThree);

			DoWork(workDelegateOne);

			// Multicast Delegate behind the scenes
			workDelegateOne += workDelegateTwo + workDelegateThree;

			// It's the last invoked delegate that returns its value
			Console.WriteLine();
			var totalWorkHours = workDelegateOne(10, WorkType.GenerateReports);
			Console.WriteLine("Total work hours: " + totalWorkHours);

			Console.WriteLine();
			DoWork(workDelegateOne);
		}

		private static void DoWork(WorkPerformedHandler workDelegate)
		{
			workDelegate(5, WorkType.Golf);
		}

		private static int WorkPerformedOne(int workHours, WorkType workType)
		{
			Console.WriteLine("WorkPerformedOne called: " + workHours + " hours");
			return workHours;
		}

		private static int WorkPerformedTwo(int workHours, WorkType workType)
		{
			Console.WriteLine("WorkPerformedTwo called: " + workHours + " hours");
			return workHours;
		}

		private static int WorkPerformedThree(int workHours, WorkType workType)
		{
			Console.WriteLine("WorkPerformedThree called: " + workHours + " hours");
			return workHours;
		}
	}
}
