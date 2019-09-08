using System;
using System.Collections.Generic;
using System.Text;
using LanguageExt;

namespace Lauguage_Ext.Test.Model
{
    public sealed class ObjectA<T> : Record<ObjectA<T>>
    {
        public T Obj { get; }

        public ObjectA(T obj)
        {
            Obj = obj;
        }
    }
}
