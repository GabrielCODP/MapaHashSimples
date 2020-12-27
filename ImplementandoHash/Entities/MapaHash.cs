using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementandoHash.Entities
{
    class MapaHash
    {
        private Registro[] valores;

        public MapaHash()
        {
            valores = new Registro[100];
        }

        public void push(Registro registro)
        {
            int posicao = registro.hashCode(); //Receber o calculo do hashCode 

            if (valores[posicao] == null)  //Se o valor do calculo nessa posicao for vazio, colocar.
            {
                valores[posicao] = registro;
                Console.WriteLine("\n::::::: Empty positon!! New record creation :::::::");
            }

            else
            {
                Console.WriteLine("\n::::::: Ops...Collision! :::::::");

                Registro reg = valores[posicao]; //Pego essa o valor dessa posição e coloco no reg

                //Tratar o primeiro elemento

                if (reg.getKey() == registro.getKey()) // O registro que quero inserir é o mesmo, exemplo: reg.Key=58 -> registro.key=58: 
                {
                    reg.setValue(registro.getValue()); // Substituo o valor, Exemplo o valor é Sherlock, vou trocar esse valor por outro nomoe, por causa que repetiu uma key.

                    Console.WriteLine("\n:::::: Existing record - Updateding... ::::::");

                    return;
                }

                //Se ele está no meio da lista

                while (reg.getProximo() != null)
                {
                    if (reg.getKey() == registro.getKey()) // O registro que quero inserir é o mesmo?
                    {
                        reg.setValue(registro.getValue());

                        Console.WriteLine("\n:::::: Existing record - Updateding... ::::::");
                        return;
                    }

                    reg = reg.getProximo();
                }

                //Se ele é o ultima da lista

                if (reg.getKey() == registro.getKey())
                {
                    reg.setValue(registro.getValue());

                    Console.WriteLine("\n:::::: Existing record, last in list- Updateding... ::::::");
                    return;
                }


                reg.setProximo(registro); //Coloquei o novo registro na pultima posicao.
                Console.WriteLine("\nNew record!");
            }
        }

        public Registro get(int key) //valor da chave escolhida
        {
            Registro temp = new Registro();
            temp.setKey(key); //Incluir chava no Registro R

            int posicao = temp.hashCode();

            Registro resultado = valores[posicao]; //Encontrar o registro

            if (resultado != null && resultado.getKey() == key)   //É a chave que eu quero
                return resultado;

            else
            {
                while (resultado != null)  // Quando tiver gente na lista
                {
                    resultado = resultado.getProximo(); //Vou para o proximo

                    if (resultado != null && resultado.getKey() == key) //Achou,retorna;
                        return resultado;
                }
            }

            return null; //Se não tiver  posição, retorna null
        }
    }
}
