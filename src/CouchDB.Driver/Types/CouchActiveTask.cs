#nullable disable
using System;
using CouchDB.Driver.Helpers;
using Newtonsoft.Json;

namespace CouchDB.Driver.Types
{
    /// <summary>
    /// Represents an active task.
    /// </summary>
    public sealed class CouchActiveTask
    {
        [JsonProperty("node")]
        public string Node { get; set; }
        
        [JsonProperty("pid")]
        public string PID { get; set; }
        
        [JsonProperty("process_status")]
        public string ProcessStatus { get; set; }
        
        [JsonProperty("changes_pending")]
        public int? ChangesPending { get; set; }
        
        [JsonProperty("checkpoint_interval")]
        public int CheckpointInterval { get; set; }
        
        [JsonProperty("checkpointed_source_seq")]
        public string CheckpointedSourceSequence { get; set; }
        
        [JsonProperty("continuous")]
        public bool Continuous { get; set; }
        
        [JsonProperty("database")]
        public string Database { get; set; }
        
        [JsonProperty("doc_id")]
        public string DocumentId { get; set; }
        
        [JsonProperty("doc_write_failures")]
        public int DocumentWriteFailures { get; set; }
        
        [JsonProperty("docs_read")]
        public int DocumentsRead { get; set; }
        
        [JsonProperty("docs_written")]
        public int DocumentsWritten { get; set; }
        
        [JsonProperty("missing_revisions_found")]
        public int MissingRevisionsFound { get; set; }
        
        [JsonProperty("replication_id")]
        public string ReplicationId { get; set; }
        
        [JsonProperty("revisions_checked")]
        public int RevisionsChecked { get; set; }
        
        [JsonProperty("source")]
        public string Source { get; set; }
        
        [JsonProperty("source_seq")]
        public object SourceSequence { get; set; }

        [JsonProperty("started_on")]
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime StartedOn { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("through_seq")]
        public string ThroughSequence { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated_on")]
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime UpdatedOn { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }
    }
}
#nullable restore