﻿namespace TransportathonHackathon.Application.Features.PaymentRequests.Commands.Pay
{
    public class PaidPaymentRequestResponse
    {
        public Guid TransportRequestId { get; set; }
        public bool IsPaid { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
