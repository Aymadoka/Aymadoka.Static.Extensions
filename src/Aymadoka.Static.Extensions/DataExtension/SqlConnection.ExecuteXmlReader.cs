using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Xml;

namespace Aymadoka.Static.DataExtension
{

    public static partial class DataExtensions
    {
        public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType, SqlTransaction transaction)
        {
            using (SqlCommand command = @this.CreateCommand())
            {
                command.CommandText = cmdText;
                command.CommandType = commandType;
                command.Transaction = transaction;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteXmlReader();
            }
        }

        public static XmlReader ExecuteXmlReader(this SqlConnection @this, Action<SqlCommand> commandFactory)
        {
            using (SqlCommand command = @this.CreateCommand())
            {
                commandFactory(command);

                return command.ExecuteXmlReader();
            }
        }

        public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText)
        {
            return @this.ExecuteXmlReader(cmdText, null, CommandType.Text, null);
        }

        public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlTransaction transaction)
        {
            return @this.ExecuteXmlReader(cmdText, null, CommandType.Text, transaction);
        }

        public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, CommandType commandType)
        {
            return @this.ExecuteXmlReader(cmdText, null, commandType, null);
        }

        public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, CommandType commandType, SqlTransaction transaction)
        {
            return @this.ExecuteXmlReader(cmdText, null, commandType, transaction);
        }

        public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlParameter[] parameters)
        {
            return @this.ExecuteXmlReader(cmdText, parameters, CommandType.Text, null);
        }

        public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlParameter[] parameters, SqlTransaction transaction)
        {
            return @this.ExecuteXmlReader(cmdText, parameters, CommandType.Text, transaction);
        }

        public static XmlReader ExecuteXmlReader(this SqlConnection @this, string cmdText, SqlParameter[] parameters, CommandType commandType)
        {
            return @this.ExecuteXmlReader(cmdText, parameters, commandType, null);
        }
    }
}