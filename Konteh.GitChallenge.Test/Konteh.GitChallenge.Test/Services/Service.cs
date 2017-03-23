using System;
using System.Collections.Generic;
using Konteh.GitChallenge.Test.Models;

namespace Konteh.GitChallenge.Test.Services
{
	public class Service : IService
	{
		public IEnumerable<TestModel> GetAll()
		{
			yield return new TestModel() { Id = Guid.NewGuid(), Name = "first"};
			yield return new TestModel() { Id = Guid.NewGuid(), Name = "second"};
			yield return new TestModel() { Id = Guid.NewGuid(), Name = "third"};
		}

		public IEnumerable<TestModel> GetSome()
		{
			yield return new TestModel() { Id = Guid.NewGuid(), Name = "first" };
			yield return new TestModel() { Id = Guid.NewGuid(), Name = "third" };
		}
	}
}