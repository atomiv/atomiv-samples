using FluentAssertions;
using Optivem.Atomiv.Core.Common.Http;
using Optivem.Atomiv.Test.Xunit;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using TextAnalyzer.Web.RestClient.Interface;

namespace TextAnalyzer.Web.RestApi.IntegrationTest
{
    public class BaseTest : FixtureTest<Fixture>, IDisposable
    {
        public BaseTest(Fixture fixture)
            : base(fixture)
        {
        }

        public void Dispose()
        {
            using (var context = Fixture.Db.CreateContext())
            {
                context.SaveChanges();
            }
        }

        protected Task<HeaderData> GetDefaultHeaderDataAsync()
        {
            var result = new HeaderData
            {
                Token = "bde2080b-c50a-4ed6-a9b0-9a33ccdb1ab7",
                Language = "en",
            };

            return Task.FromResult(result);
        }
    }
}