












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

    public class Downcase : ReqlExpr {

    
    
    
/// <summary>
/// <para>Lowercases a string.</para>
/// </summary>
/// <example><para>Example:</para>
/// <code>r.expr("Sentence about LaTeX.").downcase().run(conn, callback)
/// </code></example>
        public Downcase (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Lowercases a string.</para>
/// </summary>
/// <example><para>Example:</para>
/// <code>r.expr("Sentence about LaTeX.").downcase().run(conn, callback)
/// </code></example>
        public Downcase (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Lowercases a string.</para>
/// </summary>
/// <example><para>Example:</para>
/// <code>r.expr("Sentence about LaTeX.").downcase().run(conn, callback)
/// </code></example>
        public Downcase (Arguments args, OptArgs optargs)
             : this(TermType.DOWNCASE, args, optargs) {
        }

    protected Downcase (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
