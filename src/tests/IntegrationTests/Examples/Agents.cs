/*
order: 20
title: Agents
slug: agents

Shows how to list agents and count them using the Letta API.
*/

namespace Letta.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListAgents()
    {
        using var client = GetAuthenticatedClient();

        //// List all agents in your Letta workspace.
        //// Supports pagination, filtering by name/tags, and sorting.
        var agents = await client.Agents.ListAgentsAsync(
            limit: 10);

        agents.Should().NotBeNull();
    }

    [TestMethod]
    public async Task CountAgents()
    {
        using var client = GetAuthenticatedClient();

        //// Get the total number of agents in your workspace.
        //// Useful for pagination or dashboard summaries.
        var count = await client.Agents.CountAgentsAsync();

        count.Should().BeGreaterThanOrEqualTo(0);
    }
}
