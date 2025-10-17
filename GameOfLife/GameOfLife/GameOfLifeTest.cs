using AwesomeAssertions;

namespace GameOfLife
{
    public class GameOfLifeTest
    {
        Celula celula;
        public GameOfLifeTest()
        {
            this.celula = new Celula();
        }
        //Cualquier célula viva con menos de dos vecinas vivas muere
        [Fact]
        public void Si_CelulaVivaConMenosDeDosVecinas_Debe_Morir()
        {   
            //Arrange
            
        
            //Act 
            celula.ValidarSiLaCelulaEstaViva(1);
        
            //Assert
            celula.EstaViva.Should().Be(false);
        }
    
 
    
        // Cualquier célula viva con dos o tres vecinas vivas pasa a la siguiente generación
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void Si_CelulaVivaConDosOTresDosVecinas_Debe_ContinuarViva(int celulasVivasAdyacentes)
        {   
            //Arrange
          
            //Act 
            celula.ValidarSiLaCelulaEstaViva(celulasVivasAdyacentes);
          
            //Assert
            celula.EstaViva.Should().Be(true);
        }
    
        //Cualquier célula viva con más de tres vecinas vivas muere
        [Fact]
        public void Si_CelulaVivaConMasDeTresVecinas_Debe_Morir()
        {   
            //Arrange
          
            //Act 
            celula.ValidarSiLaCelulaEstaViva(4);
          
            //Assert
            celula.EstaViva.Should().Be(false);
        }
    
        // Cualquier célula muerta con exactamente tres vecinas vivas se convierte en una célula viva
        [Fact]
        public void Si_UnaCelulaMuertaTieneExactamenteTresCelulasVecianas_Debe_Revivir()
        {   
            //Arrange
          
            //Act
            celula.ValidarSiLaCelulaRevive(3);
          
            //Assert
            celula.EstaViva.Should().Be(true);
        }
        
        //Las células fuera de los límites de la matriz deben considerarse permanentemente muertas
        [Fact]
        public void Si_UnaCelulaSeMantieneFueraDelMundo_Debe_MantenerseMuerta()
        {   
            //Arrange
          
            //Act
            celula.ValidarSiLaCelulaRevive(3);
          
            //Assert
            celula.EstaViva.Should().Be(true);
        }
    }
}   

// public class GameOfLife {
//     
//     public GameOfLife(bool[][] board);
//     public void nextGen();
// }