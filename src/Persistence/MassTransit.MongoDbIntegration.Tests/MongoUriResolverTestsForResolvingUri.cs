﻿// Copyright 2007-2016 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.MongoDbIntegration.Tests
{
    using System;
    using MessageData;
    using MongoDB.Bson;
    using NUnit.Framework;

    //AMBAR Git TEST 10/30/2019
    [TestFixture]
    public class MongoUriResolverTestsForResolvingUri
    {
        [Test]
        public void ThenExpectedObjectIdReturnedFromUri()
        {
            Assert.That(_result, Is.EqualTo(_expected));
        }

        [SetUp]
        public void GivenAMongoMessageUriResolver_WhenResolvingObjectIdFromUri()
        {
            _expected = ObjectId.GenerateNewId();
            var uri = new Uri(string.Format($"urn:mongodb:gridfs:{_expected}"));
            var sut = new MessageDataResolver();

            _result = sut.GetObjectId(uri);
        }

        ObjectId _expected;
        ObjectId _result;
    }
}
