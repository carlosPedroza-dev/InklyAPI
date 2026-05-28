using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inkly.Domain
{
    public class Document
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int WordCount { get; set; }
        public Doctype Doctype { get; set; }
        public ICollection<CoachingSession> Sessions { get; set; } = new List<CoachingSessions>();
        public ICollection<RewriteThreads> RewriteThreads { get; set; } = new List<RewriteThread>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
