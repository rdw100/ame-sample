using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using WIC.Entities;

namespace WIC.Data
{
    public class MemberDAC: DataAccessComponent
    {
        /// <summary>
        /// Inserts a new row in the Members table.
        /// </summary>
        /// <param name="member">A Member object.</param>
        /// <returns>An updated Member object.</returns>
        public void InsertMember(Member member)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Members ([Name], [Address], [City], [State], [Zip]) " +
                "VALUES(@Name, @Address, @City, @State, @Zip);"; 

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Name", DbType.AnsiString, member.MemberName);
                db.AddInParameter(cmd, "@Address", DbType.AnsiString, member.Address);
                db.AddInParameter(cmd, "@City", DbType.AnsiString, member.City);
                db.AddInParameter(cmd, "@State", DbType.AnsiString, member.State);
                db.AddInParameter(cmd, "@Zip", DbType.AnsiString, member.Zip);

                // Get the primary key value.
               db.ExecuteScalar(cmd);
            }            
        }

        /// <summary>
        /// Updates an existing row in the Members table.
        /// </summary>
        /// <param name="member">A Member entity object.</param>
        public void UpdateMember(Member member)
        {
            const string SQL_STATEMENT =
                "UPDATE dbo.Members " +
                "SET " +
                    "[Name]=@Name, " +
                    "[Address]=@Address, " +
                    "[City]=@City " +
                    "[State]=@State " +
                    "[ZIP]=@ZIP " +
                "WHERE [MemberId]=@MemberId ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@Name", DbType.AnsiString, member.MemberName);
                db.AddInParameter(cmd, "@Address", DbType.AnsiString, member.Address);
                db.AddInParameter(cmd, "@City", DbType.AnsiString, member.City);
                db.AddInParameter(cmd, "@State", DbType.AnsiString, member.State);
                db.AddInParameter(cmd, "@ZIP", DbType.AnsiString, member.Zip);

                db.ExecuteNonQuery(cmd);
            }
        }

    }
}
