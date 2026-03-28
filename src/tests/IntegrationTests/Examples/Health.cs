/*
order: 10
title: Health Check
slug: health-check

Shows how to check the health status of the Letta API.
*/

namespace Letta.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CheckHealth()
    {
        using var client = GetAuthenticatedClient();

        //// The health check endpoint verifies that the Letta API is operational.
        //// It returns the server version and current status.
        var health = await client.Health.CheckHealthAsync();

        health.Should().NotBeNull();
        health.Status.Should().NotBeNullOrEmpty();
        health.Version.Should().NotBeNullOrEmpty();
    }
}
