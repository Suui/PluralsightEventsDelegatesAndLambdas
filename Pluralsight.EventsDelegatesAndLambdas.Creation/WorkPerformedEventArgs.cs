using System;


namespace Pluralsight.EventsDelegatesAndLambdas.Creation
{
	public class WorkPerformedEventArgs : EventArgs
	{
		public int WorkHours { get; set; }
		public WorkType WorkType { get; set; }

		public WorkPerformedEventArgs(int workHours, WorkType workType)
		{
			WorkHours = workHours;
			WorkType = workType;
		}
	}
}