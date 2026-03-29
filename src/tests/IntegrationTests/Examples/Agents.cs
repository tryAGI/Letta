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
        var client = Client;

        //// List all agents in your Letta workspace.
        //// Supports pagination, filtering by name/tags, and sorting.
        var agents = await client.Agents.ListAgentsAsync(
            limit: 10);

        agents.Should().NotBeNull();
    }

    [TestMethod]
    public async Task CountAgents()
    {
        var client = Client;

        //// Get the total number of agents in your workspace.
        //// Useful for pagination or dashboard summaries.
        var count = await client.Agents.CountAgentsAsync();

        count.Should().BeGreaterThanOrEqualTo(0);
    }
}
