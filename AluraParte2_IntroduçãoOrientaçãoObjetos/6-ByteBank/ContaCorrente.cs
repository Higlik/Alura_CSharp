namespace _6_ByteBank
{
    class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;


        //Parâmetro para realizar saque
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;

        }

        public void depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente ContaDestino)
        {
            if (this.saldo < valor)
                return false;

            this.saldo -= valor;
            ContaDestino.depositar(valor);
            return true;


        }


    }
}
