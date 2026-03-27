using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PetLove_Modificacao.Models
{
    public class Animal
    {
        #region Declaração dos atributos da classe "Animal"

        // Apenas o set está privado, não sei qual seria a boa prática aqui então deixai com o _ mesmo 
        public string _nome { get; private set; }
        public string _animal { get; private set; }
        public string _raca { get; private set; }
        public int _idade { get; private set; }

        #endregion


        public Animal(string _nome, string _animal, string _raca, int idade)
        {
            #region Os atributos recebem os valores vindo qo passar no parâmetro na hora de instanciar
            this._animal = _animal;
            this._raca = _raca;
            this._idade = idade;
            this._nome = _nome;
            #endregion 


        }


        public override string ToString() => $"{_nome} - {_animal} - {_raca} - {_idade}";




    }


}

