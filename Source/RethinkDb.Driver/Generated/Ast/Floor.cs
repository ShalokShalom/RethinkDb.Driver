












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

    public class Floor : ReqlExpr {

    
    
    
/// <summary>
/// <para>Rounds the given value down, returning the largest integer value less than or equal to the given value (the value's floor).</para>
/// </summary>
/// <example><para>Example: Return the floor of 12.345.</para>
/// <code>&gt; r.floor(12.345).run(conn, callback);
/// 
/// 12.0
/// </code></example>
        public Floor (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Rounds the given value down, returning the largest integer value less than or equal to the given value (the value's floor).</para>
/// </summary>
/// <example><para>Example: Return the floor of 12.345.</para>
/// <code>&gt; r.floor(12.345).run(conn, callback);
/// 
/// 12.0
/// </code></example>
        public Floor (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Rounds the given value down, returning the largest integer value less than or equal to the given value (the value's floor).</para>
/// </summary>
/// <example><para>Example: Return the floor of 12.345.</para>
/// <code>&gt; r.floor(12.345).run(conn, callback);
/// 
/// 12.0
/// </code></example>
        public Floor (Arguments args, OptArgs optargs)
             : this(TermType.FLOOR, args, optargs) {
        }

    protected Floor (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
