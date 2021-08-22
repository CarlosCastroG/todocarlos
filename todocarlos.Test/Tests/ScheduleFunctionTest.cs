using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using todocarlos.Functions.Functions;
using todocarlos.Test.Helpers;
using Xunit;

namespace todocarlos.Test.Tests
{
    public class ScheduleFunctionTest
    {
        [Fact]
        public void ScheduleFunction_Should_Log_Message()
        {
            // Arrenge
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreaccount1/reports"));
            ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);

            // Act
            ScheduleFunction.Run(null, mockTodos, logger);
            string message = logger.Logs[0];

            // Assert
            Assert.Contains("Deleting completed", message);
        }
    }
}
