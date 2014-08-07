//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published
//  by the Free Software Foundation; either version 2 of the License, or
//  (at your option) version 3.

//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.

//  You should have received a copy of the GNU Lesser General Public License
//  along with this program; if not, write to the
//  Free Software Foundation, Inc.,
//  51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaWiki
{
    public class MediaWiki
    {
        /// <summary>
        /// Name of this wiki instance, optional and null by default
        /// </summary>
        public string Name = null;

        public string ScriptUrlSuffix = "w/";

        /// <summary>
        /// Suffix for article path, by default wiki/
        /// </summary>
        public string WikiUrlSuffix = "wiki/";

        /// <summary>
        /// URL of this wiki
        /// </summary>
        protected string BaseURL = null;

        public string WikiURL
        {
            get
            {
                if (this.BaseURL == null)
                    throw new MediaWikiException("BaseURL of this MediaWiki instance must not be null");
                if (this.WikiUrlSuffix == null)
                    throw new MediaWikiException("WikiUrlSuffix of this MediaWiki instance must not be null");

                return this.BaseURL + this.WikiUrlSuffix;
            }
        }

        public string ScriptURL
        {
            get
            {
                if (this.BaseURL == null)
                    throw new MediaWikiException("BaseURL of this MediaWiki instance must not be null");
                if (this.WikiUrlSuffix == null)
                    throw new MediaWikiException("WikiUrlSuffix of this MediaWiki instance must not be null");

                return this.BaseURL + this.ScriptUrlSuffix;
            }
        }

        public MediaWiki(string name, string url)
        {
            this.Name = name;
            this.BaseURL = url;
        }
    }
}
