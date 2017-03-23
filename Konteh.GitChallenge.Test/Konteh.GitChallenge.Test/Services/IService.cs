using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Konteh.GitChallenge.Test.Models;

namespace Konteh.GitChallenge.Test.Services
{
	public interface IService
	{
		IEnumerable<RealModel> GetAll();

		IEnumerable<RealModel> GetSome();
	}
}