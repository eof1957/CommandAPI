using Xunit;
using CommandAPI.Models;
using System;

namespace CommandAPI.Tests
{
    public class CommandTests: IDisposable
    {
        Command testCommand;

        public void Dispose()
        {
            testCommand = null;
        }

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Given

            //When
            testCommand.HowTo = "Execute Unit Tests";
        
            //Then
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact] public void CanChangePlatform() 
        { 
            //Arrange 
            //Act 
            testCommand.Platform = "xUnit"; 
            //Assert 
            Assert.Equal("xUnit", testCommand.Platform); 
        } 
        [Fact] 
        public void CanChangeCommandLine() 
        { 
            //Arrange 
            //Act 
            testCommand.CommandLine = "dotnet test"; 
            //Assert 
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }
    }
}