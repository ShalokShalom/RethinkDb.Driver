












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

    public class Not : ReqlExpr {

    
    
    
/// <summary>
/// <para>Compute the logical inverse (not) of an expression.</para>
/// <para><code>not</code> can be called either via method chaining, immediately after an expression that evaluates as a boolean value, or by passing the expression as a parameter to <code>not</code>.</para>
/// </summary>
/// <example><para>Example: Not true is false.</para>
/// <code>r(true).not().run(conn, callback)
/// r.not(true).run(conn, callback)
/// </code></example>
        public Not (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Compute the logical inverse (not) of an expression.</para>
/// <para><code>not</code> can be called either via method chaining, immediately after an expression that evaluates as a boolean value, or by passing the expression as a parameter to <code>not</code>.</para>
/// </summary>
/// <example><para>Example: Not true is false.</para>
/// <code>r(true).not().run(conn, callback)
/// r.not(true).run(conn, callback)
/// </code></example>
        public Not (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Compute the logical inverse (not) of an expression.</para>
/// <para><code>not</code> can be called either via method chaining, immediately after an expression that evaluates as a boolean value, or by passing the expression as a parameter to <code>not</code>.</para>
/// </summary>
/// <example><para>Example: Not true is false.</para>
/// <code>r(true).not().run(conn, callback)
/// r.not(true).run(conn, callback)
/// </code></example>
        public Not (Arguments args, OptArgs optargs)
             : this(TermType.NOT, args, optargs) {
        }

    protected Not (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
