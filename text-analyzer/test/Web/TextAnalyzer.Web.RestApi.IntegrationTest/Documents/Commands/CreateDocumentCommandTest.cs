using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using TextAnalyzer.Core.Application.Commands.Documents;
using TextAnalyzer.Core.Application.Queries.Documents;
using Xunit;

namespace TextAnalyzer.Web.RestApi.IntegrationTest.Documents.Commands
{
    public class CreateDocumentCommandTest : BaseTest
    {
        public CreateDocumentCommandTest(Fixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task ValidRequest_ReturnsResponse()
        {
            // Arrange

            var createRequest = new CreateDocumentCommand
            {
                Name = "My doc",
                Text = "This is some text",
            };

            // Act

            var createHttpResponse = await Fixture.Api.Documents.CreateDocumentAsync(createRequest);

            // Assert

            createHttpResponse.StatusCode.Should().Be(HttpStatusCode.Created);

            var createResponse = createHttpResponse.Data;

            createResponse.Id.Should().NotBeEmpty();
            createResponse.Should().BeEquivalentTo(createRequest);

            var id = createResponse.Id;
            var findRequest = new ViewDocumentQuery { Id = id };
            var findHttpResponse = await Fixture.Api.Documents.ViewDocumentAsync(findRequest);
            var findResponse = findHttpResponse.Data;
            findHttpResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            findResponse.Should().BeEquivalentTo(createResponse);
        }
    }
}
