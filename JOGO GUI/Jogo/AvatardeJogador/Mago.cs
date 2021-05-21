using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Mago : AvatarDeJogador
    {
        public override void Falar()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Mago Felipe Smith... ");
            Console.ResetColor();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ JAMAIS SERÁ !                                                  ║");
            Console.WriteLine(" ║ ...PEGA UM INCENSO PRA MIM VEI PELAMOR DE DEUS (Alucinações)!  ║");
            Console.WriteLine(" ╙════════════════════════════════════════════════════════════════╜");
            Console.WriteLine();
            Console.ReadKey();

        }

        public override void Historia()
        {
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ Felipe Smith Um jovem mago que sofre com alucinações, é dependente de fortes  ║" + Environment.NewLine +
                " ║ ervas que o controlam. Nasceu em Guarapari Buzios onde se encontra sua arte.  ║" + Environment.NewLine +
                " ║ E lá ficou aprisionado em um campo de concentração controlada por um grupo de ║" + Environment.NewLine +
                " ║ Orcs, passou sua infância e adolescência toda preso, sofrendo varios testes   ║" + Environment.NewLine +
                " ║ com alucinógenos. Devido aos testes desenvolveu poderes jamais vistos que o   ║" + Environment.NewLine +
                " ║ auxiliou na sua fuga, Infelizmente sofre ainda com multiplas alucinações      ║" + Environment.NewLine +
                " ║ acompanhado de seu cajado com o apelido de Romero Brito que o ajuda controlar ║" + Environment.NewLine +
                " ║ seus poderes, prometeu a si mesmo aniquilar toda a raça de orc's              ║");
            Console.WriteLine(" ╙═══════════════════════════════════════════════════════════════════════════════╜");
        }

        public Mago(): base() 
        {
            
            this.Nome = "Mago Felipe Smith";
            this.Forca = 14;
            this.MaxMP = 30;
            this.MaxHP = 35;
            this.Level = 1;
            this.HP = this.MaxHP;
            this.MP = this.MaxMP;
            Acao acao;
            
            acao = new Acao() { AcaoNome = " (Básico) JULIANAAAAAA !", CustoMP = 0, ResolverAcao = this.AtaqueBasico };
            ListaAcao.Add(acao);
            acao = new Acao() { AcaoNome = " (Médio) KATRINAAAAAAAA !", CustoMP = 11,  ResolverAcao = this.PoderM1 };
            ListaAcao.Add(acao);
            acao = new Acao() { AcaoNome = " (Especial) Buzios é minha arte !", CustoMP = 20, ResolverAcao = this.PoderM2 };
            ListaAcao.Add(acao);
            ListaAcao.Add(item: new Acao() { AcaoNome = "(Cura) MINHA VIDA VEI ! , SAMU ?", CustoMP = 7, ResolverAcao = this.CuraM });
            

        }

        public override void AtaqueBasico(Avatar oponente)
        {
            this.ImprimirAcao(Acao: "(Básico) JULIANAAAAAA !", Forca, oponente);
            oponente.HP = oponente.HP - Forca;
        }

        public void PoderM1(Avatar oponente)
        {
            int ForcaAcao = this.Forca * 2;
            this.ImprimirAcao(Acao: "(Médio) Chuva de laminas katrina", ForcaAcao, oponente);
            oponente.HP = oponente.HP - ForcaAcao;
        }
        public void PoderM2(Avatar oponente)
        {
            int ForcaAcao = this.Forca * 3; 
            this.ImprimirAcao(Acao: "(Especial) Alucinação cultural", ForcaAcao, oponente);
            oponente.HP = oponente.HP - ForcaAcao;
        }
        public void CuraM(Avatar oponente)
        {
            int ForcaAcao = this.MaxMP /3 ;
            this.ImprimirAcao(Acao: "(Cura) MINHA VIDA VEI ! ...SAMU ?", ForcaAcao, Alvo:this);
            this.HP = this.HP + ForcaAcao ;
        }
    }
}
