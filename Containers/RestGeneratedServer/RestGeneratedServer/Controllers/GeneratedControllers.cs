//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.18.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace RestGeneratedServer.Controllers
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.18.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public interface IController
    {

        /// <returns>Success</returns>

        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Column>> ColumnAllAsync();


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Column> ColumnPOSTAsync(Column body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Column> ColumnPUTAsync(Column body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Column> ColumnDELETEAsync(Column body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Column> ColumnGETAsync(System.Guid id);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Database>> DatabaseAllAsync();


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Database> DatabasePOSTAsync(Database body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Database> DatabasePUTAsync(Database body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Database> DatabaseDELETEAsync(Database body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Database> DatabaseGETAsync(System.Guid id);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Row>> RowAllAsync();


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Row> RowPOSTAsync(Row body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Row> RowPUTAsync(Row body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Row> RowDELETEAsync(Row body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Row> RowGETAsync(System.Guid id);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Table>> TableAllAsync();


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Table> TablePOSTAsync(Table body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Table> TablePUTAsync(Table body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Table> TableDELETEAsync(Table body);


        /// <returns>Success</returns>

        System.Threading.Tasks.Task<Table> TableGETAsync(System.Guid id);

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.18.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]

    public partial class Controller : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private IController _implementation;

        public Controller(IController implementation)
        {
            _implementation = implementation;
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("Column")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Column>> ColumnAll()
        {

            return _implementation.ColumnAllAsync();
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("Column")]
        public System.Threading.Tasks.Task<Column> ColumnPOST([Microsoft.AspNetCore.Mvc.FromBody] Column body)
        {

            return _implementation.ColumnPOSTAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("Column")]
        public System.Threading.Tasks.Task<Column> ColumnPUT([Microsoft.AspNetCore.Mvc.FromBody] Column body)
        {

            return _implementation.ColumnPUTAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("Column")]
        public System.Threading.Tasks.Task<Column> ColumnDELETE([Microsoft.AspNetCore.Mvc.FromBody] Column body)
        {

            return _implementation.ColumnDELETEAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("Column/{id}")]
        public System.Threading.Tasks.Task<Column> ColumnGET(System.Guid id)
        {

            return _implementation.ColumnGETAsync(id);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("Database")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Database>> DatabaseAll()
        {

            return _implementation.DatabaseAllAsync();
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("Database")]
        public System.Threading.Tasks.Task<Database> DatabasePOST([Microsoft.AspNetCore.Mvc.FromBody] Database body)
        {

            return _implementation.DatabasePOSTAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("Database")]
        public System.Threading.Tasks.Task<Database> DatabasePUT([Microsoft.AspNetCore.Mvc.FromBody] Database body)
        {

            return _implementation.DatabasePUTAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("Database")]
        public System.Threading.Tasks.Task<Database> DatabaseDELETE([Microsoft.AspNetCore.Mvc.FromBody] Database body)
        {

            return _implementation.DatabaseDELETEAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("Database/{id}")]
        public System.Threading.Tasks.Task<Database> DatabaseGET(System.Guid id)
        {

            return _implementation.DatabaseGETAsync(id);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("Row")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Row>> RowAll()
        {

            return _implementation.RowAllAsync();
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("Row")]
        public System.Threading.Tasks.Task<Row> RowPOST([Microsoft.AspNetCore.Mvc.FromBody] Row body)
        {

            return _implementation.RowPOSTAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("Row")]
        public System.Threading.Tasks.Task<Row> RowPUT([Microsoft.AspNetCore.Mvc.FromBody] Row body)
        {

            return _implementation.RowPUTAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("Row")]
        public System.Threading.Tasks.Task<Row> RowDELETE([Microsoft.AspNetCore.Mvc.FromBody] Row body)
        {

            return _implementation.RowDELETEAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("Row/{id}")]
        public System.Threading.Tasks.Task<Row> RowGET(System.Guid id)
        {

            return _implementation.RowGETAsync(id);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("Table")]
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Table>> TableAll()
        {

            return _implementation.TableAllAsync();
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("Table")]
        public System.Threading.Tasks.Task<Table> TablePOST([Microsoft.AspNetCore.Mvc.FromBody] Table body)
        {

            return _implementation.TablePOSTAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("Table")]
        public System.Threading.Tasks.Task<Table> TablePUT([Microsoft.AspNetCore.Mvc.FromBody] Table body)
        {

            return _implementation.TablePUTAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("Table")]
        public System.Threading.Tasks.Task<Table> TableDELETE([Microsoft.AspNetCore.Mvc.FromBody] Table body)
        {

            return _implementation.TableDELETEAsync(body);
        }

        /// <returns>Success</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("Table/{id}")]
        public System.Threading.Tasks.Task<Table> TableGET(System.Guid id)
        {

            return _implementation.TableGETAsync(id);
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Column
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; }

        [Newtonsoft.Json.JsonProperty("nextColumnId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid NextColumnId { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ColumnType Type { get; set; }

        [Newtonsoft.Json.JsonProperty("tableId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid TableId { get; set; }

        [Newtonsoft.Json.JsonProperty("table", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Table Table { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum ColumnType
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

        _4 = 4,

        _5 = 5,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Database
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("tables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Table> Tables { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Row
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; }

        [Newtonsoft.Json.JsonProperty("tableId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid TableId { get; set; }

        [Newtonsoft.Json.JsonProperty("table", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Table Table { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Table
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("rows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Row> Rows { get; set; }

        [Newtonsoft.Json.JsonProperty("columns", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Column> Columns { get; set; }

        [Newtonsoft.Json.JsonProperty("databaseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid DatabaseId { get; set; }

        [Newtonsoft.Json.JsonProperty("database", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Database Database { get; set; }

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore 472
#pragma warning restore 114
#pragma warning restore 108
#pragma warning restore 3016
#pragma warning restore 8603