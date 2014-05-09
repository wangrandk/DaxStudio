﻿using ADOTabular;

namespace DaxStudio.UI.Events
{
    public class UpdateConnectionEvent
    {
        public UpdateConnectionEvent(ADOTabular.ADOTabularConnection connection)
        {
            Connection = connection;
        }

        public UpdateConnectionEvent(ADOTabular.ADOTabularConnection connection,string databaseName)
        {
            Connection = connection;
            DatabaseName = databaseName;
        }

        public  ADOTabularConnection Connection{get; set; }
        public string DatabaseName { get; set; }
    }
}