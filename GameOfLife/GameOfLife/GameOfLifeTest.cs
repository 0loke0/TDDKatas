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
    
    //Cualquier célula viva con mas de dos vecinas vivas continua con vida
    [Fact]
    public void Si_CelulaVivaConAlmenosDosVecinas_Debe_ContinuarViva()
    {
        Celula celula = new Celula();
        
        //Act 
        celula.ValidarSiLaCelulaEstaViva(3);
        
        //Assert
        celula.EstaViva.Should().Be(true);
    }
}

public class Celula
{
    public void ValidarSiLaCelulaEstaViva(int celulasVivasAdyacentes)
    {
        if (celulasVivasAdyacentes < 2)
        {
            EstaViva = false;
        }
    }
    
    public object EstaViva { get; set; } = true;
}