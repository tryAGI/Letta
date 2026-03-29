/*
order: 30
title: Models
slug: models

Shows how to list available LLM and embedding models in Letta.
*/

namespace Letta.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListModels()
    {
        var client = Client;

        //// List all available LLM models that can be used with Letta agents.
        //// Each model includes its name, provider type, and context window size.
        var models = await client.Models.ListModelsAsync();

        models.Should().NotBeNull();
        models.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task ListEmbeddingModels()
    {
        var client = Client;

        //// List all available embedding models for use with agent memory and RAG.
        //// Each embedding model includes its name, provider, and embedding dimensions.
        var embeddingModels = await client.Models.ListEmbeddingModelsAsync();

        embeddingModels.Should().NotBeNull();
        embeddingModels.Should().NotBeEmpty();
    }
}
