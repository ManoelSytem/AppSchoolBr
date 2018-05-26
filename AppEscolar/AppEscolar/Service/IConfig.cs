using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppEscolar.Service
{
    public interface IConfig
    {
        string DiretorioSQLite { get; }
        ISQLitePlatform Plataforma { get; }
    }
}
