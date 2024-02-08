using BCP.Framework;
using BCP.Framework.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BCP.Business.DataAccess
{
    public class Executor
    {
        private string _messageError = String.Empty;
        private List<StoreProcedure> _list = new List<StoreProcedure>();

        public Executor()
        {
        }

        public List<StoreProcedure> Items
        {
            get { return _list; }
        }

        public string Error
        {
            get { return _messageError; }
        }

        public bool Run(string connectionString, int timeout)
        {
            if (_list.Count > 0)
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                SqlTransaction sqlTransaction;
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                try
                {
                    for (int cont = 0; cont < _list.Count; cont++)
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_list[cont].Name, sqlConnection);
                        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sqlDataAdapter.SelectCommand.CommandTimeout = timeout;
                        for (int cont2 = 0; cont2 < _list[cont].Items.Count; cont2++)
                        {
                            if (_list[cont].Items[cont2].Value == null)
                                sqlDataAdapter.SelectCommand.Parameters.AddWithValue(_list[cont].Items[cont2].Name, DBNull.Value);
                            else
                                sqlDataAdapter.SelectCommand.Parameters.AddWithValue(_list[cont].Items[cont2].Name, _list[cont].Items[cont2].Value);
                        }
                        sqlDataAdapter.SelectCommand.Transaction = sqlTransaction;
                        sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                    }
                    sqlTransaction.Commit();
                    _messageError = String.Empty;
                    return true;
                }
                catch (SqlException ex)
                {
                    Logger.Fatal("Message: {0}; Exception: {1}", ex.Message, Json.ToObject(ex));
                    sqlTransaction.Rollback();
                    _messageError = ex.Message;
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                    //SqlConnection.ClearAllPools();
                }
            }
            else
            {
                return true;
            }
        }
    }

    public class StoreProcedure
    {
        private string _name = String.Empty;
        private List<Parameters> _list = new List<Parameters>();
        private string _messageError = String.Empty;

        public StoreProcedure(string name)
        {
            this._name = name;
        }

        public void AddParameter(string name, object value)
        {
            _list.Add(new Parameters(name, value));
        }

        public List<Parameters> Items
        {
            get { return _list; }
            set { _list = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Error
        {
            get { return _messageError; }
        }

        public bool Run(string connectionString, int timeout)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(_name, sqlConnection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = timeout
            };
            for (int cont = 0; cont < _list.Count; cont++)
            {
                if (_list[cont].Value == null)
                    sqlCommand.Parameters.AddWithValue(_list[cont].Name, DBNull.Value);
                else
                    sqlCommand.Parameters.AddWithValue(_list[cont].Name, _list[cont].Value);
            }
            try
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _messageError = String.Empty;
                //SqlConnection.ClearAllPools();
                return true;
            }
            catch (SqlException ex)
            {
                Logger.Fatal("Message: {0}; Exception: {1}", ex.Message, Json.ToObject(ex));
                _messageError = ex.Message;
                sqlConnection.Close();
                //SqlConnection.ClearAllPools();
                return false;
            }
        }

        public DataTable ReturnData(string connectionString, int timeOut)
        {
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(_name, sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.CommandTimeout = timeOut;
            for (int cont = 0; cont < _list.Count; cont++)
            {
                if (_list[cont].Value == null)
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue(_list[cont].Name, DBNull.Value);
                else
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue(_list[cont].Name, _list[cont].Value);
            }
            try
            {
                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
                _messageError = String.Empty;
            }
            catch (SqlException ex)
            {
                Logger.Fatal("Message: {0}; Exception: {1}", ex.Message, Json.ToObject(ex));
                _messageError = ex.Message;
                sqlConnection.Close();
                //SqlConnection.ClearAllPools();
            }
            finally
            {
                sqlConnection.Close();
                //SqlConnection.ClearAllPools();
            }
            return dataTable;
        }
    }

    public class Parameters
    {
        private string _name = String.Empty;
        private object _value = null;

        public Parameters(string name, object value)
        {
            this._name = name;
            this._value = value;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
