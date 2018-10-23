using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace Scan_Project
{
    class dbConnections
    {
        private string startPath = Application.StartupPath;

        OleDbConnection cn;

        public dbConnections()
        {
            cn = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={startPath}\\scanDB.accdb");
        }

        private string GenerateHashString(HashAlgorithm algo, string text)
        {
            // Compute hash from text parameter
            algo.ComputeHash(Encoding.UTF8.GetBytes(text));

            // Get has value in array of bytes
            var result = algo.Hash;

            // Return as hexadecimal string
            return string.Join(
                string.Empty,
                result.Select(x => x.ToString("x2")));
        }

        private string MD5(string text)
        {
            var result = default(string);

            using (var algo = new MD5CryptoServiceProvider())
            {
                result = GenerateHashString(algo, text);
            }

            return result;
        }

        /// <summary>
        /// گرفتن پروژه ها
        /// </summary>
        /// <returns>جدول پروژه‌ها</returns>
        public DataTable GetProjects()
        {
            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from Projects";
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            try
            {
                cn.Open();
                da.Fill(dt);
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        /// <summary>
        /// ایجاد پروژه جدید
        /// </summary>
        /// <param name="projectName">اسم پروژه</param>
        public void InsertProjects(string projectName)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = string.Format("insert into Projects (projectName, projectStartDate) values ('{0}', '{1}')",
                                                                    projectName, System.DateTime.Now);
            cmd.Connection = cn;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// چک کردن یوزر و پسورد وارد شده.
        /// </summary>
        /// <param name="userName">نام کاربری</param>
        /// <param name="password">رمز عبور</param>
        /// <returns></returns>
        public bool CheckUser(string userName, string password, out byte userRole)
        {            
            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = $"SELECT userName, userRole from Users where userName='{userName}' and userPassword='{MD5(password)}' and userIsActive=true";
            cmd.Connection = cn;
            
            try
            {
                cn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            userRole = System.Convert.ToByte(dt.Rows[0][1].ToString());
            return dt.Rows.Count > 0 ? true : false;
        }

        /// <summary>
        /// اضافه کردن شاخص‌ها به دیتابیس
        /// </summary>
        /// <param name="item1">شاخص اول</param>
        /// <param name="item2">شاخص دوم</param>
        /// <param name="item3">شاخص سوم</param>
        public void InsertItems(string item1, string item2, string item3)
        {
            InsertOneItem(Properties.Settings.Default.projectID + "-1", item1);
            InsertOneItem(Properties.Settings.Default.projectID + "-2", item2);
            InsertOneItem(Properties.Settings.Default.projectID + "-3", item3);
        }

        void InsertOneItem(string itemCode, string itemName)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = string.Format("insert into Items (itemCode, itemName) values ('{0}', '{1}')",
                                                                itemCode, itemName);
            cmd.Connection = cn;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetItems()
        {
            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = string.Format("select * from Items where itemCode like '{0}-%'", Properties.Settings.Default.projectID);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            try
            {
                cn.Open();
                da.Fill(dt);
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public void InsertNewUser(string userName, string password, byte role)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = string.Format("insert into Users (userName, userPassword, userRole, userIsActive) values ('{0}', '{1}', {2}, true)",
                                                                userName, MD5(password), role);
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// متدی برای گرفتن جدول اسناد از دیتابیس
        /// </summary>
        /// <param name="itemNames">این جدول شامل مشخصات شاخص‌های مرتبط با پروژه است.</param>
        /// <returns>جدول اسناد</returns>
        public DataTable GetDocs(out DataTable itemNames)
        {
            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = string.Format("select * from Documents where projectID = {0}" +
                "", Properties.Settings.Default.projectID);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            try
            {
                cn.Open();
                da.Fill(dt);
                cn.Close();

                itemNames = GetItems();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        /// <summary>
        /// گرفتن جدول اسناد بر اساس آی دی
        /// </summary>
        /// <param name="itemNames">خروجی شاخص ها</param>
        /// <param name="docID">آی دی  سند</param>
        /// <returns></returns>
        public DataTable GetDocs(out DataTable itemNames, string docID)
        {
            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = string.Format("select * from Documents where ID = {0} and projectID = {1}" +
                "", docID, Properties.Settings.Default.projectID);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            try
            {
                cn.Open();
                da.Fill(dt);
                cn.Close();

                itemNames = GetItems();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable GetDocs(out DataTable itemNames, string item1, string item2, string item3, string fromDate, string toDate)
        {
            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand();
            string q1 = !string.IsNullOrWhiteSpace(item1) ? string.Format("item1 like '%{0}%' or", item1) : "";
            string q2 = !string.IsNullOrWhiteSpace(item2) ? string.Format("item2 like '%{0}%' or", item2) : "";
            string q3 = !string.IsNullOrWhiteSpace(item3) ? string.Format("item3 like '%{0}%' or", item3) : "";
            string q4;
            if (!string.IsNullOrWhiteSpace(fromDate))
            {
                if (!string.IsNullOrWhiteSpace(toDate))
                    q4 = string.Format("docSubmitDate between #{0}# and #{1}# or", fromDate, toDate);
                else
                    q4 = string.Format("docSubmitDate between #{0}# and #{1}# or", fromDate, System.DateTime.Now.ToString());
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(toDate))
                    q4 = string.Format("docSubmitDate between #{0}# and #{1}# or", "10/10/1900", toDate);
                else
                    q4 = "";
            }

            string commandText = string.Format("select * from Documents where projectID = {0} and ({1} {2} {3} {4})",
                Properties.Settings.Default.projectID, q1, q2, q3, q4);

            commandText = commandText.Remove(commandText.LastIndexOf("or"));
            commandText = commandText + ")";

            cmd.CommandText = commandText;
            
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            try
            {
                cn.Open();
                da.Fill(dt);
                cn.Close();

                itemNames = GetItems();                
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        /// <summary>
        /// اضافه کردن یک سند به دیتابیس
        /// </summary>
        /// <param name="item1">شاخص اول</param>
        /// <param name="item2">شاخص دوم</param>
        /// <param name="item3">شاخص سوم</param>
        /// <param name="imageSrc">آدرس تصویر سند نسبت به محل اجرای پروژه.</param>
        public void InsertDocs(string item1, string item2, string item3, string imageSrc)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = 
                string.Format("insert into Documents (item1, item2, item3, projectID, imageSrc, docSubmitDate)" +
                " values ('{0}', '{1}', '{2}', {3}, '{4}', '{5}')",
                item1, item2, item3, Properties.Settings.Default.projectID, imageSrc, System.DateTime.Now);
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = $"SELECT userName, userRole from Users where userIsActive=true";
            cmd.Connection = cn;

            try
            {
                cn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public DataTable GetUsers(string username)
        {
            DataTable dt = new DataTable();

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = $"SELECT userName, userRole from Users where userName = '{username}' and userIsActive=true";
            cmd.Connection = cn;

            try
            {
                cn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public void UpdateDocs(string item1, string item2, string item3, string docID)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText =
                string.Format("update Documents set item1 = '{0}', item2 = '{1}', item3 = '{2}', docLastChangeDate = '{3}', docLastChangeUser = '{4}' " +
                "where ID = {5}",
                item1, item2, item3, System.DateTime.Now, Properties.Settings.Default.userName, docID);
            cmd.Connection = cn;
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
