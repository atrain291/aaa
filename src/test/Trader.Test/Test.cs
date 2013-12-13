using System;
using NUnit.Framework;


namespace Trader.Test
{
	[TestFixture]
	public class Test
	{
		Trader.Core.Engine _engine;

		[SetUp]
		public void Setup()
		{
			_engine = new Trader.Core.Engine (3);
		}

		[Test]

		public bool EngineCountEqualsThree()
		{
			return Test.Equals (_engine.Count, 3);
		}
	}
}

