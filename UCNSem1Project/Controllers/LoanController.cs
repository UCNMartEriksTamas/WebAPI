using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UCNSem1Project.DTOs;
using UCNSem1Project.Models;

namespace UCNSem1Project.Controllers
{
    [ApiController]
    [Route("api/loan")]
    public class LoanController : ControllerBase
    {
        private readonly LibraryContext _dbContext;

        public LoanController(LibraryContext context)
        {
            _dbContext = context;
        }


        [HttpGet("GetLoan/{id}")]
        public async Task<ActionResult<LoanDTO>> GetLoan(int id)
        {
            var loan = await _dbContext.Loans.FindAsync(id);
            if (loan == null)
            {
                return NotFound();
            }

            return LoanToDto(loan);
        }

        [HttpGet("GetAmountLoans")]
        public int GetAmountOfLoans()
        {
            var loans = _dbContext.Loans;
            return loans.Count();
        }

        private static LoanDTO LoanToDto(Loan loan) =>
            new LoanDTO()
            {
                Id = loan.Id,
                VolumeId = loan.Volume_Id,
                MemberSsn = loan.Member_SSN,
                CheckoutDate = loan.Checkout_Date,
                ExpiryDate = loan.Expiry_Date,
                IsReturned = loan.Is_Returned
            };
    }
}