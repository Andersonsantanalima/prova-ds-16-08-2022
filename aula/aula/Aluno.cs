namespace aula
{
    class Aluno
    {
        public string nome;
        public string cpf;
        public string datanacimento;
        public string contato;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double media;
        public double recuperacao;
        public double Nmedia;

        public double calcMedia()
        {
            media = (Nota1 + Nota2 + Nota3) / 3;
            return media;
        }
        public double calcRecuperacao()
        {
            if (media <= 6)
            {
                Nmedia = media + recuperacao;
            }
            else
            {
                Nmedia = media;
            }
            return Nmedia;
        }
    }


}
