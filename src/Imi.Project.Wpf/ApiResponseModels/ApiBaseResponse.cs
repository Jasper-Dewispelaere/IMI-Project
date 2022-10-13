using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.ApiResponseModels
{
    public class ApiBaseResponse<T>
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }
    }
}
