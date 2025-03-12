using EcoEnergySegonaFaseDef.Classes;
namespace Tests
{
    public class CalcEnergiaTests
    {
        [Fact]
        public void CalcEnergiaSolarValueNega()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(-1, 1, "Solar");
            double value = -1;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }

        [Fact]
        public void CalcEnergiaSolarRatiNega()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(1, -1, "Solar");
            double value = -1;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }

        [Fact]
        public void CalcEnergiaSolarValueDecimal()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(2.2, 1, "Solar");
            double value = 2.2;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }

        [Fact]
        public void CalcEnergiaEolicaValueNega()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(-1, 1, "Eolica");
            double value = -1;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }

        [Fact]
        public void CalcEnergiaEolicaRatiNega()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(1, -1, "Eolica");
            double value = -1;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }

        [Fact]
        public void CalcEnergiaEolicaValueDecimal()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(2.2, 1, "Eolica");
            double value = 10.648000000000003;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }

        [Fact]
        public void CalcEnergiaHidroelectricaValueNega()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(-1, 1, "Hidroelectrica");
            double value = -9.8;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }

        [Fact]
        public void CalcEnergiaHidroelectricaRatiNega()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(1, -1, "Hidroelectrica");
            double value = -9.8;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }

        [Fact]
        public void CalcEnergiaHidroelectricaValueDecimal()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(2.2, 1, "Hidroelectrica");
            double value = 21.560000000000002;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }

        [Fact]
        public void CalcEnergiaOthers()
        {
            //Arrange
            //Act
            Simulation result = new Simulation(1, 1, "other");
            double value = 1;
            //Assert
            Assert.Equal(value, result.CalcEnergia());
        }
    }
}
