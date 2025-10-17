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
}

public class Celula
{
    public void ValidarSiLaCelulaEstaViva(int i)
    {
    }

    public object EstaViva { get; set; } = false;
}