using System;

namespace Framework.FP.Core
{
	namespace Using
	{
		public static class FP
		{
			public static Ret Using<TDisp, Ret>(TDisp disposable,
				Func<TDisp, Ret> disposableConsumer) where TDisp : IDisposable
			{ 
				using(disposable) 
					return disposableConsumer(disposable); 
			}
		}
	}
}
