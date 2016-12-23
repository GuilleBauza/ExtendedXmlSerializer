// MIT License
// 
// Copyright (c) 2016 Wojciech Nag�rski
//                    Michael DeMond
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections;

namespace ExtendedXmlSerialization.Model.Write
{
    public interface ITypeAwareContext : IContext
    {
        Type ReferencedType { get; }
    }

    public interface IItem : ITypeAwareContext {}

    public abstract class TypeAwareContextBase<T> : ContextBase<T>, ITypeAwareContext where T : IEntity
    {
        protected TypeAwareContextBase(T entity, Type referencedType, string name) : base(entity, name)
        {
            ReferencedType = referencedType;
        }

        public Type ReferencedType { get; }
    }

    public class Item : TypeAwareContextBase<IEntity>, IItem
    {
        public Item(IEntity entity, Type elementType, string name) : base(entity, elementType, name) {}
    }

    /*public class DictionaryEntryObject : EntityBase
    {
        public DictionaryEntryObject() : base(Type) {}
    }

    public class Primitive : EntityBase, IPrimitive
    {
        public Primitive(IDictionaryKey key, Type type) : base(type)
        {
            Value = value;
        }

        public object Value { get; }
    }*/

    public class DictionaryEntryItem : Item
    {
        readonly private static Type Type = typeof(DictionaryEntry);

        public DictionaryEntryItem(IDictionaryKey key, IDictionaryValue value)
            : base(new CompositeEntity(Type, key, value), Type, ExtendedXmlSerializer.Item) {}
    }
}