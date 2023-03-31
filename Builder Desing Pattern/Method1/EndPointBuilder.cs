using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desing_Patterns.Method1
{
    public class EndPointBuilder
    {
        private readonly StringBuilder sburl =new();
        private readonly StringBuilder sbparams =new();
        private const char defaultDelimiter= '/';
        public string BaseUrl { get; set; }
        public EndPointBuilder(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
        public EndPointBuilder Append(string value) 
        {
            sburl.Append(value);
            sburl.Append(defaultDelimiter);
            return this;
        }

        public EndPointBuilder AppendParam(string name, string value)
        {
            sbparams.AppendFormat("{0}={1}&",name,value);
            return this;
        }
        public string Build()
        {
            if (BaseUrl.EndsWith(defaultDelimiter))
            {
                sburl.Insert(0, BaseUrl);
            }
            else
            {
                sburl.Insert(0, BaseUrl + defaultDelimiter);
            }
            var url = sburl.ToString().TrimEnd('&');

            if (sbparams.Length>0)
            {
                string qParams = sbparams.ToString().TrimEnd('&');
                url = sburl.ToString().TrimEnd(defaultDelimiter).TrimEnd('?');

                url = $"{url}?{qParams}";
            }
            return url.TrimEnd(defaultDelimiter);
        }
    }

}
