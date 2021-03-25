using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdvanceShop.Shared.Validation
{
    public enum SenhaScore
    {
        Inaceitavel = 0,
        MuitoFraco = 1,
        Fraco = 2,
        Medio = 3,
        Forte = 4,
        MuitoForte = 5

    }
    
    public static class ValidacaoForcaSenha
    {
        public static SenhaScore Score(string senha)
        {
            int score = 0;

            var TemNumero = new Regex(@"[0-9]+");
            var TemLetraMaiuscula = new Regex(@"[A-Z]+");
            var TemMinOuMaxCaracter = new Regex(@".{6,24}");
            var TemLetraMinuscula = new Regex(@"[a-z]+");
            var TemSimbolos = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            if (senha.Length < 1)
                score = 0;
            if (TemNumero.IsMatch(senha))
                score++;
            if (TemLetraMaiuscula.IsMatch(senha))
                score++;
            if (TemMinOuMaxCaracter.IsMatch(senha))
                score++;
            if (TemLetraMinuscula.IsMatch(senha))
                score++;
            if (TemSimbolos.IsMatch(senha))
                score++;

            return (SenhaScore)score;
        }

    
    public static void IncrementDecrementScoreProgressBar(ProgressBarControl progressBar,string senha)
    {
        progressBar.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
        progressBar.Properties.EndColor = System.Drawing.Color.Green;
        progressBar.Properties.StartColor = System.Drawing.Color.DarkGreen;
        progressBar.Properties.ShowTitle = false;
        progressBar.Properties.LookAndFeel.SetStyle(DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat, false, false);
        
         
        SenhaScore score = ValidacaoForcaSenha.Score(senha);
        switch (score)
        {
            case SenhaScore.Inaceitavel:
                progressBar.Decrement(100);
                progressBar.Increment(1);
                //lblForcaSenha.Text = "Força da senha: inaceitável";
                break;
            case SenhaScore.MuitoFraco:
                progressBar.Decrement(100);
                progressBar.Increment(20);
                //lblForcaSenha.Text = "Força da senha: muito fraco";
                break;
            case SenhaScore.Fraco:
                progressBar.Decrement(100);
                progressBar.Increment(40);
                //lblForcaSenha.Text = "Força da senha: fraco";
                break;
            case SenhaScore.Medio:
                progressBar.Decrement(100);
                progressBar.Increment(60);
                //lblForcaSenha.Text = "Força da senha: medio";
                break;
            case SenhaScore.Forte:
                progressBar.Decrement(100);
                progressBar.Increment(80);
                //lblForcaSenha.Text = "Força da senha: forte";
                break;
            case SenhaScore.MuitoForte:
                progressBar.Decrement(100);
                progressBar.Increment(100);
                //lblForcaSenha.Text = "Força da senha: muito forte";
                break;
            default:
                break;
        }
    }
    }
}
