












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

    public class Default : ReqlExpr {

    
    
    
/// <summary>
/// <para>Handle non-existence errors. Tries to evaluate and return its first argument. If an
/// error related to the absence of a value is thrown in the process, or if its first
/// argument returns <code>null</code>, returns its second argument. (Alternatively, the second argument
/// may be a function which will be called with either the text of the non-existence error
/// or <code>null</code>.)</para>
/// </summary>
/// <example><para>Example: Suppose we want to retrieve the titles and authors of the table <code>posts</code>.
/// In the case where the author field is missing or <code>null</code>, we want to retrieve the string
/// <code>Anonymous</code>.</para>
/// <code>r.table("posts").map( function(post) {
///     return {
///         title: post("title"),
///         author: post("author").default("Anonymous")
///     }
/// }).run(conn, callback)
/// </code></example>
        public Default (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Handle non-existence errors. Tries to evaluate and return its first argument. If an
/// error related to the absence of a value is thrown in the process, or if its first
/// argument returns <code>null</code>, returns its second argument. (Alternatively, the second argument
/// may be a function which will be called with either the text of the non-existence error
/// or <code>null</code>.)</para>
/// </summary>
/// <example><para>Example: Suppose we want to retrieve the titles and authors of the table <code>posts</code>.
/// In the case where the author field is missing or <code>null</code>, we want to retrieve the string
/// <code>Anonymous</code>.</para>
/// <code>r.table("posts").map( function(post) {
///     return {
///         title: post("title"),
///         author: post("author").default("Anonymous")
///     }
/// }).run(conn, callback)
/// </code></example>
        public Default (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Handle non-existence errors. Tries to evaluate and return its first argument. If an
/// error related to the absence of a value is thrown in the process, or if its first
/// argument returns <code>null</code>, returns its second argument. (Alternatively, the second argument
/// may be a function which will be called with either the text of the non-existence error
/// or <code>null</code>.)</para>
/// </summary>
/// <example><para>Example: Suppose we want to retrieve the titles and authors of the table <code>posts</code>.
/// In the case where the author field is missing or <code>null</code>, we want to retrieve the string
/// <code>Anonymous</code>.</para>
/// <code>r.table("posts").map( function(post) {
///     return {
///         title: post("title"),
///         author: post("author").default("Anonymous")
///     }
/// }).run(conn, callback)
/// </code></example>
        public Default (Arguments args, OptArgs optargs)
             : this(TermType.DEFAULT, args, optargs) {
        }

    protected Default (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
