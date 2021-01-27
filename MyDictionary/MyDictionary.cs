using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TypeOfKey, TypeOfValue>
    {
        TypeOfKey[] keys;
        TypeOfValue[] values;

        // constructor
        public MyDictionary()
        {
            keys = new TypeOfKey[0];
            values = new TypeOfValue[0];
        }

        public void Add(TypeOfKey key, TypeOfValue value)
        {
            // temp arrays
            TypeOfKey[] tempKeyArray = keys;
            TypeOfValue[] tempValueArray = values;

            keys = new TypeOfKey[keys.Length + 1];
            values = new TypeOfValue[values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
            }

            for (int j = 0; j < tempValueArray.Length; j++)
            {
                values[j] = tempValueArray[j];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

    }
}
