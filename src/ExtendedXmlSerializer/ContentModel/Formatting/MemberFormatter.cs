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

using System.Reflection;
using ExtendedXmlSerializer.ContentModel.Members;
using ExtendedXmlSerializer.Core;

namespace ExtendedXmlSerializer.ContentModel.Formatting
{
	sealed class MemberFormatter : IMemberFormatter
	{
		readonly ITypeFormatter _type;
		readonly Delimiter _separator;

		public MemberFormatter(ITypeFormatter type) : this(type, DefaultClrDelimiters.Default.Separator) {}

		public MemberFormatter(ITypeFormatter type, Delimiter separator)
		{
			_type = type;
			_separator = separator;
		}

		public string Get(MemberInfo parameter)
			=> string.Concat(_type.Get(parameter.GetReflectedType()), _separator, parameter.Name);
	}
}