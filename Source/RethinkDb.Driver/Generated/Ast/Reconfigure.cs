












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

    public class Reconfigure : ReqlExpr {

    
    
    
/// <summary>
/// <para>Reconfigure a table's sharding and replication.</para>
/// </summary>
/// <example><para>Example: Reconfigure a table.</para>
/// <code>&gt; r.table('superheroes').reconfigure({shards: 2, replicas: 1}).run(conn, callback);
/// </code></example>
        public Reconfigure (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Reconfigure a table's sharding and replication.</para>
/// </summary>
/// <example><para>Example: Reconfigure a table.</para>
/// <code>&gt; r.table('superheroes').reconfigure({shards: 2, replicas: 1}).run(conn, callback);
/// </code></example>
        public Reconfigure (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Reconfigure a table's sharding and replication.</para>
/// </summary>
/// <example><para>Example: Reconfigure a table.</para>
/// <code>&gt; r.table('superheroes').reconfigure({shards: 2, replicas: 1}).run(conn, callback);
/// </code></example>
        public Reconfigure (Arguments args, OptArgs optargs)
             : this(TermType.RECONFIGURE, args, optargs) {
        }

    protected Reconfigure (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "shards": "T_NUM",
///  "replicas": [
///    "T_OBJECT",
///    "T_NUM"
///  ],
///  "primary_replica_tag": "T_STR",
///  "dry_run": "T_BOOL",
///  "nonvoting_replica_tags": "T_ARRAY",
///  "emergency_repair": "E_EMERGENCY_REPAIR"
///</summary>
        public Reconfigure optArg(string optname, object value) {
             var newOptargs = OptArgs.FromMap(this.OptArgs)
                                     .With(optname, value);
             return new Reconfigure (this.Args, newOptargs);
        }


    

    


    
    }
}
