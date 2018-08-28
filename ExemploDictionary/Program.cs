using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O Dictionary por definição uma coleção de  KeyValuePair, ou seja,
             é uma coleção cujos itens possuem chave (identificador)
             e valor (associado à chave)

            Para exemplificar, criei um Dictionary dentro de outro Dictionary

            */
            Dictionary<string, Dictionary<string, string>> meu_dictionary = 
                new Dictionary<string, Dictionary<string, string>>();

            /*
             Para fins de exemplo, vamos popular nosso Dictonary 
             com dados fictícios.
            */

            for(int i = 1; i <=10; i++)
            {
                //Objeto criado para facilitar a atribuição de dados no Dictionary 'filho'
                Dictionary<string, string> dic_filho = new Dictionary<string, string>();

                //Looping criado para popular o Dictionary 'filho'
                for (int j = 1; j <= 10; j++)
                {
                    dic_filho.Add("Key " + j.ToString() + " - Dic. Filho", 
                                  "Valor " + j.ToString());
                }

                meu_dictionary.Add("Key " + i.ToString(),
                    dic_filho);
            }

            /*
             Após populado nosso objeto, vamos percorrê-lo e 
             exibir os dados em tela apenas para demonstrar
             como percorrer dados em um Dictionary
            */
            foreach (KeyValuePair<string, Dictionary<string, string>> item_dic in meu_dictionary)
            {
                Console.WriteLine(item_dic.Key);

                foreach(KeyValuePair<string,string> sub_item in item_dic.Value)
                {
                    Console.WriteLine("    " + sub_item.Key + ":" + sub_item.Value);
                }
            }

            Console.Read();
        }

       
    }
}
