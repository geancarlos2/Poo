using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Pneu pneu = new Pneu(23,"nnn");
        pneu.Exibir();
        pneu.Remendar();*/
        Pneu pneuMichelan = new Pneu(16, "Michelan");
         Carro corcel = new Carro("Chevrolet", "2");
       /* corcel.LigarDesligar();
        corcel.Acelerar(5);
        corcel.Abastecer(50);
        corcel.Frear(30);
        corcel.Acelerar(500);
        corcel.Frear(300);
        corcel.Acelerar(500);
        corcel.Frear(200);
        corcel.Exibir();*/
        for (int i = 0; i == 0; i++)
        {
            //corcel.LigarDesligar();
            corcel.Acelerar(270);
         
            corcel.Frear(14);
            corcel.Exibir();
        }

        //corcel.LigarDesligar();
        corcel.PneuTrazeiroEsquerdo = pneuMichelan;
        corcel.Exibir();
    }
}