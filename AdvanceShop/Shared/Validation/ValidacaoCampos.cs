using AdvanceShop.Shared.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Shared.Validation
{
    public static class ValidacaoCampos
    {
        private static int _totalErros;
        private static IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }
        public static void Validar(object obj)
        {

            var erros = getValidationErros(obj);
            _totalErros = erros.Count();
            foreach (var error in erros)
            {
                MessageBoxError.Show(error.ErrorMessage);
            }
        }
        public static bool IsValid()
        {
            if(_totalErros > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
