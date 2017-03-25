using System;
using System.Collections.Generic;
using Konteh.GitChallenge.Test.Models;

namespace Konteh.GitChallenge.Test.Services
{
	public class Service : IAmService
	{
		public IEnumerable<RealModel> GetAll()
		{
			yield return new RealModel() { Id = Guid.NewGuid(), Name = "first"};
			yield return new RealModel() { Id = Guid.NewGuid(), Name = "second"};
			yield return new RealModel() { Id = Guid.NewGuid(), Name = "third"};
		}

		public IEnumerable<RealModel> GetOddOnes()
		{
			yield return new RealModel() { Id = Guid.NewGuid(), Name = "first" };
			yield return new RealModel() { Id = Guid.NewGuid(), Name = "third" };
		}
	}
}