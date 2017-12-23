using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

using AME.Entities;
using AME.Framework;

namespace AME.Data
{
    public class MemberDAC : DataAccessComponent, IMemberDAC
    {
        /// <summary>
        /// Deletes an existing row in the Members table.
        /// </summary>
        /// <param name="memberID">A Member entity object ID.</param>
        public void DeleteMember(int memberID)
        {
            const string SQL_STATEMENT =
                "Delete FROM dbo.Members " +
                "WHERE [MemberId]=@MemberId ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@MemberId", DbType.AnsiString, memberID);
 
                // Execute SQL.
                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Inserts a new row in the Members table.
        /// </summary>
        /// <param name="member">A Member object.</param>
        /// <returns>An updated Member object.</returns>
        public void InsertMember(Member member)
        {
            const string SQL_STATEMENT =
                "INSERT INTO dbo.Members (" +
                    "[FirstName], " +
                    "[LastName], " +
                    "[Address], " +
                    "[City], " +
                    "[State], " +
                    "[Zip]" +
                        ") " +
                "VALUES(@FirstName, @LastName, @Address, @City, @State, @Zip);";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@FirstName", DbType.AnsiString, member.FirstName);
                db.AddInParameter(cmd, "@LastName", DbType.AnsiString, member.LastName);
                db.AddInParameter(cmd, "@Address", DbType.AnsiString, member.Address);
                db.AddInParameter(cmd, "@City", DbType.AnsiString, member.City);
                db.AddInParameter(cmd, "@State", DbType.AnsiString, member.State);
                db.AddInParameter(cmd, "@Zip", DbType.AnsiString, member.Zip);

                // Execute SQL.
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
                    "[FirstName]=@FirstName, " +
                    "[LastName]=@LastName, " +
                    "[Address]=@Address, " +
                    "[City]=@City, " +
                    "[State]=@State, " +
                    "[ZIP]=@ZIP " +
                "WHERE [MemberId]=@MemberId ";

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                // Set parameter values.
                db.AddInParameter(cmd, "@FirstName", DbType.AnsiString, member.FirstName);
                db.AddInParameter(cmd, "@LastName", DbType.AnsiString, member.LastName);
                db.AddInParameter(cmd, "@Address", DbType.AnsiString, member.Address);
                db.AddInParameter(cmd, "@City", DbType.AnsiString, member.City);
                db.AddInParameter(cmd, "@State", DbType.AnsiString, member.State);
                db.AddInParameter(cmd, "@ZIP", DbType.AnsiString, member.Zip);
                db.AddInParameter(cmd, "@MemberId", DbType.AnsiString, member.MemberID);

                // Execute SQL.
                db.ExecuteNonQuery(cmd);
            }
        }

        /// <summary>
        /// Lists members.
        /// </summary>
        /// <returns>Returns all members.</returns>
        public List<Member> ListMembers()
        {
            const string SQL_STATEMENT =
                "SELECT *" +
                "FROM dbo.MEMBERS";

            List<Member> result = new List<Member>();

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        // Create a new member.
                        Member member = LoadMember(dr);

                        // Add to List.
                        result.Add(member);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Creates a new Member from a Datareader.
        /// </summary>
        /// <param name="dr">A DataReader object.</param>
        /// <returns>Returns a Member.</returns>		
        private Member LoadMember(IDataReader dr)
        {
            // Create a new Member.
            Member member = new Member();

            // Read values.
            member.MemberID = GetDataValue<int>(dr, "MemberID");
            member.FirstName = GetDataValue<string>(dr, "FirstName");
            member.LastName = GetDataValue<string>(dr, "LastName");
            member.Address = GetDataValue<string>(dr, "Address");
            member.City = GetDataValue<string>(dr, "City");
            member.State = EnumHelper.ParseEnum<State>(GetDataValue<string>(dr, "State")); // Convert string data to enum constant.
            member.Zip = GetDataValue<string>(dr, "Zip");
                 
            return member;
        }

        /// <summary>
        /// GetMemberById business method. 
        /// </summary>
        /// <param name="memberID">A memberID value.</param>
        /// <returns>Returns a Member object.</returns>
        public Member GetMemberById(int memberID)
        {
            const string SQL_STATEMENT =
                "SELECT [MemberID], [FirstName], [LastName], [Address], [City], [State], [ZIP] " +
                "FROM dbo.Members " +
                "WHERE [MemberID]=@MemberID ";

            Member member = null;

            // Connect to database.
            Database db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);
            using (DbCommand cmd = db.GetSqlStringCommand(SQL_STATEMENT))
            {
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, memberID);

                using (IDataReader dr = db.ExecuteReader(cmd))
                {
                    if (dr.Read())
                    {
                        // Create a new Member
                        member = LoadMember(dr);
                    }
                }
            }

            return member;
        }
    }
}
