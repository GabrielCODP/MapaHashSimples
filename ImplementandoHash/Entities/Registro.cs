using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementandoHash.Entities
{
    class Registro
    {
        private int _Key;
        private string _Value;
        private Registro _Proximo;

        public Registro()
        {
            _Proximo = null;
        }

        public Registro(int key, string value)
        {
            _Key = key;
            _Value = value;
            _Proximo = null;
        }

        public void setKey(int key)
        {
            _Key = key;
        }

        public void setValue(string value)
        {
            _Value = value;
        }

        public void setProximo(Registro proximo)
        {
            _Proximo = proximo;
        }
        public int getKey()
        {
            return _Key;
        }

        public string getValue()
        {
            return _Value;
        }

        public Registro getProximo()
        {
            return _Proximo;
        }

        public int hashCode()
        {
            return _Key % 100; //Pode ser qualquer divisão
        }
    }
}
