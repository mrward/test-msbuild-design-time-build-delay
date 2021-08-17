using Microsoft.Build.Utilities;
using System.Threading;

namespace MSBuildDelayDesignTimeBuildTask
{
	public class DelayDesignTimeBuild : Task
	{
		public int Delay { get; set; } = 30000;

		public override bool Execute ()
		{
			Log.LogMessage ("Sleeping for {0} ms", Delay);

			Thread.Sleep (Delay);

			Log.LogMessage ("Finished sleep");

			return true;
		}
	}
}

