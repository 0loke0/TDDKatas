using AwesomeAssertions;
namespace GameOfLife;

public class GameOfLifeTest
{
    //Cualquier célula viva con menos de dos vecinas vivas muere
    [Fact]
    public void Si_CelulaVivaConMenosDeDosVecinas_Debe_Morir()
    {   
        //Arrange
        Celula celula = new Celula();
        
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
          Celula celula = new Celula();
          
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
        Celula celula = new Celula();
          
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
        Celula celula = new Celula();
          
        //Act
        celula.ValidarSiLaCelulaRevive(3);
          
        //Assert
        celula.EstaViva.Should().Be(true);
    }
}

public class Celula
{
    public void ValidarSiLaCelulaEstaViva(int celulasVivasAdyacentes)
    {
        if (celulasVivasAdyacentes < 2 | celulasVivasAdyacentes > 3)
        {
            EstaViva = false;
        }
    }
    public bool EstaViva { get; set; } = true;

    public void ValidarSiLaCelulaRevive(int celulasVivasAdyacentes)
    {
        if (this.EstaViva == false && celulasVivasAdyacentes == 3)
        {
            this.EstaViva = true; 
        }
    }
}

// public class GameOfLife {
//     
//     public GameOfLife(bool[][] board);
//     public void nextGen();
// }