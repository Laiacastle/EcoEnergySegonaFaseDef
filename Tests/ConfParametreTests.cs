using EcoEnergySegonaFaseDef.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ConfParametreTests
    {
        [Fact]
        public void ConfParametreSolarU()
        {
            //Arrange
            //Act
            SistemaSolar result = new SistemaSolar(1);
            //Assert
            Assert.True(result.ConfParametre());
        }

        [Fact]
        public void ConfParametreSolarCero()
        {
            //Arrange
            //Act
            SistemaSolar result = new SistemaSolar(0);
            //Assert
            Assert.False(result.ConfParametre());
        }
        [Fact]
        public void ConfParametreSolarDos()
        {
            //Arrange
            //Act
            SistemaSolar result = new SistemaSolar(2);
            //Assert
            Assert.True(result.ConfParametre());
        }

        [Fact]
        public void ConfParametreEolicaCinc()
        {
            //Arrange
            //Act
            SistemaEolica result = new SistemaEolica(5);
            //Assert
            Assert.True(result.ConfParametre());
        }

        [Fact]
        public void ConfParametreEolicaSis()
        {
            //Arrange
            //Act
            SistemaEolica result = new SistemaEolica(6);
            //Assert
            Assert.True(result.ConfParametre());
        }

        [Fact]
        public void ConfParametreEolicaQuatre()
        {
            //Arrange
            //Act
            SistemaEolica result = new SistemaEolica(4);
            //Assert
            Assert.False(result.ConfParametre());
        }

        [Fact]
        public void ConfParametreHidroelectricaVint()
        {
            //Arrange
            //Act
            SistemaHidroelectrica result = new SistemaHidroelectrica(20);
            //Assert
            Assert.True(result.ConfParametre());
        }

        [Fact]
        public void ConfParametreHidroelectricaVintiU()
        {
            //Arrange
            //Act
            SistemaHidroelectrica result = new SistemaHidroelectrica(21);
            //Assert
            Assert.True(result.ConfParametre());
        }

        [Fact]
        public void ConfParametreHidroelectricaDiNou()
        {
            //Arrange
            //Act
            SistemaHidroelectrica result = new SistemaHidroelectrica(19);
            //Assert
            Assert.False(result.ConfParametre());
        }
    }
}
