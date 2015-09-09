












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class DeleteAt : ReqlExpr {

    
    
    
/// <summary>
/// <para>Remove one or more elements from an array at a given index. Returns the modified array.</para>
/// </summary>
/// <example><para>Example: Delete the second element of an array.</para>
/// <code>&gt; r(['a','b','c','d','e','f']).deleteAt(1).run(conn, callback)
/// // result passed to callback
/// ['a', 'c', 'd', 'e', 'f']
/// </code></example>
        public DeleteAt (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Remove one or more elements from an array at a given index. Returns the modified array.</para>
/// </summary>
/// <example><para>Example: Delete the second element of an array.</para>
/// <code>&gt; r(['a','b','c','d','e','f']).deleteAt(1).run(conn, callback)
/// // result passed to callback
/// ['a', 'c', 'd', 'e', 'f']
/// </code></example>
        public DeleteAt (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Remove one or more elements from an array at a given index. Returns the modified array.</para>
/// </summary>
/// <example><para>Example: Delete the second element of an array.</para>
/// <code>&gt; r(['a','b','c','d','e','f']).deleteAt(1).run(conn, callback)
/// // result passed to callback
/// ['a', 'c', 'd', 'e', 'f']
/// </code></example>
        public DeleteAt (Arguments args, OptArgs optargs)
             : this(TermType.DELETE_AT, args, optargs) {
        }

    protected DeleteAt (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
