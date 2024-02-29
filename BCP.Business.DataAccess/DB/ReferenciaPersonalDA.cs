using BCP.Business.Models;
using BCP.Framework;
using BCP.Framework.Logs;
using System;
using System.Collections.Generic;
using System.Data;

namespace BCP.Business.DataAccess.DB
{
    public class ReferenciaPersonalDA
    {
        private readonly string _connection;
        private readonly int _timeOut;

        public ReferenciaPersonalDA(string connectionString, int timeOut)
        {
            _connection = connectionString;
            _timeOut = timeOut;
        }

        public Response GetNewClientsByBlock(int block)
        {
            try
            {
                var listClients = new List<Client>();
                StoreProcedure storeProcedure = new StoreProcedure("bill.CLIENTE_Get_NewClientsByBlock");
                storeProcedure.AddParameter("@BLOCK_IT", block);

                DataTable dataTable = storeProcedure.ReturnData(_connection, _timeOut);
                Logger.Debug("StoreProcedure: {0} DataTable: {1}", Json.ToObject(storeProcedure), Json.ToObject(dataTable));

                if (storeProcedure.Error.Length <= 0)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            var client = new Client()
                            {
                                Id = (int)dataTable.Rows[i]["CLIE_ID_IT"]
                            };
                            listClients.Add(client);
                        }
                        return Response.Success(listClients);
                    }
                    else
                    {
                        Logger.Error("Message: {0} DataTable: {1}", Validation.ErrorMessage(Validation.ErrorMessages.UnidentifiedBusiness), Json.ToObject(dataTable));
                        return Response.Error(dataTable, Validation.ErrorMessages.UnidentifiedBusiness);
                    }
                }
                else
                {
                    Logger.Error("Message: {0} StoreProcedure.Error: {1}", Validation.ErrorMessage(Validation.ErrorMessages.Sql), storeProcedure.Error);
                    return Response.Error(storeProcedure.Error, Validation.ErrorMessages.Sql);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Message: {0} Exception: {1}", ex.Message, Json.ToObject(ex));
                return Response.Exception(ex);
            }
        }

        public Response InsertNewClientsIntoPersonalReferences()
        {
            try
            {
                List<Client> listClients = new List<Client>();
                StoreProcedure storeProcedure = new StoreProcedure("bill.CLIENTE_InsertNewClientsIntoPersonalReferences");

                DataTable dataTable = storeProcedure.ReturnData(_connection, _timeOut);
                Logger.Debug("StoreProcedure: {0} DataTable: {1}", Json.ToObject(storeProcedure), Json.ToObject(dataTable));

                if (storeProcedure.Error.Length <= 0)
                {
                    return Response.Success(null);
                }
                else
                {
                    Logger.Error("Message: {0} StoreProcedure.Error: {1}", Validation.ErrorMessage(Validation.ErrorMessages.Sql), storeProcedure.Error);
                    return Response.Error(storeProcedure.Error, Validation.ErrorMessages.Sql);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Message: {0} Exception: {1}", ex.Message, Json.ToObject(ex));
                return Response.Exception(ex);
            }
        }
    }
}
