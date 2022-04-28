namespace _8_ByteBank
{
    class ContaCorrente
    {
        public Cliente Titular {get;set;}

        public static int TotalDeContasCriadas { get; private set;} 
              
        public int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get;set;}
        private double _saldo = 100;

        public double Saldo
        {
            get { 
                return _saldo;
                }
            set {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;

                }
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        //Parâmetro para realizar saque
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }

        public void depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente ContaDestino)
        {
            if (this._saldo < valor)
                return false;

            this._saldo -= valor;
            ContaDestino.depositar(valor);
            return true;


        }


    }
}
