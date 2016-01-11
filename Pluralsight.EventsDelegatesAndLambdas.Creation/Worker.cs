using System;


namespace Pluralsight.EventsDelegatesAndLambdas.Creation
{
	public class Worker
	{
		public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
		public event EventHandler WorkCompleted;

		public void DoWork(int workHours, WorkType workType)
		{
			for (var hours = 1; hours <= workHours; hours++)
			{
				OnWorkPerformed(hours, workType);
			}
			OnWorkCompleted();
		}

		protected virtual void OnWorkPerformed(int workHours, WorkType workType)
		{
			// We are actually invoking the delegate
			WorkPerformed?.Invoke(this, new WorkPerformedEventArgs(workHours, workType));
		}

		protected virtual void OnWorkCompleted()
		{
			WorkCompleted?.Invoke(this, EventArgs.Empty);
		}
	}
}