﻿// MIT License
// 
// Copyright (c) 2016 Wojciech Nagórski
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

namespace ExtendedXmlSerialization.ContentModel.Members
{
	public struct MemberInformation // : IEquatable<MemberInformation>
	{
		/*
		readonly int _code;

		public MemberInformation(MemberInfo metadata, TypeInfo memberType, bool assignable)
			: this(metadata, memberType, assignable, metadata.MetadataToken.GetHashCode()) {}*/

		public MemberInformation(MemberInfo metadata, TypeInfo memberType, bool assignable/*, int code*/)
		{
			/*_code = code;*/
			Metadata = metadata;
			MemberType = memberType;
			Assignable = assignable;
		}

		public MemberInfo Metadata { get; }
		public TypeInfo MemberType { get; }
		public bool Assignable { get; }

		/*public bool Equals(MemberInformation other) => _code == other._code;

		public override bool Equals(object obj)
			=> !ReferenceEquals(null, obj) && obj is MemberInformation && Equals((MemberInformation) obj);

		public override int GetHashCode() => _code;

		public static bool operator ==(MemberInformation left, MemberInformation right) => left.Equals(right);

		public static bool operator !=(MemberInformation left, MemberInformation right) => !left.Equals(right);*/
	}
}