using LogBook.Entities.Entities;
using System.Collections.Generic;

namespace ZonetCMS.Web.Areas.Admin.ViewModels.AnalyticManager
{
    public class LogEntriesViewModel
    {
        public IEnumerable<LogEntry> LogEntries { get; set; }
    }
}