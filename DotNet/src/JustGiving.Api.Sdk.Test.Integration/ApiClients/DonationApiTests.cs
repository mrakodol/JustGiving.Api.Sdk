﻿using JustGiving.Api.Sdk.ApiClients;
using NUnit.Framework;

namespace JustGiving.Api.Sdk.Test.Integration.ApiClients
{
    [TestFixture]
    public class DonationApiTests
    {
        [Test]
        public void GetDonationStatus_WhenSuppliedWithKnownExistingDonationId_ReturnsDonationStatus()
        {
            var client = new JustGivingClient(new ClientConfiguration(TestContext.ApiLocation, TestContext.ApiKey, 1) { Username = TestContext.TestUsername, Password = TestContext.TestInvalidPassword });
            var donationClient = new DonationApi(client);

            var status = donationClient.RetrieveStatus(21305000);
        }
    }
}