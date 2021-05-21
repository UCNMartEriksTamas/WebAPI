using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using UCNSem1Project;
using UCNSem1Project.Controllers;
using UCNSem1Project.Models;

namespace Unit_Tests
{
    [TestFixture]
    public class LoanCheck
    {
        private LoanController _loanController;
        private LibraryContext _context;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<LibraryContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            _context = new LibraryContext(options);
            _loanController = new LoanController(new LibraryContext(options));
            var loans = new List<Loan>
            {
                new Loan {Id = 1, Volume_Id = 1, Member_SSN = "123", Checkout_Date = DateTime.Now, Expiry_Date = DateTime.Now, Is_Returned = false},
                new Loan {Id = 2, Volume_Id = 3, Member_SSN = "456", Checkout_Date = DateTime.Now, Expiry_Date = DateTime.Now, Is_Returned = true}
            };
            _context.AddRange(loans);
            _context.SaveChanges();
        }

        [Test]
        public void TestGetAmountOfLoans()
        {
            var result = _loanController.GetAmountOfLoans();
            Assert.AreEqual(result, 2);
        }
    }
}
