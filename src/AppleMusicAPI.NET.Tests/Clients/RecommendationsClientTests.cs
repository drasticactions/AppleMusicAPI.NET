﻿using System;
using System.Collections.Generic;
using System.Text;
using AppleMusicAPI.NET.Clients;
using AppleMusicAPI.NET.Tests.Clients.Fixtures;
using Xunit;

namespace AppleMusicAPI.NET.Tests.Clients
{
    public class RecommendationsClientTests : IClassFixture<RecommendationsClientFixture>
    {
        protected RecommendationsClientFixture Fixture { get; }

        public RecommendationsClientTests(RecommendationsClientFixture fixture)
        {
            Fixture = fixture;
        }
    }
}
