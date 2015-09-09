












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

    public class EpochTime : ReqlExpr {

    
    
    
/// <summary>
/// <para>Create a time object based on seconds since epoch. The first argument is a double and
/// will be rounded to three decimal places (millisecond-precision).</para>
/// </summary>
/// <example><para>Example: Update the birthdate of the user "John" to November 3rd, 1986.</para>
/// <code>r.table("user").get("John").update({birthdate: r.epochTime(531360000)})
///     .run(conn, callback)
/// </code></example>
        public EpochTime (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Create a time object based on seconds since epoch. The first argument is a double and
/// will be rounded to three decimal places (millisecond-precision).</para>
/// </summary>
/// <example><para>Example: Update the birthdate of the user "John" to November 3rd, 1986.</para>
/// <code>r.table("user").get("John").update({birthdate: r.epochTime(531360000)})
///     .run(conn, callback)
/// </code></example>
        public EpochTime (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Create a time object based on seconds since epoch. The first argument is a double and
/// will be rounded to three decimal places (millisecond-precision).</para>
/// </summary>
/// <example><para>Example: Update the birthdate of the user "John" to November 3rd, 1986.</para>
/// <code>r.table("user").get("John").update({birthdate: r.epochTime(531360000)})
///     .run(conn, callback)
/// </code></example>
        public EpochTime (Arguments args, OptArgs optargs)
             : this(TermType.EPOCH_TIME, args, optargs) {
        }

    protected EpochTime (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
