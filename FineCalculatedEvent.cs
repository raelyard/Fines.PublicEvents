using System;

namespace MediaLoanLibrary.Fines.PublicEvents
{
    public interface FineCalculatedEvent
    {
        Guid LoanId { get; set; }
        decimal FineAmount { get; set; }
    }
}

