using System;


namespace Pluralsight.EventsDelegatesAndLambdas.Creation
{
	public delegate int WorkPerformedHandler(int workHours, WorkType workType);

	public class Worker
	{
		public event WorkPerformedHandler WorkPerformed;
		public event EventHandler WorkCompleted;

		public void DoWork(int workHours, WorkType workType)
		{
			
		}
	}
}