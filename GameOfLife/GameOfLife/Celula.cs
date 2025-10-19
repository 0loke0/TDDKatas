
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

    public void ValidarSiLaCelulaRevive(int celulasVivasAdyacentes,int limiteXMaximo,int limiteYMaximo,int posicionX,int posicionY)
    {
        if (this.EstaViva == false && celulasVivasAdyacentes == 3)
        {
            this.EstaViva = true; 
        }
    }
}