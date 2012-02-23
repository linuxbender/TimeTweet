using FluentAssertions;
using NUnit.Framework;
using Moq;

namespace Ch.TimeTweet.Domain.Test
{    
    public class UnitOfWorkTest
    {
        public UnitOfWorkTest()
        {

        }
        
        [Test]
        public void CheckFlowInThisTest()
        {
            // Arrange            
            const string foo = "This is a String";
            // Act

            //Assert
            foo.Should().NotBeEmpty().And.StartWith("T");
        }
        [Test]
        public void CheckFlowInThisTestCase()
        {
            
        }
    }
}