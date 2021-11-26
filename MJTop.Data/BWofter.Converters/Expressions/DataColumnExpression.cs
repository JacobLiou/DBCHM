﻿/*
BSD 3-Clause License

Copyright (c) 2017, B. Wofter
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this
  list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.

* Neither the name of the copyright holder nor the names of its
  contributors may be used to endorse or promote products derived from
  this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 
 */
namespace BWofter.Converters.Expressions
{
    using System;
    using System.Linq.Expressions;
    public sealed class DataColumnExpression : DataExpression
    {
        public override Type Type => dataColumnType;
        public new Expression DataTable { get; }
        public Expression ColumnName { get; }

        internal DataColumnExpression(Expression dataTable, Expression columnName)
        {
            DataTable = dataTable ?? throw new ArgumentNullException(nameof(dataTable));
            ColumnName = columnName ?? throw new ArgumentNullException(nameof(columnName));
        }

        public override Expression Reduce()
        {
            if (!dataTableType.IsAssignableFrom(DataTable.Type))
            {
                throw new InvalidOperationException($"{nameof(DataTable)} should return a value that inherits from {dataTableType.FullName}, {DataTable.Type.FullName} given instead.");
            }
            if (!intType.IsAssignableFrom(ColumnName.Type) && !stringType.IsAssignableFrom(ColumnName.Type))
            {
                throw new InvalidOperationException($"{nameof(ColumnName)} should return a value that is either {intType.FullName} or {stringType.FullName}, {ColumnName.Type.FullName} given instead.");
            }
            return Property(Property(DataTable, nameof(System.Data.DataTable.Columns)), "Item", ColumnName);
        }
    }
}
