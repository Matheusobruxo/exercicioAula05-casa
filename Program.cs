using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace condicoesAula05Lc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string primeiroNome,
                sobrenome, nomeCompleto,
                endereco, bairro, cidade, estado,
                codigoDesc, notificacao;
            int vAnoPassado, vAnoAtual,
                vSomaTotal, vMedia;
            float desconto, vSaldo,
                vdesconto, vTotal;




            Console.WriteLine("Viaje com a VCN que é sucesso!\n" +
                "--------------------------------------------------------");
            Console.WriteLine("\nDigite seu primeiro nome:");
            primeiroNome = Console.ReadLine();
            Console.WriteLine("\nDigite o seu sobrenome:");
            sobrenome = Console.ReadLine();

            nomeCompleto = (primeiroNome + " " + sobrenome);


            Console.WriteLine($"\n--------------------------------------------------------------\n" +
                $"•Olá, Sr(a). {nomeCompleto}, vamos continuar seu cadastro...");

            Console.WriteLine("\nDigite seu Endereço:");
            endereco = Console.ReadLine();

            Console.WriteLine("\nDigite seu bairro:");
            bairro = Console.ReadLine();

            Console.WriteLine("\nDigite sua Cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine("\nDigite seu Estado:");
            estado = Console.ReadLine();

            Console.WriteLine($"\n--------------------------------------------------------------\n" +
               $"*O Sr(a). {nomeCompleto} mora na cidade de {cidade} - {estado},\n" +
               $"0no endereço {endereco}, localizado no bairro {bairro}\n\n--------------------------------------------------------------\n");

            Console.WriteLine($"Sr(a). {sobrenome}, quantas viagens foram realidadas por você no ano passado:\n");
            vAnoPassado = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantas viagens foram planejadas por você no ano atual:\n");
            vAnoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor que você costuma reservar para essas viagens?\n");
            vSaldo = int.Parse(Console.ReadLine());


            Console.WriteLine("--------------------------------------------------------------");


            vSomaTotal = vAnoAtual + vAnoPassado;
            vMedia = 24 / vSomaTotal;

            Console.WriteLine($"* Contando com os ultimos 2 anos, você fez {vSomaTotal}!!\n");
            Console.WriteLine($"* Faltam {10 - vSomaTotal} para completar 10 viagens!\n");
            Console.WriteLine($"* Suas viagens tem um intervalo de {vMedia} meses!\n");

            Console.WriteLine("\n--------------------------------------------------------------\n");

            Console.WriteLine($"Obrigado{nomeCompleto}, o seu cadastro foi finalizado com sucesso!!\n");

            Console.WriteLine("\n--------------------------------------------------------------\n");

            Console.WriteLine("Digite um cupom de desconto:\n");
            codigoDesc = Console.ReadLine();

            if (codigoDesc == "Conradito10")
            {
                desconto = 0.10f;
                vdesconto = vSaldo * desconto;
                vTotal = vSaldo - desconto;


                Console.WriteLine($"Parabéns, você resgatou seu cupom de 10%,\n" +
                    $"em um pacote de {vSaldo} reais você terá {vdesconto} de desconto!\n\n" +
                    $"UM PACOTE PELA BAGATELA DE {vTotal}, vai perder?\n\n");
            }
            else
            {
                Console.WriteLine("Este cupom não existe!!\n");
            }


            Console.WriteLine("Você gostaria de receber promoções no seu e - mail ?");
            notificacao = Console.ReadLine();

            if (notificacao == "Sim" || notificacao == "sim")
            {
                Console.WriteLine($"Obrigado {primeiroNome} por se registrar");
                Console.WriteLine("você receberá novos e-mails em breve.");
            }
            else
            {
                Console.WriteLine("\nRlx, você não será notificado das promoções!\n");
            }

            Console.WriteLine("\n--------------------------------------------------------------\n");

            Console.WriteLine("Obrigado, volte sempre");

            Console.ReadKey();
        }
    }
}
