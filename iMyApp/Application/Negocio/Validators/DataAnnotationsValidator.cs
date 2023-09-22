using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Validators
{
    public class Validacoes
    {
        ///<summary>
        ///Validar as DataAnotattions de uma classe.
        ///<exemple>Exemplo:
        ///<code>
        ///     var erros = Validacoes.getValidationErros(obj)
        ///     foreach (var error in erros)
        ///     {
        ///         MassegeBox.Show((error.ErrorMassage));
        ///     }
        ///
        ///</code>
        ///</exemple>
        ///<param name="obj">é a classe instanciada</param>
        ///<returns>Lista de erros</returns>
        ///</summary>
        public static IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }
    }
}
