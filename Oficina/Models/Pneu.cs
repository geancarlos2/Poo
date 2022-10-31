namespace Models
{
    public class Pneu
    {
        private int aro;
        private string marca;
        private bool furado;
        private int psi;
        private bool estourado;
        private double percentualBorracha;
        private int rotacao;
        public double PercentualBorracha
        {
            get { return percentualBorracha; }
            set { percentualBorracha = value; }
        }
        public int Aro
        {
            get { return aro; }
            set { aro = value; }
        }
        public bool Furado
        {
            get { return furado; }
            set { furado = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Psi
        {
            get { return psi; }
            set { psi = value; }
        }
        public bool Estourado
        {
            get { return estourado; }
            set { estourado = value; }
        }
        public int Rotacao
        {
            get { return rotacao; }
            set { rotacao = value; }
        }



        public Pneu(int aro, string marca)
        {
            Aro = aro;
            Marca = marca;
            Furado = false;
            Psi = 33;
            Estourado = false;
            PercentualBorracha = 100;
            Rotacao = 0;

        }
        public void Girar(int _rotacao)
        {
            Rotacao += _rotacao;
            gastarBOrracha(_rotacao / 100);
        }
        public void Frear(int _abatimento)
        {
            PercentualBorracha -= 10;
            Rotacao += _abatimento;
            gastarBOrracha(_abatimento / 100);
        }
        public void furar()
        {
            furado = true;
        }
        public void Remendar()
        {
            Furado = false;
        }
        private void gastarBOrracha(double _quantidade)
        {
            PercentualBorracha -= _quantidade;
            //PercentualBorracha -= 10;
            if (PercentualBorracha <= 0)
                Estourar();
            
        }

        private void Estourar()
        {
            Estourado = true;
            psi = 0;
            PercentualBorracha = 0;
            Rotacao = 0;
        }
        public void Exibir()
        {
            Console.WriteLine("aro: " + Aro);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Furado: " + Furado);
            Console.WriteLine("Psi: "+Psi);
            Console.WriteLine("Estourado: "+Estourado);
            Console.WriteLine("PercentualBorracha: " + PercentualBorracha);
            Console.WriteLine("Rotacao: "+ Rotacao);

        }
    }
}
