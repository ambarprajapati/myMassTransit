﻿using System;
using Marten.Schema;
using MassTransit.Saga;

namespace MassTransit.MartenIntegration.Tests
{    //AMBAR Git TEST 10/30/2019
    public class TestSaga : ISaga
    {
        [Identity]
        public Guid CorrelationId { get; set; }
        public Guid Id => CorrelationId;
    }
}
