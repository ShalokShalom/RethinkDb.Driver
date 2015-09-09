












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

    public class ConcatMap : ReqlExpr {

    
    
    
/// <summary>
/// <para>Concatenate one or more elements into a single sequence using a mapping function.</para>
/// </summary>
/// <example><para>Example: Construct a sequence of all monsters defeated by Marvel heroes. The field "defeatedMonsters" is an array of one or more monster names.</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('defeatedMonsters')
/// }).run(conn, callback)
/// </code></example>
        public ConcatMap (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Concatenate one or more elements into a single sequence using a mapping function.</para>
/// </summary>
/// <example><para>Example: Construct a sequence of all monsters defeated by Marvel heroes. The field "defeatedMonsters" is an array of one or more monster names.</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('defeatedMonsters')
/// }).run(conn, callback)
/// </code></example>
        public ConcatMap (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Concatenate one or more elements into a single sequence using a mapping function.</para>
/// </summary>
/// <example><para>Example: Construct a sequence of all monsters defeated by Marvel heroes. The field "defeatedMonsters" is an array of one or more monster names.</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('defeatedMonsters')
/// }).run(conn, callback)
/// </code></example>
        public ConcatMap (Arguments args, OptArgs optargs)
             : this(TermType.CONCAT_MAP, args, optargs) {
        }

    protected ConcatMap (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
