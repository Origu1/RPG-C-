using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Cavaleiro : AvatarDeJogador
    {
        public override void Falar()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Cavaleiro Jeremias... ");
            Console.ResetColor();
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ Tu vai visitar o cão... !                                      ║");
            Console.WriteLine(" ║ ...Burp (arroto)!                                              ║");
            Console.WriteLine(" ╙════════════════════════════════════════════════════════════════╜");
            Console.WriteLine();
            Console.ReadKey();
        }
        public override void Historia()
        {
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ Jeremias um nobre cavaleiro acreano.                                          ║" + Environment.NewLine +
                " ║ que sofre ao lembrar do seu passado... devido ao vicio do alcool.             ║" + Environment.NewLine +
                " ║ Filho de um nobre ferreiro que forjava as melhores armas da regiao do Acre,   ║" + Environment.NewLine +
                " ║ ainda criança viu sua familia e seu vilarejo ser brutalmente massacrados      ║" + Environment.NewLine +
                " ║ pelos Orcs, diante de tal brutalidade prometeu a si mesmo vingança.           ║" + Environment.NewLine +
                " ║ Acompanhadode de sua afiada e enorme espada chamada Joeliton e seu grande     ║" + Environment.NewLine +
                " ║ escudo  de casco de tortuguita prometeu se vingar e dizimar todos os  Orc's.  ║");
            Console.WriteLine(" ╙═══════════════════════════════════════════════════════════════════════════════╜");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public Cavaleiro() : base()
        {
            this.Nome = "Cavaleiro Jeremias";
            this.Forca = 16;
            this.MaxHP = 30;
            this.MaxMP = 30;
            this.Level = 1;
            this.HP = this.MaxHP;
            this.MP = this.MaxMP;
            Acao acao;
            acao = new Acao() { AcaoNome = "(Básico) Eu sou cabra home !", CustoMP = 0, ResolverAcao = this.AtaqueBasico };
            ListaAcao.Add(acao);
            acao = new Acao() { AcaoNome = "(Médio) Orc safado tem que morre!", CustoMP = 7, ResolverAcao = this.PoderC1 };
            ListaAcao.Add(acao);
            acao = new Acao() { AcaoNome = "(Especial) EU MATAVA MIL !", CustoMP = 15, ResolverAcao = this.PoderC2 };
            ListaAcao.Add(acao);
            ListaAcao.Add(item: new Acao() { AcaoNome = "(Cura) Foi o cão que boto pá bebe", CustoMP = 7, ResolverAcao = this.CuraC });
            
        }

        public override void AtaqueBasico(Avatar oponente)
        {
            this.ImprimirAcao(Acao: " (Básico) Eu sou cabra home !", Forca, oponente);
            oponente.HP = oponente.HP - Forca;
        }

        public virtual void PoderC1(Avatar oponente)
        {
            int ForcaAcao = this.Forca * 2;
            this.ImprimirAcao(Acao: "(Médio) Orc safado tem que morre!", ForcaAcao, oponente);
            oponente.HP = oponente.HP - ForcaAcao;
        }
        public void PoderC2(Avatar oponente)
        {
            int ForcaAcao = this.Forca * 2;
            this.ImprimirAcao(Acao: "(Especial) EU MATAVA MIL !", ForcaAcao, oponente);
            oponente.HP = oponente.HP - ForcaAcao;
        }
        public void CuraC(Avatar oponente)
        {
            int ForcaAcao = this.MaxMP / 3;
            this.ImprimirAcao(Acao: "(Cura) Foi o cão que boto pá bebe", ForcaAcao, Alvo: this);
            this.HP = this.HP + ForcaAcao;
        }

    }
}   

    

