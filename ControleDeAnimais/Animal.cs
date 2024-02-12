using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public class Animal
    {
		//Estamos fazendo dessa forma para aplicar o conceito de encapsulamento da POO
		//Dado privado -> É comum na comunidade, usar os nomes das propriedades privadas começando com o underline.
		private string _nome;

		//Propriedade pública
		public string Nome
		{
			get { return this._nome; }
			set { this._nome = value.ToUpper(); }
		}

		private string _tipo;

		public string Tipo
		{ // Valores definidos pelo proprietário - Cachorro, Gato, Peixe
			get { return this._tipo; }
			set 
			{
				var nomeAnimal = value.ToUpper();
				switch (nomeAnimal)
				{
					case "CACHORRO": this._tipo = nomeAnimal; break;
					case "GATO": this._tipo = nomeAnimal; break;
					case "PEIXE": this._tipo = nomeAnimal; break;
					default: this._tipo = "Peixe"; break;
				}
			}
		}
	}
}
