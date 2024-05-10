using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using DanielSchiffer.HCS.Contracts.IOSIO;
using DanielSchiffer.HCS.Logic.NavdataUpdater;

namespace DanielSchiffer.HCS.Logic.Tests.NavdataUpdater
{
    [TestClass]
    public class CycleInfoInterpreterTests
    {
        private Mock<INavDataIo> mockNavDataIo;
        private CycleInfoInterpreter cycleInfoInterpreter;

        [TestInitialize]
        public void TestInitialize()
        {
            mockNavDataIo = new Mock<INavDataIo>();
            cycleInfoInterpreter = new CycleInfoInterpreter(mockNavDataIo.Object);
            // Pfad zur Datei 'cycle_info.txt' definieren.
            var importFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "HCS", "FsBuildImport");
            var filePath = Path.Combine(importFolder, "cycle_info.txt");

            var cycleText = new List<string> { "AIRAC cycle: 2101" };

            // Das Verhalten von GetFsBuildImportFolder mocken, um den definierten Importordner zurückzugeben.
            mockNavDataIo.Setup(x => x.GetFsBuildImportFolder()).Returns(importFolder);

            // Dateiexistenz und Leseverhalten mocken
            mockNavDataIo.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);
        }

        [TestMethod]
        public void GetAirVersion_ShouldReturnVersion_WhenLineContainsAiracCycle()
        {
            // Arrange
            var cycleText = new List<string> { "AIRAC cycle: 2101" };
            mockNavDataIo.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetAirVersion();

            // Assert
            Assert.AreEqual("2101", result);
        }

        [TestMethod]
        public void GetAirVersion_ShouldReturnDash_WhenLineDoesNotContainAiracCycle()
        {
            // Arrange
            var cycleText = new List<string> { "Some other line" };
            mockNavDataIo.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetAirVersion();

            // Assert
            Assert.AreEqual("-", result);
        }

        [TestMethod]
        public void GetGueltigBis_ShouldReturnDate_WhenLineContainsValid()
        {
            // Arrange
            var cycleText = new List<string> { "Valid : 01.01.2022 - 31.01.2022" };
            mockNavDataIo.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetGueltigBis();

            // Assert
            Assert.AreEqual("31.01.2022", result);
        }

        [TestMethod]
        public void GetGueltigBis_ShouldReturnDash_WhenLineDoesNotContainValid()
        {
            // Arrange
            var cycleText = new List<string> { "Some other line" };
            mockNavDataIo.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetGueltigBis();

            // Assert
            Assert.AreEqual("-", result);
        }

        [TestMethod]
        public void GetGueltigVon_ShouldReturnDate_WhenLineContainsValid()
        {
            // Arrange
            var cycleText = new List<string> { "Valid : 01.01.2022 - 31.01.2022" };
            mockNavDataIo.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetGueltigVon();

            // Assert
            Assert.AreEqual("01.01.2022", result);
        }

        [TestMethod]
        public void GetGueltigVon_ShouldReturnDash_WhenLineDoesNotContainValid()
        {
            // Arrange
            var cycleText = new List<string> { "Some other line" };
            mockNavDataIo.Setup(x => x.GetTextFromCycleInfo()).Returns(cycleText);

            // Act
            var result = cycleInfoInterpreter.GetGueltigVon();

            // Assert
            Assert.AreEqual("-", result);
        }
    }
}
