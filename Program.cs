namespace Desafio_ROBO
{
        internal class Program
        {
            static int posicaoX = 3;
            static int posicaoY = 3;
            static char direcao = 'l';

            static void Main(string[] args)
            {
                string comando = "MMDMMDMDDM";

                char[] chars = comando.ToCharArray();

                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 'E')
                        VirarEsquerda();

                    if (chars[i] == 'D')
                        VirarDireita();

                    if (chars[i] == 'M')
                        Mover();
                }

                Console.WriteLine(posicaoX + " " + posicaoY + " " + direcao);
            }

            private static void Mover()
            {
                if (direcao == 'n')
                    posicaoY++;

                if (direcao == 's')
                    posicaoY--;

                if (direcao == 'o')
                    posicaoX--;

                if (direcao == 'l')
                    posicaoX++;
            }

            private static void VirarDireita()
            {
                if (direcao == 'n')
                    direcao = 'l';

                else if (direcao == 's')
                    direcao = 'o';

                else if (direcao == 'l')
                    direcao = 's';

                else if (direcao == 'o')
                    direcao = 'n';

            }

            private static void VirarEsquerda()
            {
                if (direcao == 'n')
                    direcao = 'o';

                else if (direcao == 's')
                    direcao = 'l';

                else if (direcao == 'l')
                    direcao = 'n';

                else if (direcao == 'o')
                    direcao = 's';

            }

        }
    }
