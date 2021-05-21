using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_GUI
{
    public class Arqueiro : AvatarDeJogador
    {
        public override void Falar()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Arqueiro Indio Ana Jones... ");
            Console.ResetColor();
            Console.WriteLine(" ╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ HAHAHAHAHAAH Olha que orc bonitinho !                                       ║");
            Console.WriteLine(" ║ Vou te mandar pra uma viagem sem volta para visitar sua vózinha hahahhahah !║");
            Console.WriteLine(" ╙═════════════════════════════════════════════════════════════════════════════╜");
            Console.WriteLine();
            Console.ReadKey();
        }
        public override void Historia()
        {
            Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║ Indio Ana Jones o melhor arqueiro da Amazonia.                                ║" + Environment.NewLine +
                " ║ passou sua adolescência realizado treinos exaustivos na floresta caçando e    ║" + Environment.NewLine +
                " ║ protegendo sua Tribio, devido aos exaustivos treinos sofre de tiques raivosos ║" + Environment.NewLine +
                " ║ e multiplas personalidades, porem nao afeta sua mira.                         ║" + Environment.NewLine +
                " ║ Sem motivos especificos tem muita raiva e inveja dos Orcs e junto do seu Arco ║" + Environment.NewLine +
                " ║ e suas flechas apelidadas de yondu's irá matar todos os orc que cruzarem seu  ║" + Environment.NewLine +
                " ║   caminho.                                                                    ║");
            Console.WriteLine(" ╙═══════════════════════════════════════════════════════════════════════════════╜");
            Console.WriteLine("");
            Console.WriteLine("");

        }

        public override int AtaqueBasico()

        {
            return base.AtaqueBasico();
        }
        public Arqueiro() : base()
        {
            
            this.Nome = "Arqueiro Indio Ana Jones";
            this.Forca = 15;
            this.MaxMP = 30;
            this.MaxHP = 27;
            this.Level = 1;
            this.HP = this.MaxHP;
            this.MP = this.MaxMP;
            Acao acao;

            acao = new Acao() { AcaoNome = "(Básico) Vo te mataaaaa hahahhah !", CustoMP = 0, ResolverAcao = this.AtaqueBasico };
            ListaAcao.Add(acao);
            acao = new Acao() { AcaoNome = "(Médio) Voaaa Pombinhaaaa!", CustoMP = 9, ResolverAcao = this.PoderA1 };
            ListaAcao.Add(acao);
            acao = new Acao() { AcaoNome = "(Especial) cochi de Yondu !", CustoMP = 16, ResolverAcao = this.PoderA2 };
            ListaAcao.Add(acao);
            ListaAcao.Add(item: new Acao() { AcaoNome = "(Cura) Lamber sapo de Narnia", CustoMP = 7, ResolverAcao = this.CuraA });
            
        }

        public override void AtaqueBasico(Avatar oponente)
        {
            this.ImprimirAcao(Acao: "(Básico) Vo te mataaaaa hahahahaha !", Forca, oponente);
            oponente.HP = oponente.HP - Forca;
        }
        public virtual void PoderA1(Avatar oponente)
        {
            int ForcaAcao = this.Forca * 2;
            this.ImprimirAcao(Acao: " (Médio) Voaaa Pombinhaaaa!", ForcaAcao, oponente);
            oponente.HP = oponente.HP - ForcaAcao;
        }
        public void PoderA2(Avatar oponente)
        {
            int ForcaAcao = this.Forca * 3;
            this.ImprimirAcao(Acao: "(Especial) cochico de Yondu !", ForcaAcao, oponente);
            oponente.HP = oponente.HP - ForcaAcao;
        }
        public void CuraA(Avatar oponente)
        {
            int ForcaAcao = this.MaxMP / 3;
            this.ImprimirAcao(Acao: "(Cura) Lamber sapo de Narnia", ForcaAcao, Alvo: this);
            this.HP = this.HP + ForcaAcao;
            
        }
    }
}
