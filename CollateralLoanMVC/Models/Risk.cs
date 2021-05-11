using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollateralLoanMVC.Models
{
	public class Risk
	{
		public int LoanValue { get; }
		public int CollateralValue { get; }
		public double RiskPercentage { get => ((double)LoanValue / CollateralValue) * 100; }
	}
}
