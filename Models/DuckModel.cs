using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trustedpartners_assignment.Models
{
    public class DuckModel
    {
        public class MainRoot
        {
            public List<Topics> RelatedTopics { get; set; }
        }

        public class Topics
        {
            public string FirstURL { get; set; }
            public string Text { get; set; }
        }






        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Icon
        {
            public string Height { get; set; }
            public string URL { get; set; }
            public string Width { get; set; }
        }

        public class Topic
        {
            public string FirstURL { get; set; }
            public Icon Icon { get; set; }
            public string Result { get; set; }
            public string Text { get; set; }
        }

        public class RelatedTopic
        {
            public string FirstURL { get; set; }
            public Icon Icon { get; set; }
            public string Result { get; set; }
            public string Text { get; set; }
            public string Name { get; set; }
            public List<Topic> Topics { get; set; }
        }

        public class Developer
        {
            public string name { get; set; }
            public string type { get; set; }
            public string url { get; set; }
        }

        public class Maintainer
        {
            public string github { get; set; }
        }

        public class SrcOptions
        {
            public string directory { get; set; }
            public int is_fanon { get; set; }
            public int is_mediawiki { get; set; }
            public int is_wikipedia { get; set; }
            public string language { get; set; }
            public string min_abstract_length { get; set; }
            public int skip_abstract { get; set; }
            public int skip_abstract_paren { get; set; }
            public string skip_end { get; set; }
            public int skip_icon { get; set; }
            public int skip_image_name { get; set; }
            public string skip_qr { get; set; }
            public string source_skip { get; set; }
            public string src_info { get; set; }
        }
    }
}
