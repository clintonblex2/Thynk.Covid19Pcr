using Bogus;
using Thynk.Covid19Pcr.Application.Models.Request;

namespace Thynk.Covid19Pcr.Test.Mock.PatientMock.Request
{
    public static class MockCancelBookedRequest
    {
        public static CancelBookingRequest MockValidCancelRequest()
        {
            var faker = new Faker<CancelBookingRequest>()
                     .RuleFor(o => o.BookingReference, "ABCDE12345")
                     .RuleFor(o => o.PhoneNumber, "09079910094");

            return faker.Generate();
        }

    }
}
