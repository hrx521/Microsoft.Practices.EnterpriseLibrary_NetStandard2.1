// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration.Fluent;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    ///<summary>
    /// Provides extensions for common database providers.
    ///</summary>
    public static class DatabaseProviderExtensions
    {
        ///<summary>
        /// A Sql database for use with the System.Data.SqlClient namespace.
        ///</summary>
        /// <param name="context">Configuration context</param>
        ///<returns></returns>
        /// <seealso cref="System.Data.SqlClient"/>
        public static IDatabaseSqlDatabaseConfiguration ASqlDatabase(this IDatabaseConfigurationProviders context)
        {
            return new SqlDatabaseConfigurationExtension(context);
        }
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public static IDatabaseAnotherDatabaseConfiguration AnotherDatabaseType(this IDatabaseConfigurationProviders context, string providerName)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            return new AnotherDatabaseConfigurationExtensions(context, providerName);
        }
    }
}
