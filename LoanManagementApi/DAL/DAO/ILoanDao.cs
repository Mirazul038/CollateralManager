using LoanManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementApi.DAL.DAO
{
	public interface ILoanDao
	{
		List<Loan> GetAll(Page page, LoanFilter filter, LoanDb db);
		Loan GetById(int id, LoanDb db);
		int Save(Loan loan, LoanDb db);
		int UpdateFull(int id, Loan loan, LoanDb db);
		int UpdatePartial(int id, dynamic loan, LoanDb db);
		int Delete(int id, LoanDb db);
	}
}
