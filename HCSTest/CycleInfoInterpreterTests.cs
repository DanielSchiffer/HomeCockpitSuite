using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using DanielSchiffer.HCS.Logic.WindowsIo;

namespace DanielSchiffer.HCS.Logic.NavdataUpdater.Tests
{
    [TestClass]
    public class CycleInfoInterpreterTests
    {
        private CycleInfoInterpreter cycleInfoInterpreter;
        private Mock<NavDataIo> navDataIoMock;

        [TestInitialize]
        public void TestInitialize()
        {
            navDataIoMock = new Mock<NavDataIo>();
            cycleInfoInterpreter = new CycleInfoInterpreter(navDataIoMock.Object);
        }

        [TestMethod]
        public void GetAirVersion_Should_Return_Version_When_Line_Contains_AIRAC_Cycle()
        {
            // Arrange
            var cycleText = new List<string> { "AIRAC cycle: 2101" };
            navDataIoMock.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetAirVersion();

            // Assert
            Assert.AreEqual("2101", result);
        }

        [TestMethod]
        public void GetAirVersion_Should_Return_Dash_When_Line_Does_Not_Contain_AIRAC_Cycle()
        {
            // Arrange
            var cycleText = new List<string> { "Some other line" };
            navDataIoMock.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetAirVersion();

            // Assert
            Assert.AreEqual("-", result);
        }

        [TestMethod]
        public void GetGueltigBis_Should_Return_Date_When_Line_Contains_Valid()
        {
            // Arrange
            var cycleText = new List<string> { "Valid: 01.01.2022 - 31.01.2022" };
            navDataIoMock.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetGueltigBis();

            // Assert
            Assert.AreEqual("31.01.2022", result);
        }

        [TestMethod]
        public void GetGueltigBis_Should_Return_Dash_When_Line_Does_Not_Contain_Valid()
        {
            // Arrange
            var cycleText = new List<string> { "Some other line" };
            navDataIoMock.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetGueltigBis();

            // Assert
            Assert.AreEqual("-", result);
        }

        [TestMethod]
        public void GetGueltigVon_Should_Return_Date_When_Line_Contains_Valid()
        {
            // Arrange
            var cycleText = new List<string> { "Valid: 01.01.2022 - 31.01.2022" };
            navDataIoMock.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetGueltigVon();

            // Assert
            Assert.AreEqual("01.01.2022", result);
        }

        [TestMethod]
        public void GetGueltigVon_Should_Return_Dash_When_Line_Does_Not_Contain_Valid()
        {
            // Arrange
            var cycleText = new List<string> { "Some other line" };
            navDataIoMock.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetGueltigVon();

            // Assert
            Assert.AreEqual("-", result);
        }
    }
}
